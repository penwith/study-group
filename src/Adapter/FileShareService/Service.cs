namespace FileShareService
{
    public class Service
    {
        private IWeek _week = new NullWeek();

        public void SetWeek(int weekNumber)
        {
            if (weekNumber == 1) _week = new WeekOne();
            else if (weekNumber == 2) _week = new WeekTwo();
        }

        public void ListAllFiles()
        {
            if (_week is NullWeek)
            {
                Console.WriteLine("Unable to list files as week not specified");
                return;
            }

            Console.WriteLine($"Listing all files from {_week.Location}...");
        }

        public void GetFile(string file)
        {
            if (_week is NullWeek)
            {
                Console.WriteLine("Unable to get file as week not specified");
                return;
            }

            Console.WriteLine($"Retrieving copy of file {file} from {_week.Location}...");
        }
    }

    internal interface IWeek
    {
        string Location { get; }
    }

    internal class WeekOne : IWeek
    {
        public string Location => "Week One endpoint";
    }

    internal class WeekTwo : IWeek
    {
        public string Location => "Week Two endpoint";
    }

    internal class NullWeek : IWeek
    {
        public string Location => string.Empty;
    }
}