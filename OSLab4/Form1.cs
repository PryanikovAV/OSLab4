namespace OSLab4
{
    public partial class Form1 : Form
    {
        private AppController appController;

        public Form1()
        {
            InitializeComponent();
            appController = new AppController(bufferGridView);

            writerSpeedControl.Value = 5;
            readerSpeedControl.Value = 5;
        }

        private void startWriterButton_Click(object sender, EventArgs e) => appController.StartWriter();
        private void pauseWriterButton_Click(object sender, EventArgs e) => appController.PauseWriter();
        private void continueWriterButton_Click(object sender, EventArgs e) => appController.ResumeWriter();
        private void stopWriterButton_Click(object sender, EventArgs e) => appController.StopWriter();
        private void writerSpeedControl_Scroll(object sender, EventArgs e)
        {
            int speed = writerSpeedControl.Value * 100;
            appController.SetWriterSpeed(speed);
            writerSpeedLabel.Text = $"Скорость писателя: {speed} мс";
        }


        private void startReaderButton_Click(object sender, EventArgs e) => appController.StartReader();
        private void pauseReaderButton_Click(object sender, EventArgs e) => appController.PauseReader();
        private void continueReaderButton_Click(object sender, EventArgs e) => appController.ResumeReader();
        private void stopReaderButton_Click(object sender, EventArgs e) => appController.StopReader();
        private void readerSpeedControl_Scroll(object sender, EventArgs e)
        {
            int speed = readerSpeedControl.Value * 100;
            appController.SetReaderSpeed(speed);
            readerSpeedLabel.Text = $"Скорость читателя: {speed} мс";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            appController.StopWriter();
            appController.StopReader();
            
            appController = new AppController(bufferGridView);
            writerSpeedControl.Value = 5;
            readerSpeedControl.Value = 5;
            MessageBox.Show("Программа сброшена в исходное состояние.");
        }
    }
}
