using DogsVsCatsWeb.Parsers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System;
using DogsVsCatsWeb.Data;
using System.Linq;
using DogsVsCatsWeb.Models;
using System.Net.Http.Headers;
using System.IO;
using WebApi.OutputCache.V2;
using System.Drawing;
using DogsVsCatsWeb.Service;
using Newtonsoft.Json;

namespace DogsVsCatsWeb.Controllers
{

    public class AppController : ApiController
    {
        [HttpGet]
        [Route("api/app")]
        public IList<PredictionResult> Get()
        {
            using (var db = new DogsVsCatsEntities())
            {
                return db.Predictions
                    .OrderByDescending(p => p.CreatedOn)
                     .Select(
                    p => new PredictionResult()
                    {
                        Id = p.Id,
                        DogProbability = p.DogProbability,
                        CatProbability = p.CatProbability
                    })                    
                    .Take(20)
                   .ToList();
            }
        }

        [HttpGet]
        [CacheOutput(ClientTimeSpan = 3600, ServerTimeSpan = 3600)]
        [Route("api/app/{predictionId}")]
        public HttpResponseMessage GetImage(Guid predictionId)
        {
            using (var db = new DogsVsCatsEntities())
            {
                var prediction = db.Predictions.First(p => p.Id == predictionId);

                HttpResponseMessage response = new HttpResponseMessage();
                response.Content = new StreamContent(new MemoryStream(prediction.Data));
                response.Content.Headers.ContentType = new MediaTypeHeaderValue(prediction.ContentType);

                return response;
            }
        }

        [HttpPost]
        [Route("api/app")]
        public HttpResponseMessage Post()
        {
            MultipartParser parser = new MultipartParser(HttpContext.Current.Request.InputStream);
            if (!parser.Success)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            PredictAndSaveRequest(parser);
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }


        private void PredictAndSaveRequest(MultipartParser parser)
        {
            using (var db = new DogsVsCatsEntities())
            {

                Predictor predictor = new Predictor();

                var predictionResult = predictor.PredictImage(parser.FileContents);               

                var prediction = new Prediction
                {
                    Id = Guid.NewGuid(),
                    ContentType = parser.ContentType,
                    FileName = parser.Filename,
                    CreatedOn = DateTimeOffset.UtcNow,
                    Data = parser.FileContents,
                    DogProbability = predictionResult.dogProbability,
                    CatProbability = predictionResult.catProbability
                };

                db.Predictions.Add(prediction);
                db.SaveChanges();

            }
        }
    }
}
