
namespace Lab3Pacman
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.levelBox = new System.Windows.Forms.PictureBox();
            this.dfsButton = new System.Windows.Forms.Button();
            this.bfsButton = new System.Windows.Forms.Button();
            this.pacmanBox = new System.Windows.Forms.PictureBox();
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.memLabel = new System.Windows.Forms.Label();
            this.levelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanBox)).BeginInit();
            this.SuspendLayout();
            // 
            // levelBox
            // 
            this.levelBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.levelBox.Location = new System.Drawing.Point(0, 82);
            this.levelBox.Margin = new System.Windows.Forms.Padding(0);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(334, 302);
            this.levelBox.TabIndex = 0;
            this.levelBox.TabStop = false;
            this.levelBox.Click += new System.EventHandler(this.levelBox_Click);
            // 
            // dfsButton
            // 
            this.dfsButton.Enabled = false;
            this.dfsButton.Location = new System.Drawing.Point(231, 13);
            this.dfsButton.Margin = new System.Windows.Forms.Padding(4);
            this.dfsButton.Name = "dfsButton";
            this.dfsButton.Size = new System.Drawing.Size(94, 30);
            this.dfsButton.TabIndex = 2;
            this.dfsButton.Text = "DFS";
            this.dfsButton.UseVisualStyleBackColor = true;
            this.dfsButton.Click += new System.EventHandler(this.DFSButton_Click);
            // 
            // bfsButton
            // 
            this.bfsButton.Enabled = false;
            this.bfsButton.Location = new System.Drawing.Point(113, 13);
            this.bfsButton.Margin = new System.Windows.Forms.Padding(4);
            this.bfsButton.Name = "bfsButton";
            this.bfsButton.Size = new System.Drawing.Size(94, 26);
            this.bfsButton.TabIndex = 3;
            this.bfsButton.Text = "BFS";
            this.bfsButton.UseVisualStyleBackColor = true;
            this.bfsButton.Click += new System.EventHandler(this.BFSButton_Click);
            // 
            // pacmanBox
            // 
            this.pacmanBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pacmanBox.Image = ((System.Drawing.Image)(resources.GetObject("pacmanBox.Image")));
            this.pacmanBox.Location = new System.Drawing.Point(0, 82);
            this.pacmanBox.Margin = new System.Windows.Forms.Padding(0);
            this.pacmanBox.Name = "pacmanBox";
            this.pacmanBox.Size = new System.Drawing.Size(18, 18);
            this.pacmanBox.TabIndex = 4;
            this.pacmanBox.TabStop = false;
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.AutoSize = true;
            this.elapsedLabel.Location = new System.Drawing.Point(58, 52);
            this.elapsedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(0, 17);
            this.elapsedLabel.TabIndex = 5;
            // 
            // memLabel
            // 
            this.memLabel.AutoSize = true;
            this.memLabel.Location = new System.Drawing.Point(150, 52);
            this.memLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memLabel.Name = "memLabel";
            this.memLabel.Size = new System.Drawing.Size(0, 17);
            this.memLabel.TabIndex = 6;
            // 
            // levelButton
            // 
            this.levelButton.Location = new System.Drawing.Point(0, 4);
            this.levelButton.Margin = new System.Windows.Forms.Padding(4);
            this.levelButton.Name = "levelButton";
            this.levelButton.Size = new System.Drawing.Size(94, 44);
            this.levelButton.TabIndex = 7;
            this.levelButton.Text = "Create level";
            this.levelButton.UseVisualStyleBackColor = true;
            this.levelButton.Click += new System.EventHandler(this.createAreaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Memory";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.levelButton);
            this.Controls.Add(this.memLabel);
            this.Controls.Add(this.elapsedLabel);
            this.Controls.Add(this.pacmanBox);
            this.Controls.Add(this.bfsButton);
            this.Controls.Add(this.dfsButton);
            this.Controls.Add(this.levelBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "PACMAN";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacmanBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox levelBox;
        private System.Windows.Forms.Button dfsButton;
        private System.Windows.Forms.Button bfsButton;
        private System.Windows.Forms.PictureBox pacmanBox;
        private System.Windows.Forms.Label elapsedLabel;
        private System.Windows.Forms.Label memLabel;
        private System.Windows.Forms.Button levelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

