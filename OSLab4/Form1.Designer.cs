namespace OSLab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bufferGridView = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ReaderGroupBox = new GroupBox();
            readerSpeedLabel = new Label();
            continueReaderButton = new Button();
            stopReaderButton = new Button();
            startReaderButton = new Button();
            readerSpeedControl = new TrackBar();
            pauseReaderButton = new Button();
            WriterGroupBox = new GroupBox();
            writerSpeedLabel = new Label();
            continueWriterButton = new Button();
            stopWriterButton = new Button();
            startWriterButton = new Button();
            writerSpeedControl = new TrackBar();
            pauseWriterButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            resetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bufferGridView).BeginInit();
            ReaderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readerSpeedControl).BeginInit();
            WriterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)writerSpeedControl).BeginInit();
            SuspendLayout();
            // 
            // bufferGridView
            // 
            bufferGridView.AllowUserToAddRows = false;
            bufferGridView.AllowUserToDeleteRows = false;
            bufferGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bufferGridView.Columns.AddRange(new DataGridViewColumn[] { Data, Status });
            bufferGridView.Location = new Point(12, 12);
            bufferGridView.Name = "bufferGridView";
            bufferGridView.ReadOnly = true;
            bufferGridView.Size = new Size(251, 365);
            bufferGridView.TabIndex = 0;
            // 
            // Data
            // 
            Data.HeaderText = "Данные";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // ReaderGroupBox
            // 
            ReaderGroupBox.Controls.Add(readerSpeedLabel);
            ReaderGroupBox.Controls.Add(continueReaderButton);
            ReaderGroupBox.Controls.Add(stopReaderButton);
            ReaderGroupBox.Controls.Add(startReaderButton);
            ReaderGroupBox.Controls.Add(readerSpeedControl);
            ReaderGroupBox.Controls.Add(pauseReaderButton);
            ReaderGroupBox.Location = new Point(289, 178);
            ReaderGroupBox.Name = "ReaderGroupBox";
            ReaderGroupBox.Size = new Size(200, 160);
            ReaderGroupBox.TabIndex = 1;
            ReaderGroupBox.TabStop = false;
            ReaderGroupBox.Text = "Читатель";
            // 
            // readerSpeedLabel
            // 
            readerSpeedLabel.AutoSize = true;
            readerSpeedLabel.Location = new Point(6, 19);
            readerSpeedLabel.Name = "readerSpeedLabel";
            readerSpeedLabel.Size = new Size(153, 15);
            readerSpeedLabel.TabIndex = 12;
            readerSpeedLabel.Text = "Скорость читателя: 500 мс";
            // 
            // continueReaderButton
            // 
            continueReaderButton.Location = new Point(102, 80);
            continueReaderButton.Name = "continueReaderButton";
            continueReaderButton.Size = new Size(90, 23);
            continueReaderButton.TabIndex = 11;
            continueReaderButton.Text = "Продолжить";
            continueReaderButton.UseVisualStyleBackColor = true;
            continueReaderButton.Click += continueReaderButton_Click;
            // 
            // stopReaderButton
            // 
            stopReaderButton.Location = new Point(102, 53);
            stopReaderButton.Name = "stopReaderButton";
            stopReaderButton.Size = new Size(90, 23);
            stopReaderButton.TabIndex = 2;
            stopReaderButton.Text = "Стоп";
            stopReaderButton.UseVisualStyleBackColor = true;
            stopReaderButton.Click += stopReaderButton_Click;
            // 
            // startReaderButton
            // 
            startReaderButton.Location = new Point(6, 53);
            startReaderButton.Name = "startReaderButton";
            startReaderButton.Size = new Size(90, 23);
            startReaderButton.TabIndex = 0;
            startReaderButton.Text = "Старт";
            startReaderButton.UseVisualStyleBackColor = true;
            startReaderButton.Click += startReaderButton_Click;
            // 
            // readerSpeedControl
            // 
            readerSpeedControl.Location = new Point(6, 109);
            readerSpeedControl.Name = "readerSpeedControl";
            readerSpeedControl.Size = new Size(188, 45);
            readerSpeedControl.TabIndex = 4;
            readerSpeedControl.Value = 5;
            readerSpeedControl.Scroll += readerSpeedControl_Scroll;
            // 
            // pauseReaderButton
            // 
            pauseReaderButton.Location = new Point(6, 80);
            pauseReaderButton.Name = "pauseReaderButton";
            pauseReaderButton.Size = new Size(90, 23);
            pauseReaderButton.TabIndex = 1;
            pauseReaderButton.Text = "Пауза";
            pauseReaderButton.UseVisualStyleBackColor = true;
            pauseReaderButton.Click += pauseReaderButton_Click;
            // 
            // WriterGroupBox
            // 
            WriterGroupBox.Controls.Add(writerSpeedLabel);
            WriterGroupBox.Controls.Add(continueWriterButton);
            WriterGroupBox.Controls.Add(stopWriterButton);
            WriterGroupBox.Controls.Add(startWriterButton);
            WriterGroupBox.Controls.Add(writerSpeedControl);
            WriterGroupBox.Controls.Add(pauseWriterButton);
            WriterGroupBox.Location = new Point(289, 12);
            WriterGroupBox.Name = "WriterGroupBox";
            WriterGroupBox.Size = new Size(200, 160);
            WriterGroupBox.TabIndex = 2;
            WriterGroupBox.TabStop = false;
            WriterGroupBox.Text = "Писатель";
            // 
            // writerSpeedLabel
            // 
            writerSpeedLabel.AutoSize = true;
            writerSpeedLabel.Location = new Point(6, 19);
            writerSpeedLabel.Name = "writerSpeedLabel";
            writerSpeedLabel.Size = new Size(154, 15);
            writerSpeedLabel.TabIndex = 13;
            writerSpeedLabel.Text = "Скорость писателя: 500 мс";
            // 
            // continueWriterButton
            // 
            continueWriterButton.Location = new Point(102, 80);
            continueWriterButton.Name = "continueWriterButton";
            continueWriterButton.Size = new Size(90, 23);
            continueWriterButton.TabIndex = 12;
            continueWriterButton.Text = "Продолжить";
            continueWriterButton.UseVisualStyleBackColor = true;
            continueWriterButton.Click += continueWriterButton_Click;
            // 
            // stopWriterButton
            // 
            stopWriterButton.Location = new Point(102, 51);
            stopWriterButton.Name = "stopWriterButton";
            stopWriterButton.Size = new Size(90, 23);
            stopWriterButton.TabIndex = 2;
            stopWriterButton.Text = "Стоп";
            stopWriterButton.UseVisualStyleBackColor = true;
            stopWriterButton.Click += stopWriterButton_Click;
            // 
            // startWriterButton
            // 
            startWriterButton.Location = new Point(6, 51);
            startWriterButton.Name = "startWriterButton";
            startWriterButton.Size = new Size(90, 23);
            startWriterButton.TabIndex = 0;
            startWriterButton.Text = "Старт";
            startWriterButton.UseVisualStyleBackColor = true;
            startWriterButton.Click += startWriterButton_Click;
            // 
            // writerSpeedControl
            // 
            writerSpeedControl.LargeChange = 2;
            writerSpeedControl.Location = new Point(6, 109);
            writerSpeedControl.Minimum = 1;
            writerSpeedControl.Name = "writerSpeedControl";
            writerSpeedControl.Size = new Size(188, 45);
            writerSpeedControl.TabIndex = 5;
            writerSpeedControl.Value = 5;
            writerSpeedControl.Scroll += writerSpeedControl_Scroll;
            // 
            // pauseWriterButton
            // 
            pauseWriterButton.Location = new Point(6, 80);
            pauseWriterButton.Name = "pauseWriterButton";
            pauseWriterButton.Size = new Size(90, 23);
            pauseWriterButton.TabIndex = 1;
            pauseWriterButton.Text = "Пауза";
            pauseWriterButton.UseVisualStyleBackColor = true;
            pauseWriterButton.Click += pauseWriterButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(289, 354);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 8;
            resetButton.Text = "Сброс";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 388);
            Controls.Add(resetButton);
            Controls.Add(WriterGroupBox);
            Controls.Add(ReaderGroupBox);
            Controls.Add(bufferGridView);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)bufferGridView).EndInit();
            ReaderGroupBox.ResumeLayout(false);
            ReaderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)readerSpeedControl).EndInit();
            WriterGroupBox.ResumeLayout(false);
            WriterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)writerSpeedControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView bufferGridView;
        private GroupBox ReaderGroupBox;
        private Button stopReaderButton;
        private Button pauseReaderButton;
        private Button startReaderButton;
        private GroupBox WriterGroupBox;
        private Button stopWriterButton;
        private Button pauseWriterButton;
        private Button startWriterButton;
        private TrackBar readerSpeedControl;
        private TrackBar writerSpeedControl;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Status;
        private Button continueReaderButton;
        private Button continueWriterButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button resetButton;
        private Label readerSpeedLabel;
        private Label writerSpeedLabel;
    }
}
