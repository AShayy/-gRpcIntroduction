主要是为了熟悉gRpc并且知道如何使用它

项目步骤:
1：新建一个名叫gRpcLibraries的类库
2：新建一个名叫gRpcService的控制台程序和一个名叫gRpcClient的控制台程序
3：在gRpcLibraries类库中新建一个HelloWord.proto
4：为三个项目添加NuGet引用 Grpc,Google.Protobuf,单独为gRpcLibraries项目添加Grpc.Tools引用
5：cmd进入该项目文件夹目录，目录为packages 的上层目录
6：输入下面这段命令行，但是要注意一点 
   1：输入命令行之前请先查看项目本身的Grpc.Tools版本号
   2：gRPCDemo替换成类库名称，比如当前项目就是gRpcLibraries
   3：替换掉proto文件名称 比如下面这段命令行的helloworld.proto
   packages\Grpc.Tools.1.14.0\tools\windows_x86\protoc.exe -IgRpcLibraries --csharp_out gRpcLibraries  gRpcLibraries\helloworld.proto --grpc_out gRpcLibraries --plugin=protoc-gen-grpc=packages\Grpc.Tools.1.14.0\tools\windows_x86\grpc_csharp_plugin.exe
7：将生成出来的两个类文件添加到类库项目当中，两个控制台项目将类库项目添加到引用
8：编写服务端代码，直接在program.cs文件中编写
9：编写客户端代码，直接在program.cs文件中编写
10：将项目生成下，打开客户端，服务端bin文件下以exe结尾的文件，即可
