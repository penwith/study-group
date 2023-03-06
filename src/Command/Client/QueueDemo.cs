using Queue;
using Queue.Commands;
using System.Collections.Concurrent;
using System.Timers;

namespace Client
{
    public class QueueDemo
    {
        private readonly ConcurrentQueue<ICommand> _queue = new();
        private readonly System.Timers.Timer _timer = new(10000);

        private Stack<string> _werds = new Stack<string>();

        public QueueDemo()
        {
            _timer.Elapsed += TimerOnElapsed;
            _timer.Start();

            StackTheWerds();
        }

        public async Task Run()
        {
            for (var i = 1; i <= 50; i++)
            {
                if (i % 5 == 0)
                {
                    if (_werds.TryPop(out var werd))
                    {
                        _queue.Enqueue(new StringCommand(werd));
                    }
                }
                else _queue.Enqueue(new NumberCommand(i));
            }

            var clients = new List<QueueClient>
            {
                new QueueClient(_queue, "AA"),
                new QueueClient(_queue, "BB"),
                new QueueClient(_queue, "CC"),
                new QueueClient(_queue, "DD"),
                new QueueClient(_queue, "EE")
            };

            ParallelOptions parallelOptions = new()
            {
                MaxDegreeOfParallelism = 5
            };

            await Parallel.ForEachAsync(
                clients,
                parallelOptions,
                async (client, token) =>
                {
                    await client.Run();
                });
        }

        private void TimerOnElapsed(object? sender, ElapsedEventArgs e)
        {
            _queue.Enqueue(new NumberCommand(101));
            _timer.Stop();
        }

        private void StackTheWerds()
        {
            _werds.Push("long");
            _werds.Push("so");
            _werds.Push("world");
            _werds.Push("cruel");
            _werds.Push("Goodbye");
        }
    }
}
