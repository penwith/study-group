//using FssAdapter;
using FtpServer;

new Client.System(new Server())
    .Run(@"\SomeEncFolder\Week\2", "super-important-file.enc");

Console.ReadKey();