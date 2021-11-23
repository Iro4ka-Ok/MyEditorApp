using System.Collections.Generic;
using System.Linq;

namespace MyEditorLibrary
{
    public class EditorServices
    {
        private readonly int _countPhoto;
        private readonly List<int> _workerSpeeds;

        public EditorServices(int countPhoto, List<int> workerSpeeds)
        {
            _countPhoto = countPhoto;
            _workerSpeeds = workerSpeeds;
        }
        public EditorResult Process()
        {
            var workers = _workerSpeeds.Select(g => new Worker(g)).ToList();

            var minute = 0;
            do
            {
                minute++;
                foreach (var g in workers)
                {
                    g.PrintProcessOfPhoto(minute);
                }

            } while (workers.Sum(g => g.sumPhoto) < _countPhoto);

            return new EditorResult
            {
                TotalMinutes = minute,
                ProcessedImeges = workers.Select(g => g.sumPhoto).ToList()
            };
        }
    }
}
