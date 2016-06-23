namespace InstantMessenger
{
    partial class TalkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.talkText = new System.Windows.Forms.RichTextBox();
            this.sendText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sendButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sendText);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 20);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.talkText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 288);
            this.panel2.TabIndex = 1;
            // 
            // talkText
            // 
            this.talkText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.talkText.Location = new System.Drawing.Point(0, 0);
            this.talkText.Name = "talkText";
            this.talkText.Size = new System.Drawing.Size(582, 288);
            this.talkText.TabIndex = 0;
            this.talkText.Text = "";
            // 
            // sendText
            // 
            this.sendText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sendText.Location = new System.Drawing.Point(0, 0);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(507, 20);
            this.sendText.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sendButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(507, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 20);
            this.panel3.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(0, -1);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 20);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // TalkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TalkForm";
            this.Text = "Talk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TalkForm_FormClosing);
            this.Load += new System.EventHandler(this.TalkForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox talkText;
    }
}