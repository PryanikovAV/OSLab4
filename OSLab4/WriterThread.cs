using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OSLab4
{
    internal class WriterThread
    {
        private Thread writerThread;
        private bool isPaused;
        private bool isRunning;
        private volatile int speed;  // <-- динамически изменяемая скорость
        private readonly SharedBuffer buffer;

        public WriterThread(SharedBuffer buffer)
        {
            this.buffer = buffer;
            isPaused = false;
            isRunning = false;
            speed = 1000;
        }

        public void Start()
        {
            if (writerThread == null || !writerThread.IsAlive)
            {
                isRunning = true;
                writerThread = new Thread(Run);
                writerThread.IsBackground = true;
                writerThread.Start();
            }
        }

        public void Pause() => isPaused = true;
        public void Resume() => isPaused = false;
        public void SetSpeed(int speed) => this.speed = speed;
        
        public void Stop()
        {
            isRunning = false;
            writerThread?.Join();  // <-- ждём завершения потока
        }        
        
        private void Run()
        {
            while (isRunning)
            {
                if (!isPaused)
                {
                    string data = $"{DateTime.Now.Ticks}";  // <-- генератор уникальных данных
                    buffer.AddData(data);

                    Thread.Sleep(speed);
                }
            }
        }
    }
}
