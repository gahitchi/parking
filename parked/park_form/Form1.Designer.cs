namespace park_form
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            awaitingList = new ListBox();
            slots = new ListBox();
            btnStart = new Button();
            exited = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // awaitingList
            // 
            awaitingList.FormattingEnabled = true;
            awaitingList.ItemHeight = 15;
            awaitingList.Location = new Point(188, 216);
            awaitingList.Name = "awaitingList";
            awaitingList.Size = new Size(160, 139);
            awaitingList.TabIndex = 0;
            // 
            // slots
            // 
            slots.FormattingEnabled = true;
            slots.ItemHeight = 15;
            slots.Location = new Point(354, 216);
            slots.Name = "slots";
            slots.Size = new Size(160, 139);
            slots.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(393, 104);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(120, 23);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // exited
            // 
            exited.FormattingEnabled = true;
            exited.ItemHeight = 15;
            exited.Location = new Point(526, 216);
            exited.Name = "exited";
            exited.Size = new Size(160, 139);
            exited.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 198);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 8;
            label1.Text = "awaiting entrance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 198);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 9;
            label2.Text = "slots occupied";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(590, 198);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "exited";
            // 
            // Form1
            // 
            ClientSize = new Size(948, 617);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exited);
            Controls.Add(btnStart);
            Controls.Add(slots);
            Controls.Add(awaitingList);
            Name = "Form1";
            Text = "Simulazione Parcheggio";
            //FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox awaitingList;
        private System.Windows.Forms.ListBox slots;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox exited;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}