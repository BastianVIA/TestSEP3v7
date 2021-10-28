using AppServer.Networking;

namespace AppServer
{
    public class StartServer
    {
        static void Main(string[] args)
        {
            IServer server = new Server();
            server.startServer();
        }
    }
}