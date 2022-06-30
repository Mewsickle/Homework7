namespace Homework7
{
    partial class УгадайЧисло
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.lblUserCount = new System.Windows.Forms.Label();
            this.lblComputerNumber = new System.Windows.Forms.Label();
            this.lblUserNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(299, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(178, 86);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Начать игру";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(299, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 80);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // txtBox1
            // 
            this.txtBox1.AcceptsReturn = true;
            this.txtBox1.AcceptsTab = true;
            this.txtBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtBox1.Location = new System.Drawing.Point(299, 201);
            this.txtBox1.MaxLength = 3;
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(178, 20);
            this.txtBox1.TabIndex = 2;
            this.txtBox1.Text = "Введите число (1-100)";
            this.txtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox1.Visible = false;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // lblUserCount
            // 
            this.lblUserCount.AutoSize = true;
            this.lblUserCount.Location = new System.Drawing.Point(60, 85);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(13, 13);
            this.lblUserCount.TabIndex = 3;
            this.lblUserCount.Text = "0";
            // 
            // lblComputerNumber
            // 
            this.lblComputerNumber.AutoSize = true;
            this.lblComputerNumber.Location = new System.Drawing.Point(63, 425);
            this.lblComputerNumber.Name = "lblComputerNumber";
            this.lblComputerNumber.Size = new System.Drawing.Size(24, 13);
            this.lblComputerNumber.TabIndex = 4;
            this.lblComputerNumber.Text = "test";
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Location = new System.Drawing.Point(63, 401);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(44, 13);
            this.lblUserNumber.TabIndex = 5;
            this.lblUserNumber.Text = "usertest";
            // 
            // УгадайЧисло
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUserNumber);
            this.Controls.Add(this.lblComputerNumber);
            this.Controls.Add(this.lblUserCount);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Name = "УгадайЧисло";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label lblUserCount;
        private System.Windows.Forms.Label lblComputerNumber;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.TextBox txtBox1;
    }
}