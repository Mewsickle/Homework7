namespace Homework7
{
    partial class Удвоитель
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.lblComputerNumber = new System.Windows.Forms.Label();
            this.lblClickCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCommand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCommand1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCommand1.Location = new System.Drawing.Point(496, 137);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(225, 80);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "Прибавить к числу 1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommand2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCommand2.Location = new System.Drawing.Point(496, 245);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(225, 80);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "Умножить число на 2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(496, 36);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReset.Size = new System.Drawing.Size(225, 80);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Новая Игра";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.UseCompatibleTextRendering = true;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Location = new System.Drawing.Point(109, 70);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(13, 13);
            this.lblUserNumber.TabIndex = 3;
            this.lblUserNumber.Text = "0";
            // 
            // lblComputerNumber
            // 
            this.lblComputerNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComputerNumber.AutoSize = true;
            this.lblComputerNumber.Location = new System.Drawing.Point(109, 171);
            this.lblComputerNumber.Name = "lblComputerNumber";
            this.lblComputerNumber.Size = new System.Drawing.Size(13, 13);
            this.lblComputerNumber.TabIndex = 4;
            this.lblComputerNumber.Text = "0";
            this.lblComputerNumber.Click += new System.EventHandler(this.lblComputerNumber_Click);
            // 
            // lblClickCount
            // 
            this.lblClickCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClickCount.AutoSize = true;
            this.lblClickCount.Location = new System.Drawing.Point(109, 279);
            this.lblClickCount.Name = "lblClickCount";
            this.lblClickCount.Size = new System.Drawing.Size(13, 13);
            this.lblClickCount.TabIndex = 5;
            this.lblClickCount.Text = "0";
            this.lblClickCount.Click += new System.EventHandler(this.lblClickCount_Click);
            // 
            // Удвоитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 380);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.lblClickCount);
            this.Controls.Add(this.lblComputerNumber);
            this.Controls.Add(this.lblUserNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Name = "Удвоитель";
            this.Text = "Удвоитель";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.Label lblComputerNumber;
        private System.Windows.Forms.Label lblClickCount;
    }
}

