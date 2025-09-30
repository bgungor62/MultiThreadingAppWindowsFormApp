namespace MultiThreadingApp
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            btnListMailTask = new Button();
            dataGridView1 = new DataGridView();
            mailTaskBindingSource = new BindingSource(components);
            TaskId = new DataGridViewTextBoxColumn();
            ısRunningDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ısStartedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            secondDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nextRunningDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 400);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(941, 199);
            listBox1.TabIndex = 0;
            // 
            // btnListMailTask
            // 
            btnListMailTask.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListMailTask.Location = new Point(0, 1);
            btnListMailTask.Name = "btnListMailTask";
            btnListMailTask.Size = new Size(941, 48);
            btnListMailTask.TabIndex = 1;
            btnListMailTask.Text = "List Mail Task";
            btnListMailTask.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TaskId, ısRunningDataGridViewCheckBoxColumn, ısStartedDataGridViewCheckBoxColumn, secondDataGridViewTextBoxColumn, nextRunningDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mailTaskBindingSource;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(941, 150);
            dataGridView1.TabIndex = 2;
            // 
            // mailTaskBindingSource
            // 
            mailTaskBindingSource.DataSource = typeof(MailTask);
            // 
            // TaskId
            // 
            TaskId.DataPropertyName = "TaskId";
            TaskId.HeaderText = "TaskId";
            TaskId.Name = "TaskId";
            // 
            // ısRunningDataGridViewCheckBoxColumn
            // 
            ısRunningDataGridViewCheckBoxColumn.DataPropertyName = "IsRunning";
            ısRunningDataGridViewCheckBoxColumn.HeaderText = "IsRunning";
            ısRunningDataGridViewCheckBoxColumn.Name = "ısRunningDataGridViewCheckBoxColumn";
            // 
            // ısStartedDataGridViewCheckBoxColumn
            // 
            ısStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            ısStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            ısStartedDataGridViewCheckBoxColumn.Name = "ısStartedDataGridViewCheckBoxColumn";
            // 
            // secondDataGridViewTextBoxColumn
            // 
            secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            secondDataGridViewTextBoxColumn.HeaderText = "Second";
            secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            // 
            // nextRunningDataGridViewTextBoxColumn
            // 
            nextRunningDataGridViewTextBoxColumn.DataPropertyName = "NextRunning";
            nextRunningDataGridViewTextBoxColumn.HeaderText = "NextRunning";
            nextRunningDataGridViewTextBoxColumn.Name = "nextRunningDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 599);
            Controls.Add(dataGridView1);
            Controls.Add(btnListMailTask);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mailTaskBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btnListMailTask;
        private DataGridView dataGridView1;
        private BindingSource mailTaskBindingSource;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewCheckBoxColumn ısRunningDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn ısStartedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nextRunningDataGridViewTextBoxColumn;
    }
}
