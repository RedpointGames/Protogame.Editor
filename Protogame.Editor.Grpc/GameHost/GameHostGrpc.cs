// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GameHost.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Protogame.Editor.Grpc.GameHost {
  public static partial class GameHostServer
  {
    static readonly string __ServiceName = "GameHostServer";

    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.StartRequest> __Marshaller_StartRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.StartRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Protogame.Editor.Grpc.GameHost.StartResponse> __Marshaller_StartResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Protogame.Editor.Grpc.GameHost.StartResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Protogame.Editor.Grpc.GameHost.StartRequest, global::Protogame.Editor.Grpc.GameHost.StartResponse> __Method_Start = new grpc::Method<global::Protogame.Editor.Grpc.GameHost.StartRequest, global::Protogame.Editor.Grpc.GameHost.StartResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Start",
        __Marshaller_StartRequest,
        __Marshaller_StartResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Protogame.Editor.Grpc.GameHost.GameHostReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GameHostServer</summary>
    public abstract partial class GameHostServerBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Protogame.Editor.Grpc.GameHost.StartResponse> Start(global::Protogame.Editor.Grpc.GameHost.StartRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GameHostServer</summary>
    public partial class GameHostServerClient : grpc::ClientBase<GameHostServerClient>
    {
      /// <summary>Creates a new client for GameHostServer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GameHostServerClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GameHostServer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GameHostServerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GameHostServerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GameHostServerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Protogame.Editor.Grpc.GameHost.StartResponse Start(global::Protogame.Editor.Grpc.GameHost.StartRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Start(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Protogame.Editor.Grpc.GameHost.StartResponse Start(global::Protogame.Editor.Grpc.GameHost.StartRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Start, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.StartResponse> StartAsync(global::Protogame.Editor.Grpc.GameHost.StartRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return StartAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Protogame.Editor.Grpc.GameHost.StartResponse> StartAsync(global::Protogame.Editor.Grpc.GameHost.StartRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Start, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GameHostServerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GameHostServerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GameHostServerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Start, serviceImpl.Start).Build();
    }

  }
}
#endregion