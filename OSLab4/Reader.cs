using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLab4
{
    internal class Reader
    {
        private readonly Buffer buffer;
        private readonly Action<string> updateReaderStatus;
        private readonly Action<string, string> updateBufferStatus;
        private Thread readerThread;
        private bool isPaused;
        private bool isRunning;
        private int speed;


        public Reader(Buffer buffer,
            Action<string> updateReaderStatus,
            Action<string, string> updateBufferStatus,
            int speed = 1000)
        {
            this.buffer = buffer;
            this.updateReaderStatus = updateReaderStatus;
            this.updateBufferStatus = updateBufferStatus;
            this.speed = speed;
        }

        public void Start()
        {
            isRunning = true;
            isPaused = false;
            readerThread = new Thread(ReaderData);
            readerThread.Start();
        }

        public void Pause()
        {
            isPaused = true;
        }

        public void Resume()
        {
            isPaused = false;
        }

        public void Stop()
        {
            isRunning = false;
            new Thread(() =>
            {
                readerThread?.Join(); // Ожидаем завершения потока
            }).Start();
        }

        public void SetSpeed(int newSpeed)
        {
            speed = newSpeed;
        }

        private void ReaderData()
        {
            while (isRunning)
            {
                if (!isPaused)
                {
                    var data = buffer.ReadData();
                    if (data != null)
                    {
                        updateReaderStatus($"Reader прочитал: {data}");
                        updateBufferStatus(data, "Прочитано");

                        Thread.Sleep(500);

                        updateBufferStatus(data, "Удалено");
                        Thread.Sleep(100);
                    }
                    else
                    {
                        updateReaderStatus("Буфер пуст, ожидание...");
                    }
                }
                Thread.Sleep(speed);
            }
        }
    }
}
