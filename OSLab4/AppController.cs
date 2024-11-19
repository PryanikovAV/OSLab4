using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLab4
{
    public class AppController
    {
        private readonly Buffer buffer;
        private readonly Writer writer;
        private readonly Reader reader;

        public AppController(DataGridView bufferGridView)
        {
            buffer = new Buffer(10, bufferGridView);
            writer = new Writer(buffer);
            reader = new Reader(buffer);
        }

        public void StartWriter() => writer.Start();
        public void PauseWriter() => writer.Pause();
        public void ResumeWriter() => writer.Resume();
        public void StopWriter() => writer.Stop();
        public void SetWriterSpeed(int speed) => writer.SetSpeed(speed);

        public void StartReader() => reader.Start();
        public void PauseReader() => reader.Pause();
        public void ResumeReader() => reader.Resume();
        public void StopReader() => reader.Stop();
        public void SetReaderSpeed(int speed) => reader.SetSpeed(speed);
    }
}
