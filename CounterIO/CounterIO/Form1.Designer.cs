namespace CounterIO
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
            this.lblCounter1 = new System.Windows.Forms.Label();
            this.txtCounter1 = new System.Windows.Forms.TextBox();
            this.txtCounter2 = new System.Windows.Forms.TextBox();
            this.lblCounter2 = new System.Windows.Forms.Label();
            this.txtCounter3 = new System.Windows.Forms.TextBox();
            this.lblCounter3 = new System.Windows.Forms.Label();
            this.btnCounter1 = new System.Windows.Forms.Button();
            this.btnCounter2 = new System.Windows.Forms.Button();
            this.btnCounter3 = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lstQueue = new System.Windows.Forms.ListBox();
            this.btnPrintToken = new System.Windows.Forms.Button();
            this.txtAvailableTokens = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCounter1
            // 
            this.lblCounter1.AutoSize = true;
            this.lblCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter1.Location = new System.Drawing.Point(12, 9);
            this.lblCounter1.Name = "lblCounter1";
            this.lblCounter1.Size = new System.Drawing.Size(102, 24);
            this.lblCounter1.TabIndex = 0;
            this.lblCounter1.Text = "Counter #1";
            // 
            // txtCounter1
            // 
            this.txtCounter1.BackColor = System.Drawing.Color.Blue;
            this.txtCounter1.Enabled = false;
            this.txtCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounter1.ForeColor = System.Drawing.Color.White;
            this.txtCounter1.Location = new System.Drawing.Point(12, 36);
            this.txtCounter1.Name = "txtCounter1";
            this.txtCounter1.Size = new System.Drawing.Size(102, 29);
            this.txtCounter1.TabIndex = 1;
            // 
            // txtCounter2
            // 
            this.txtCounter2.BackColor = System.Drawing.Color.Blue;
            this.txtCounter2.Enabled = false;
            this.txtCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounter2.ForeColor = System.Drawing.Color.White;
            this.txtCounter2.Location = new System.Drawing.Point(120, 36);
            this.txtCounter2.Name = "txtCounter2";
            this.txtCounter2.Size = new System.Drawing.Size(102, 29);
            this.txtCounter2.TabIndex = 3;
            // 
            // lblCounter2
            // 
            this.lblCounter2.AutoSize = true;
            this.lblCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter2.Location = new System.Drawing.Point(120, 9);
            this.lblCounter2.Name = "lblCounter2";
            this.lblCounter2.Size = new System.Drawing.Size(102, 24);
            this.lblCounter2.TabIndex = 2;
            this.lblCounter2.Text = "Counter #1";
            // 
            // txtCounter3
            // 
            this.txtCounter3.BackColor = System.Drawing.Color.Blue;
            this.txtCounter3.Enabled = false;
            this.txtCounter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCounter3.ForeColor = System.Drawing.Color.White;
            this.txtCounter3.Location = new System.Drawing.Point(228, 36);
            this.txtCounter3.Name = "txtCounter3";
            this.txtCounter3.Size = new System.Drawing.Size(102, 29);
            this.txtCounter3.TabIndex = 5;
            // 
            // lblCounter3
            // 
            this.lblCounter3.AutoSize = true;
            this.lblCounter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter3.Location = new System.Drawing.Point(228, 9);
            this.lblCounter3.Name = "lblCounter3";
            this.lblCounter3.Size = new System.Drawing.Size(102, 24);
            this.lblCounter3.TabIndex = 4;
            this.lblCounter3.Text = "Counter #1";
            // 
            // btnCounter1
            // 
            this.btnCounter1.Location = new System.Drawing.Point(12, 71);
            this.btnCounter1.Name = "btnCounter1";
            this.btnCounter1.Size = new System.Drawing.Size(102, 23);
            this.btnCounter1.TabIndex = 6;
            this.btnCounter1.Text = "Next";
            this.btnCounter1.UseVisualStyleBackColor = true;
            this.btnCounter1.Click += new System.EventHandler(this.btnCounter1_Click);
            // 
            // btnCounter2
            // 
            this.btnCounter2.Location = new System.Drawing.Point(120, 71);
            this.btnCounter2.Name = "btnCounter2";
            this.btnCounter2.Size = new System.Drawing.Size(102, 23);
            this.btnCounter2.TabIndex = 7;
            this.btnCounter2.Text = "Next";
            this.btnCounter2.UseVisualStyleBackColor = true;
            this.btnCounter2.Click += new System.EventHandler(this.btnCounter2_Click);
            // 
            // btnCounter3
            // 
            this.btnCounter3.Location = new System.Drawing.Point(228, 71);
            this.btnCounter3.Name = "btnCounter3";
            this.btnCounter3.Size = new System.Drawing.Size(102, 23);
            this.btnCounter3.TabIndex = 8;
            this.btnCounter3.Text = "Next";
            this.btnCounter3.UseVisualStyleBackColor = true;
            this.btnCounter3.Click += new System.EventHandler(this.btnCounter3_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtMessage.Enabled = false;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(12, 100);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(318, 29);
            this.txtMessage.TabIndex = 9;
            // 
            // lstQueue
            // 
            this.lstQueue.FormattingEnabled = true;
            this.lstQueue.Location = new System.Drawing.Point(12, 146);
            this.lstQueue.Name = "lstQueue";
            this.lstQueue.Size = new System.Drawing.Size(318, 95);
            this.lstQueue.TabIndex = 10;
            // 
            // btnPrintToken
            // 
            this.btnPrintToken.Location = new System.Drawing.Point(12, 247);
            this.btnPrintToken.Name = "btnPrintToken";
            this.btnPrintToken.Size = new System.Drawing.Size(319, 23);
            this.btnPrintToken.TabIndex = 11;
            this.btnPrintToken.Text = "Print Token";
            this.btnPrintToken.UseVisualStyleBackColor = true;
            this.btnPrintToken.Click += new System.EventHandler(this.btnPrintToken_Click);
            // 
            // txtAvailableTokens
            // 
            this.txtAvailableTokens.BackColor = System.Drawing.Color.White;
            this.txtAvailableTokens.Enabled = false;
            this.txtAvailableTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableTokens.ForeColor = System.Drawing.Color.White;
            this.txtAvailableTokens.Location = new System.Drawing.Point(12, 282);
            this.txtAvailableTokens.Name = "txtAvailableTokens";
            this.txtAvailableTokens.Size = new System.Drawing.Size(318, 29);
            this.txtAvailableTokens.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 323);
            this.Controls.Add(this.txtAvailableTokens);
            this.Controls.Add(this.btnPrintToken);
            this.Controls.Add(this.lstQueue);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnCounter3);
            this.Controls.Add(this.btnCounter2);
            this.Controls.Add(this.btnCounter1);
            this.Controls.Add(this.txtCounter3);
            this.Controls.Add(this.lblCounter3);
            this.Controls.Add(this.txtCounter2);
            this.Controls.Add(this.lblCounter2);
            this.Controls.Add(this.txtCounter1);
            this.Controls.Add(this.lblCounter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CounterIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCounter1;
        private System.Windows.Forms.TextBox txtCounter1;
        private System.Windows.Forms.TextBox txtCounter2;
        private System.Windows.Forms.Label lblCounter2;
        private System.Windows.Forms.TextBox txtCounter3;
        private System.Windows.Forms.Label lblCounter3;
        private System.Windows.Forms.Button btnCounter1;
        private System.Windows.Forms.Button btnCounter2;
        private System.Windows.Forms.Button btnCounter3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox lstQueue;
        private System.Windows.Forms.Button btnPrintToken;
        private System.Windows.Forms.TextBox txtAvailableTokens;
    }
}

