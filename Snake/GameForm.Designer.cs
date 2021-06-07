
namespace Snake
{
    partial class GameForm
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
            this.gameCanvas1 = new GameCanvas();
            this.SuspendLayout();
            // 
            // gameCanvas1
            // 
            this.gameCanvas1.BackColor = System.Drawing.Color.White;
            this.gameCanvas1.Location = new System.Drawing.Point(12, 11);
            this.gameCanvas1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameCanvas1.Name = "gameCanvas1";
            this.gameCanvas1.Size = new System.Drawing.Size(875, 450);
            this.gameCanvas1.TabIndex = 0;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 469);
            this.Controls.Add(this.gameCanvas1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private GameCanvas gameCanvas1;
    }
}