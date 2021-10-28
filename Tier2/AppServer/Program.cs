using AppServer.Networking;

namespace AppServer
{
    public class Program
    {
        static void Main(string[] args)
            {
                IServer server = new Server();
                server.startServer();
            }
    }
}