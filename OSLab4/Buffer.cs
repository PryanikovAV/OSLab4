using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSLab4
{
    internal class Buffer
    {
        private List<string> bufferData;
        private readonly int bufferSize = 10;
        private readonly object lockObject = new object(); // <-- объект для блокировки

        public Buffer()
        {
            bufferData = new List<string>(bufferSize);
        }


        public bool AddData(string data)
        {
            lock (lockObject)
            {
                if (bufferData.Count < bufferSize)
                {
                    bufferData.Add(data);
                    return true;
                }
                return false;  // <-- если буфер заполнен
            } 
        }

        public string ReadData()
        {
            lock (lockObject)
            {
                if (bufferData.Count > 0)
                {
                    string data = bufferData[0];
                    bufferData.RemoveAt(0);  // <-- удалить прочитанный элемент
                    return data;
                }
                return null;  // <-- если буфер пуст
            }
        }

        public int GetBufferCount()
        {
            lock (lockObject)
            {
                return bufferData.Count;
            }
        }

        public bool IsFull()
        {
            lock (lockObject)
            {
                return bufferData.Count >= bufferSize;
            }
        }

        public bool IsEmpty()
        {
            lock (lockObject)
            {
                return bufferData.Count == 0;
            }
        }
    }
}
