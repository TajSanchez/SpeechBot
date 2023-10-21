namespace SpeechBotDesktop
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
            this.Speak = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Speak
            // 
            this.Speak.Location = new System.Drawing.Point(116, 31);
            this.Speak.Name = "Speak";
            this.Speak.Size = new System.Drawing.Size(109, 50);
            this.Speak.TabIndex = 0;
            this.Speak.Text = "Speak";
            this.Speak.UseVisualStyleBackColor = true;
            this.Speak.Click += new System.EventHandler(this.Speak_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(574, 31);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(103, 50);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(33, 111);
            this.Textbox.Multiline = true;
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(738, 308);
            this.Textbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Speak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Speak;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox Textbox;
    }
}

