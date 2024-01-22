
namespace Puzzle_Ionescu_Oana
{
    partial class administratorMenu
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
            this.editare = new System.Windows.Forms.Button();
            this.iesire2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editare
            // 
            this.editare.Location = new System.Drawing.Point(168, 200);
            this.editare.Name = "editare";
            this.editare.Size = new System.Drawing.Size(155, 23);
            this.editare.TabIndex = 0;
            this.editare.Text = "Editare clasament";
            this.editare.UseVisualStyleBackColor = true;
            // 
            // iesire2
            // 
            this.iesire2.Location = new System.Drawing.Point(401, 200);
            this.iesire2.Name = "iesire2";
            this.iesire2.Size = new System.Drawing.Size(155, 23);
            this.iesire2.TabIndex = 1;
            this.iesire2.Text = "Iesire";
            this.iesire2.UseVisualStyleBackColor = true;
            // 
            // administratorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iesire2);
            this.Controls.Add(this.editare);
            this.Name = "administratorMenu";
            this.Text = "administratorMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editare;
        private System.Windows.Forms.Button iesire2;
    }
}