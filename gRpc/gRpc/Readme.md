��Ҫ��Ϊ����ϤgRpc����֪�����ʹ����

��Ŀ����:
1���½�һ������gRpcLibraries�����
2���½�һ������gRpcService�Ŀ���̨�����һ������gRpcClient�Ŀ���̨����
3����gRpcLibraries������½�һ��HelloWord.proto
4��Ϊ������Ŀ���NuGet���� Grpc,Google.Protobuf,����ΪgRpcLibraries��Ŀ���Grpc.Tools����
5��cmd�������Ŀ�ļ���Ŀ¼��Ŀ¼Ϊpackages ���ϲ�Ŀ¼
6������������������У�����Ҫע��һ�� 
   1������������֮ǰ���Ȳ鿴��Ŀ�����Grpc.Tools�汾��
   2��gRPCDemo�滻��������ƣ����統ǰ��Ŀ����gRpcLibraries
   3���滻��proto�ļ����� ����������������е�helloworld.proto
   packages\Grpc.Tools.1.14.0\tools\windows_x86\protoc.exe -IgRpcLibraries --csharp_out gRpcLibraries  gRpcLibraries\helloworld.proto --grpc_out gRpcLibraries --plugin=protoc-gen-grpc=packages\Grpc.Tools.1.14.0\tools\windows_x86\grpc_csharp_plugin.exe
7�������ɳ������������ļ���ӵ������Ŀ���У���������̨��Ŀ�������Ŀ��ӵ�����
8����д����˴��룬ֱ����program.cs�ļ��б�д
9����д�ͻ��˴��룬ֱ����program.cs�ļ��б�д
10������Ŀ�����£��򿪿ͻ��ˣ������bin�ļ�����exe��β���ļ�������
