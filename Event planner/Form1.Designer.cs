namespace Event_planner
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
            listBoxEvent = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxEventName = new TextBox();
            AddEvent = new Button();
            progressBar1 = new ProgressBar();
            DeleteEvent = new Button();
            labelEnterName = new Label();
            labelEnterDate = new Label();
            label1 = new Label();
            ButtonEventFinish = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBoxEvent
            // 
            listBoxEvent.FormattingEnabled = true;
            listBoxEvent.Location = new Point(382, 51);
            listBoxEvent.Name = "listBoxEvent";
            listBoxEvent.Size = new Size(257, 144);
            listBoxEvent.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(34, 134);
            dateTimePicker1.MinDate = new DateTime(2024, 12, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // textBoxEventName
            // 
            textBoxEventName.Location = new Point(34, 51);
            textBoxEventName.Name = "textBoxEventName";
            textBoxEventName.Size = new Size(263, 27);
            textBoxEventName.TabIndex = 2;
            // 
            // AddEvent
            // 
            AddEvent.Location = new Point(38, 183);
            AddEvent.Name = "AddEvent";
            AddEvent.Size = new Size(94, 29);
            AddEvent.TabIndex = 3;
            AddEvent.Text = "Add Event";
            AddEvent.UseVisualStyleBackColor = true;
            AddEvent.Click += AddEvent_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(382, 229);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(385, 29);
            progressBar1.TabIndex = 4;
            // 
            // DeleteEvent
            // 
            DeleteEvent.Location = new Point(190, 183);
            DeleteEvent.Name = "DeleteEvent";
            DeleteEvent.Size = new Size(94, 29);
            DeleteEvent.TabIndex = 6;
            DeleteEvent.Text = "Delete Event";
            DeleteEvent.UseVisualStyleBackColor = true;
            DeleteEvent.Click += DeleteEvent_Click_1;
            // 
            // labelEnterName
            // 
            labelEnterName.AutoSize = true;
            labelEnterName.Location = new Point(34, 28);
            labelEnterName.Name = "labelEnterName";
            labelEnterName.Size = new Size(124, 20);
            labelEnterName.TabIndex = 7;
            labelEnterName.Text = "Enter name event";
            // 
            // labelEnterDate
            // 
            labelEnterDate.AutoSize = true;
            labelEnterDate.Location = new Point(38, 98);
            labelEnterDate.Name = "labelEnterDate";
            labelEnterDate.Size = new Size(185, 20);
            labelEnterDate.TabIndex = 8;
            labelEnterDate.Text = "Enter the date of the event";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(382, 28);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 9;
            label1.Text = "Event list";
            // 
            // ButtonEventFinish
            // 
            ButtonEventFinish.Location = new Point(645, 110);
            ButtonEventFinish.Name = "ButtonEventFinish";
            ButtonEventFinish.Size = new Size(138, 27);
            ButtonEventFinish.TabIndex = 10;
            ButtonEventFinish.Text = "Mark as done";
            ButtonEventFinish.UseVisualStyleBackColor = true;
            ButtonEventFinish.Click += ButtonEventFinish_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(534, 206);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 11;
            label2.Text = "Progress";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 270);
            Controls.Add(label2);
            Controls.Add(ButtonEventFinish);
            Controls.Add(label1);
            Controls.Add(labelEnterDate);
            Controls.Add(labelEnterName);
            Controls.Add(DeleteEvent);
            Controls.Add(progressBar1);
            Controls.Add(AddEvent);
            Controls.Add(textBoxEventName);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBoxEvent);
            Name = "Form1";
            Text = "Event planer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEvent;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxEventName;
        private Button AddEvent;
        private ProgressBar progressBar1;
        private Button DeleteEvent;
        private Label labelEnterName;
        private Label labelEnterDate;
        private Label label1;
        private Button ButtonEventFinish;
        private Label label2;
    }
}
