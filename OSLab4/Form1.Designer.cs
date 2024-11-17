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
            continueReaderButton = new Button();
            stopReaderButton = new Button();
            ReaderLabel = new Label();
            startReaderButton = new Button();
            readerSpeedControl = new TrackBar();
            pauseReaderButton = new Button();
            WriterGroupBox = new GroupBox();
            continueWriterButton = new Button();
            WriterLabel = new Label();
            stopWriterButton = new Button();
            startWriterButton = new Button();
            writerSpeedControl = new TrackBar();
            pauseWriterButton = new Button();
            startSimulationButton = new Button();
            stopSimulationButton = new Button();
            resetButton = new Button();
            systemTimeLabel = new Label();
            groupBox1 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)bufferGridView).BeginInit();
            ReaderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readerSpeedControl).BeginInit();
            WriterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)writerSpeedControl).BeginInit();
            groupBox1.SuspendLayout();
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
            bufferGridView.Size = new Size(251, 595);
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
            ReaderGroupBox.Controls.Add(continueReaderButton);
            ReaderGroupBox.Controls.Add(stopReaderButton);
            ReaderGroupBox.Controls.Add(ReaderLabel);
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
            // ReaderLabel
            // 
            ReaderLabel.AutoSize = true;
            ReaderLabel.Location = new Point(6, 19);
            ReaderLabel.Name = "ReaderLabel";
            ReaderLabel.Size = new Size(96, 15);
            ReaderLabel.TabIndex = 10;
            ReaderLabel.Text = "Статус Читателя";
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
            readerSpeedControl.Maximum = 5;
            readerSpeedControl.Minimum = 1;
            readerSpeedControl.Name = "readerSpeedControl";
            readerSpeedControl.Size = new Size(188, 45);
            readerSpeedControl.TabIndex = 4;
            readerSpeedControl.Value = 1;
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
            WriterGroupBox.Controls.Add(continueWriterButton);
            WriterGroupBox.Controls.Add(WriterLabel);
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
            // WriterLabel
            // 
            WriterLabel.AutoSize = true;
            WriterLabel.Location = new Point(6, 19);
            WriterLabel.Name = "WriterLabel";
            WriterLabel.Size = new Size(98, 15);
            WriterLabel.TabIndex = 11;
            WriterLabel.Text = "Статус Писателя";
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
            writerSpeedControl.Location = new Point(6, 109);
            writerSpeedControl.Maximum = 5;
            writerSpeedControl.Minimum = 1;
            writerSpeedControl.Name = "writerSpeedControl";
            writerSpeedControl.Size = new Size(188, 45);
            writerSpeedControl.TabIndex = 5;
            writerSpeedControl.Value = 1;
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
            // startSimulationButton
            // 
            startSimulationButton.Location = new Point(6, 51);
            startSimulationButton.Name = "startSimulationButton";
            startSimulationButton.Size = new Size(75, 23);
            startSimulationButton.TabIndex = 6;
            startSimulationButton.Text = "Старт";
            startSimulationButton.UseVisualStyleBackColor = true;
            startSimulationButton.Click += startSimulationButton_Click;
            // 
            // stopSimulationButton
            // 
            stopSimulationButton.Location = new Point(87, 51);
            stopSimulationButton.Name = "stopSimulationButton";
            stopSimulationButton.Size = new Size(75, 23);
            stopSimulationButton.TabIndex = 7;
            stopSimulationButton.Text = "Стоп";
            stopSimulationButton.UseVisualStyleBackColor = true;
            stopSimulationButton.Click += stopSimulationButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(168, 51);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 8;
            resetButton.Text = "Сброс";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // systemTimeLabel
            // 
            systemTimeLabel.AutoSize = true;
            systemTimeLabel.Location = new Point(6, 19);
            systemTimeLabel.Name = "systemTimeLabel";
            systemTimeLabel.Size = new Size(117, 15);
            systemTimeLabel.TabIndex = 9;
            systemTimeLabel.Text = "Системное время: 0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(startSimulationButton);
            groupBox1.Controls.Add(systemTimeLabel);
            groupBox1.Controls.Add(stopSimulationButton);
            groupBox1.Controls.Add(resetButton);
            groupBox1.Location = new Point(12, 613);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 87);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Общие элементы управления";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 717);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button startSimulationButton;
        private Button stopSimulationButton;
        private Button resetButton;
        private Label systemTimeLabel;
        private Label ReaderLabel;
        private Label WriterLabel;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Status;
        private Button continueReaderButton;
        private Button continueWriterButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
