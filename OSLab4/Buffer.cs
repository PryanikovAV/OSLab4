using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLab4
{
    internal class Buffer
    {
        private readonly Queue<string> buffer;
        private readonly Semaphore empty;
        private readonly Semaphore full;
        private readonly Mutex bufferMutex;
        private readonly DataGridView bufferGridView;

        public Buffer(int bufferLength, DataGridView gridView)
        {
            buffer = new Queue<string>(bufferLength);
            empty = new Semaphore(bufferLength, bufferLength);
            full = new Semaphore(0, bufferLength);
            bufferMutex = new Mutex();
            bufferGridView = gridView;

            InitializeGridView(bufferLength);
        }

        private void InitializeGridView(int bufferLength)
        {
            bufferGridView.Rows.Clear();
            for (int i = 0; i < bufferLength; i++)
            {
                bufferGridView.Rows.Add("", "Пусто");
            }
        }

        public void AddData(string data)
        {
            empty.WaitOne();
            bufferMutex.WaitOne();

            buffer.Enqueue(data);
            UpdateGridView();

            bufferMutex.ReleaseMutex();
            full.Release();
        }

        public string RemoveData()
        {
            full.WaitOne();
            bufferMutex.WaitOne();

            string data = buffer.Dequeue();
            UpdateGridView();

            bufferMutex.ReleaseMutex();
            empty.Release();

            return data;
        }

        private void UpdateGridView()
        {
            bufferGridView.Invoke((MethodInvoker)delegate
            {
                int index = 0;
                foreach (DataGridViewRow row in bufferGridView.Rows)
                {
                    if (index < buffer.Count)
                    {
                        row.Cells[0].Value = buffer.ToArray()[index];
                        row.Cells[1].Value = "Занято";
                    }
                    else
                    {
                        row.Cells[0].Value = "";
                        row.Cells[1].Value = "Пусто";
                    }
                    index++;
                }
            });
        }
    }
}
