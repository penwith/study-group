using Contracts;

namespace Client
{
    public class System
    {
        private readonly IFtpServer _ftpServer;

        public System(IFtpServer ftpServer)
        {
            _ftpServer = ftpServer;
        }

        public void Run(string directory, string file)
        {
            _ftpServer.CWD(directory);
            _ftpServer.LIST();
            _ftpServer.RETR(file);
        }
    }
}