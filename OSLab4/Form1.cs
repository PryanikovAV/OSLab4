namespace OSLab4
{
    public partial class Form1 : Form
    {
        private readonly Buffer buffer = new Buffer();
        private Reader reader;
        private Writer writer;

        public Form1()
        {
            InitializeComponent();

            writer = new Writer(buffer, UpdateWriterStatus, UpdateBufferStatus);
            reader = new Reader(buffer, UpdateReaderStatus, UpdateBufferStatus);

            writerSpeedControl.Scroll += (s, e) => writer.SetSpeed(writerSpeedControl.Value * 100);
            readerSpeedControl.Scroll += (s, e) => reader.SetSpeed(readerSpeedControl.Value * 100);
        }


        // WRITER
        private void startWriterButton_Click(object sender, EventArgs e)
        {
            writer.Start();
            startWriterButton.Enabled = false;
            pauseWriterButton.Enabled = true;
            stopWriterButton.Enabled = true;
        }

        private void pauseWriterButton_Click(object sender, EventArgs e)
        {
            writer.Pause();
        }

        private void continueWriterButton_Click(object sender, EventArgs e)
        {
            writer.Resume();
        }

        private void stopWriterButton_Click(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => stopWriterButton_Click(sender, e)));
                return;
            }

            writer.Stop();

            startWriterButton.Enabled = true;
            pauseWriterButton.Enabled = false;
            stopWriterButton.Enabled = false;
            continueWriterButton.Enabled = false;
        }

        // WRITER


        // READER
        private void startReaderButton_Click(object sender, EventArgs e)
        {
            reader.Start();
            startReaderButton.Enabled = false;
            pauseReaderButton.Enabled = true;
            stopReaderButton.Enabled = true;
        }

        private void pauseReaderButton_Click(object sender, EventArgs e)
        {
            reader.Pause();
        }

        private void continueReaderButton_Click(object sender, EventArgs e)
        {
            reader.Resume();
        }

        private void stopReaderButton_Click(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => stopReaderButton_Click(sender, e)));
                return;
            }

            reader.Stop();

            startReaderButton.Enabled = true;
            pauseReaderButton.Enabled = false;
            stopReaderButton.Enabled = false;
            continueReaderButton.Enabled = false;
        }

        // READER

        // UPDATE
        private void UpdateWriterStatus(string status)
        {
            Invoke(new Action(() => WriterLabel.Text = status));
        }

        private void UpdateReaderStatus(string status)
        {
            Invoke(new Action(() => ReaderLabel.Text = status));
        }

        private void UpdateBufferStatus(string data, string status)
        {
            Invoke(new Action(() =>
            {
                foreach (DataGridViewRow row in bufferGridView.Rows)
                {
                    if (row.Cells[0].Value?.ToString() == data)
                    {
                        row.Cells[1].Value = status;
                        row.DefaultCellStyle.BackColor = status == "Записано" ? System.Drawing.Color.LightGreen : System.Drawing.Color.LightGray;
                        return;
                    }
                }
                int newIndex = bufferGridView.Rows.Add();
                bufferGridView.Rows[newIndex].Cells[0].Value = data;
                bufferGridView.Rows[newIndex].Cells[1].Value = status;
                bufferGridView.Rows[newIndex].DefaultCellStyle.BackColor = status == "Записано" ? System.Drawing.Color.LightGreen : System.Drawing.Color.LightGray;
            }));
        }

        private void startSimulationButton_Click(object sender, EventArgs e)
        {
            startWriterButton_Click(sender, e);
            startReaderButton_Click(sender, e);
        }

        private void stopSimulationButton_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                stopWriterButton_Click(sender, e);
                stopReaderButton_Click(sender, e);
            });
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            stopSimulationButton_Click(sender, e);
            bufferGridView.Rows.Clear();
            WriterLabel.Text = "Writer: Idle";
            ReaderLabel.Text = "Reader: Idle";
        }
    }
}
