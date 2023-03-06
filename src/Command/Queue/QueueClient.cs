using Queue.Commands;
using System.Collections.Concurrent;

namespace Queue
{
    public class QueueClient
    {
        private PeriodicTimer _timer = new(TimeSpan.FromSeconds(2));

        private readonly ConcurrentQueue<ICommand> _queue;
        private readonly string _identifier;

        public QueueClient(ConcurrentQueue<ICommand> queue, string identifier)
        {
            _queue = queue;
            _identifier = identifier;
        }

        public async Task Run()
        {
            while (await _timer.WaitForNextTickAsync())
            {
                _queue.TryDequeue(out var command);

                command?.Execute(_identifier);
            }
        }
    }
}
