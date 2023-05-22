using Contracts;

namespace FtpServer
{
    public class Server : IFtpServer
    {
        private string _workingDirecdtory;

        public void CWD(string workingDirectory)
        {
            _workingDirecdtory = workingDirectory;
            Console.WriteLine($"Working directory changed to {_workingDirecdtory}");
        }

        public void LIST()
        {
            Console.WriteLine($"Listing information for the current working directory - {_workingDirecdtory}...");
        }

        public void RETR(string file)
        {
            Console.WriteLine($"Retrieving copy of file {file} from current working directory {_workingDirecdtory}...");
        }
    }
}