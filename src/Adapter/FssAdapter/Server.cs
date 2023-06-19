using Contracts;
using FileShareService;

namespace FssAdapter
{
    public class Server : IFtpServer
    {
        private readonly Service _fileShareService = new Service();

        public void CWD(string workingDirectory)
        {
            var pathElements = workingDirectory.Split(@"\");
            var week =int.Parse(pathElements[3]);
            _fileShareService.SetWeek(week);
        }

        public void LIST()
        {
            _fileShareService.ListAllFiles();
        }

        public void RETR(string file)
        {
            _fileShareService.GetFile(file);
        }
    }
}