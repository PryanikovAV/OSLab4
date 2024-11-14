using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLab4
{
    internal class Writer
    {
        private readonly Buffer buffer;
        private readonly Action<string> updateWriterStatus;
        private readonly Action<string, string> updateBufferStatus;
        private Thread writerThread;
        private bool isPaused;
        private bool isRunning;
        private int speed;
       

        public Writer(Buffer buffer, 
            Action<string> updateWriterStatus, 
            Action<string, string> updateBufferStatus, 
            int speed = 1000)
        {
            this.buffer = buffer;
            this.updateWriterStatus = updateWriterStatus;
            this.updateBufferStatus = updateBufferStatus;
            this.speed = speed;
        }

        public void Start()
        {
            isRunning = true;
            isPaused = false;
            writerThread = new Thread(WriterData);
            writerThread.Start();
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
                writerThread?.Join(); // Ожидаем завершения потока
            }).Start();
        }


        public void SetSpeed(int newSpeed)
        {
            speed = newSpeed;
        }

        private void WriterData()
        {
            int dataCount = 1;
            while (isRunning)
            {
                if (!isPaused)
                {
                    if (buffer.AddData($"Data {dataCount}"))
                    {
                        updateWriterStatus($"Writer записал: Data {dataCount}");
                        updateBufferStatus($"Data {dataCount}", "Записано");
                        dataCount++;
                    }
                    else
                    {
                        updateWriterStatus("Буфер полон, ожидание...");
                    }
                }
                Thread.Sleep(speed);
            }
        }
    }
}
