using DogsVsCatsWeb.Models;
using DogsVsCatsWeb.Service.ResponseModel;
using Grpc.Core;
using ImageProcessor;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using Tensorflow;
using Tensorflow.Serving;

namespace DogsVsCatsWeb.Service
{
    public class Predictor
    {
        public (double dogProbability, double catProbability) PredictImage(byte[] imageData)
        {
            Channel channel = new Channel(ConfigurationManager.AppSettings["ServingRpcChannel"], ChannelCredentials.Insecure);
            try
            {
                using (var factory = new ImageFactory())
                {
                    factory.Load(imageData);

                    var originalWidth = factory.Image.Width;
                    var originalHeight = factory.Image.Height;

                    var client = new PredictionService.PredictionServiceClient(channel);
                    var request = new PredictRequest()
                    {
                        ModelSpec = new ModelSpec()
                        {
                            Name = ConfigurationManager.AppSettings["ModelName"],
                            Version = int.Parse(ConfigurationManager.AppSettings["ModelVersion"]),
                            SignatureName = ConfigurationManager.AppSettings["ModelSignature"]
                        }
                    };

                    var imageWidth = int.Parse(ConfigurationManager.AppSettings["ImageWidth"]);
                    var imageHeight = int.Parse(ConfigurationManager.AppSettings["ImageHeight"]);

                    var proto = new TensorProto
                    {
                        TensorShape = new TensorShapeProto()
                    };
                    proto.TensorShape.Dim.Add(new TensorShapeProto.Types.Dim() { Size = 1 }); // one image in batch
                    proto.TensorShape.Dim.Add(new TensorShapeProto.Types.Dim() { Size = imageHeight });
                    proto.TensorShape.Dim.Add(new TensorShapeProto.Types.Dim() { Size = imageWidth });
                    proto.TensorShape.Dim.Add(new TensorShapeProto.Types.Dim() { Size = 3 }); // 3 colour channels
                    proto.Dtype = DataType.DtFloat;

                    using (var resizedImage = factory.Resize(new Size(imageWidth, imageHeight)))
                    {
                        using (var bitmap = new Bitmap(resizedImage.Image))
                        {
                            GetData(bitmap, proto);
                            request.Inputs.Add(ConfigurationManager.AppSettings["ModelInputName"], proto);
                            var result = client.Predict(request);
                            var response = JsonConvert.DeserializeObject<ResponseObject>(result.Outputs.ToString());

                            var dogProbability = (float)response.outputs.floatVal[1];
                            var catProbability = (float)response.outputs.floatVal[0];

                            return (dogProbability, catProbability);                            
                        }
                    }

                    
                } 
            }            
            finally
            {
                channel.ShutdownAsync().Wait();
            }
        }

        private void GetData(Bitmap myBitmap, TensorProto proto)
        {
            // Important : load data column by column
            for (var i = 0; i < myBitmap.Height; i++)
            {
                for (var j = 0; j < myBitmap.Width; j++)
                {
                    Color pixelColor = myBitmap.GetPixel(j, i);
                    proto.FloatVal.Add(AdjustPixel(pixelColor.R));
                    proto.FloatVal.Add(AdjustPixel(pixelColor.G));
                    proto.FloatVal.Add(AdjustPixel(pixelColor.B));
                }
            }
        }

        // This is needed as inception model is trained with input procprocessed
        // to be standardised with mean of 0 and ranging from -1 to 1
        private float AdjustPixel(float pixel)
        {
            return ((pixel / 255.0F) - 0.5F) * 2;
        }
    }
}