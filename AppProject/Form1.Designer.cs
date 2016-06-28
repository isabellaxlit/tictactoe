namespace AppProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.gameModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.gameModeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Image = ((System.Drawing.Image)(resources.GetObject("A1.Image")));
            this.A1.Location = new System.Drawing.Point(116, 74);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(167, 155);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Image = ((System.Drawing.Image)(resources.GetObject("A2.Image")));
            this.A2.Location = new System.Drawing.Point(289, 74);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(167, 155);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Image = ((System.Drawing.Image)(resources.GetObject("A3.Image")));
            this.A3.Location = new System.Drawing.Point(462, 74);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(173, 155);
            this.A3.TabIndex = 3;
            this.A3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Image = ((System.Drawing.Image)(resources.GetObject("B1.Image")));
            this.B1.Location = new System.Drawing.Point(116, 235);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(167, 155);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Image = ((System.Drawing.Image)(resources.GetObject("B2.Image")));
            this.B2.Location = new System.Drawing.Point(289, 235);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(167, 155);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Image = ((System.Drawing.Image)(resources.GetObject("B3.Image")));
            this.B3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B3.Location = new System.Drawing.Point(462, 235);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(173, 155);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Image = ((System.Drawing.Image)(resources.GetObject("C1.Image")));
            this.C1.Location = new System.Drawing.Point(116, 396);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(167, 148);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Image = ((System.Drawing.Image)(resources.GetObject("C2.Image")));
            this.C2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.C2.Location = new System.Drawing.Point(289, 396);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(167, 148);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Image = ((System.Drawing.Image)(resources.GetObject("C3.Image")));
            this.C3.Location = new System.Drawing.Point(462, 396);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(173, 148);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // gameModeToolStripMenuItem
            // 
            this.gameModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cPUToolStripMenuItem});
            this.gameModeToolStripMenuItem.Name = "gameModeToolStripMenuItem";
            this.gameModeToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.gameModeToolStripMenuItem.Text = "Game Mode";
            // 
            // cPUToolStripMenuItem
            // 
            this.cPUToolStripMenuItem.Name = "cPUToolStripMenuItem";
            this.cPUToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cPUToolStripMenuItem.Text = "CPU";
            this.cPUToolStripMenuItem.Click += new System.EventHandler(this.cPUToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CNF Camp Tic Tac Toe";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.ToolStripMenuItem gameModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPUToolStripMenuItem;
    }
}

