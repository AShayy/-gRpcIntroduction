using Grpc.Core;
using GRpclibraries;
using System;
using System.Threading.Tasks;

namespace gRpcService
{
    class GRpcImpl : gRPC.gRPCBase
    {
        // 实现SayHello方法
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply { Message = "Hello " + request.Name });
        }
    }
    class Program
    {
        const int Port = 7911;
        static void Main(string[] args)
        {
            Server server = new Server
            {
                Services = { gRPC.BindService(new GRpcImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("gRPC server listening on port " + Port);
            Console.WriteLine("任意键退出...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
