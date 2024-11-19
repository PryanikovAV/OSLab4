using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLab4
{
    internal class Reader
    {
        private Thread readerThread;
        private bool isPaused;
        private bool isRunning;
        private volatile int speed;  // <-- динамически изменяемая скорость
        private readonly Buffer buffer;

        public Reader(Buffer buffer)
        {
            this.buffer = buffer;
            isPaused = false;
            isRunning = false;
            speed = 1000;
        }

        public void Start()
        {
            if (readerThread == null || !readerThread.IsAlive)
            {
                isRunning = true;
                readerThread = new Thread(Run);
                readerThread.IsBackground = true;
                readerThread.Start();
            }
        }

        public void Pause() => isPaused = true;
        public void Resume() => isPaused = false;
        public void SetSpeed(int speed) => this.speed = speed;
        
        public void Stop()
        {
            isRunning = false;
            readerThread?.Join();  // <-- ждём завершения потока
        }
        
        private void Run()
        {
            while (isRunning)
            {
                if (!isPaused)
                {
                    string data = buffer.RemoveData();
                    Thread.Sleep(speed);
                }
            }
        }
    }
}
