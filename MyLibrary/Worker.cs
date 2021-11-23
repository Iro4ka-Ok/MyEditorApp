
namespace MyEditorLibrary
{
    internal class Worker
    {
        private readonly int _speed;
        public int sumPhoto { get; private set; }
        public Worker(int speed)
        {
            _speed = speed;
        }
        public void PrintProcessOfPhoto(int minute)
        {
            if (minute % _speed == 0)
            {
                sumPhoto++;
            }
        }
    }
}
