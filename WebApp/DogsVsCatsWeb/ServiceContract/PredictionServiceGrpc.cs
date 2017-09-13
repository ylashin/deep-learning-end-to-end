// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: prediction_service.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Tensorflow.Serving {
  /// <summary>
  /// PredictionService provides access to machine-learned models loaded by
  /// model_servers.
  /// </summary>
  public static partial class PredictionService
  {
    static readonly string __ServiceName = "tensorflow.serving.PredictionService";

    static readonly grpc::Marshaller<global::Tensorflow.Serving.PredictRequest> __Marshaller_PredictRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.PredictRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tensorflow.Serving.PredictResponse> __Marshaller_PredictResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tensorflow.Serving.PredictResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Tensorflow.Serving.PredictRequest, global::Tensorflow.Serving.PredictResponse> __Method_Predict = new grpc::Method<global::Tensorflow.Serving.PredictRequest, global::Tensorflow.Serving.PredictResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Predict",
        __Marshaller_PredictRequest,
        __Marshaller_PredictResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Tensorflow.Serving.PredictionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PredictionService</summary>
    public abstract partial class PredictionServiceBase
    {
      /// <summary>
      /// Predict -- provides access to loaded TensorFlow model.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Tensorflow.Serving.PredictResponse> Predict(global::Tensorflow.Serving.PredictRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PredictionService</summary>
    public partial class PredictionServiceClient : grpc::ClientBase<PredictionServiceClient>
    {
      /// <summary>Creates a new client for PredictionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PredictionServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PredictionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PredictionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PredictionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PredictionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Predict -- provides access to loaded TensorFlow model.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.PredictResponse Predict(global::Tensorflow.Serving.PredictRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Predict(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Predict -- provides access to loaded TensorFlow model.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tensorflow.Serving.PredictResponse Predict(global::Tensorflow.Serving.PredictRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Predict, null, options, request);
      }
      /// <summary>
      /// Predict -- provides access to loaded TensorFlow model.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.PredictResponse> PredictAsync(global::Tensorflow.Serving.PredictRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PredictAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Predict -- provides access to loaded TensorFlow model.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tensorflow.Serving.PredictResponse> PredictAsync(global::Tensorflow.Serving.PredictRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Predict, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PredictionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PredictionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PredictionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Predict, serviceImpl.Predict).Build();
    }

  }
}
#endregion