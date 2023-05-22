namespace Contracts
{
    public interface IFtpServer
    {
        void CWD(string workingDirectory);
        void LIST();
        void RETR(string file);
    }
}