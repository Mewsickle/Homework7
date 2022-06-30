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
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.угадайЧислоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.угадайЧислоToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удвоительToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.btnCommand1.Visible = false;
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
            this.btnCommand2.Visible = false;
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
            this.btnReset.Text = "Новая игра";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.UseCompatibleTextRendering = true;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserNumber.Location = new System.Drawing.Point(109, 70);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(24, 26);
            this.lblUserNumber.TabIndex = 3;
            this.lblUserNumber.Text = "0";
            this.lblUserNumber.Visible = false;
            // 
            // lblComputerNumber
            // 
            this.lblComputerNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComputerNumber.AutoSize = true;
            this.lblComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComputerNumber.Location = new System.Drawing.Point(109, 171);
            this.lblComputerNumber.Name = "lblComputerNumber";
            this.lblComputerNumber.Size = new System.Drawing.Size(24, 26);
            this.lblComputerNumber.TabIndex = 4;
            this.lblComputerNumber.Text = "0";
            this.lblComputerNumber.Visible = false;
            // 
            // lblClickCount
            // 
            this.lblClickCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClickCount.AutoSize = true;
            this.lblClickCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClickCount.Location = new System.Drawing.Point(109, 279);
            this.lblClickCount.Name = "lblClickCount";
            this.lblClickCount.Size = new System.Drawing.Size(24, 26);
            this.lblClickCount.TabIndex = 5;
            this.lblClickCount.Text = "0";
            this.lblClickCount.Visible = false;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.Location = new System.Drawing.Point(255, 70);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonNewGame.Size = new System.Drawing.Size(225, 80);
            this.buttonNewGame.TabIndex = 6;
            this.buttonNewGame.Text = "Новая Игра";
            this.buttonNewGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonNewGame.UseCompatibleTextRendering = true;
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(255, 212);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonClose.Size = new System.Drawing.Size(225, 80);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Выход из игры";
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonClose.UseCompatibleTextRendering = true;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.угадайЧислоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // угадайЧислоToolStripMenuItem
            // 
            this.угадайЧислоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.угадайЧислоToolStripMenuItem1,
            this.удвоительToolStripMenuItem});
            this.угадайЧислоToolStripMenuItem.Name = "угадайЧислоToolStripMenuItem";
            this.угадайЧислоToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.угадайЧислоToolStripMenuItem.Text = "Выбор игры";
            // 
            // угадайЧислоToolStripMenuItem1
            // 
            this.угадайЧислоToolStripMenuItem1.Name = "угадайЧислоToolStripMenuItem1";
            this.угадайЧислоToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.угадайЧислоToolStripMenuItem1.Text = "Угадай число";
            this.угадайЧислоToolStripMenuItem1.Click += new System.EventHandler(this.угадайЧислоToolStripMenuItem1_Click);
            // 
            // удвоительToolStripMenuItem
            // 
            this.удвоительToolStripMenuItem.Name = "удвоительToolStripMenuItem";
            this.удвоительToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удвоительToolStripMenuItem.Text = "Удвоитель";
            // 
            // Удвоитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(768, 380);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.lblClickCount);
            this.Controls.Add(this.lblComputerNumber);
            this.Controls.Add(this.lblUserNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(784, 419);
            this.Name = "Удвоитель";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.Load += new System.EventHandler(this.Удвоитель_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem угадайЧислоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem угадайЧислоToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удвоительToolStripMenuItem;
    }
}

