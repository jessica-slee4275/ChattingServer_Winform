namespace Chatting
{
    partial class Form1
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
            this.btnServer = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.lbChatHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(424, 12);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(75, 69);
            this.btnServer.TabIndex = 1;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(424, 254);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 69);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 254);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(406, 68);
            this.tbText.TabIndex = 3;
            // 
            // lbChatHistory
            // 
            this.lbChatHistory.FormattingEnabled = true;
            this.lbChatHistory.Location = new System.Drawing.Point(13, 12);
            this.lbChatHistory.Name = "lbChatHistory";
            this.lbChatHistory.Size = new System.Drawing.Size(405, 238);
            this.lbChatHistory.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 335);
            this.Controls.Add(this.lbChatHistory);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnServer);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ListBox lbChatHistory;
    }
}

