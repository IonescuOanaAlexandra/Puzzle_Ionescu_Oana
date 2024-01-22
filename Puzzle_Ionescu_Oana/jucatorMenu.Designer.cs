
namespace Puzzle_Ionescu_Oana
{
    partial class jucatorMenu
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
            this.jocNou = new System.Windows.Forms.Button();
            this.clasament = new System.Windows.Forms.Button();
            this.iesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jocNou
            // 
            this.jocNou.Location = new System.Drawing.Point(159, 204);
            this.jocNou.Name = "jocNou";
            this.jocNou.Size = new System.Drawing.Size(75, 23);
            this.jocNou.TabIndex = 0;
            this.jocNou.Text = "Joc Nou";
            this.jocNou.UseVisualStyleBackColor = true;
            this.jocNou.Click += new System.EventHandler(this.jocNou_Click);
            // 
            // clasament
            // 
            this.clasament.Location = new System.Drawing.Point(317, 204);
            this.clasament.Name = "clasament";
            this.clasament.Size = new System.Drawing.Size(84, 23);
            this.clasament.TabIndex = 1;
            this.clasament.Text = "Clasament";
            this.clasament.UseVisualStyleBackColor = true;
            // 
            // iesire
            // 
            this.iesire.Location = new System.Drawing.Point(493, 204);
            this.iesire.Name = "iesire";
            this.iesire.Size = new System.Drawing.Size(84, 23);
            this.iesire.TabIndex = 2;
            this.iesire.Text = "Iesire";
            this.iesire.UseVisualStyleBackColor = true;
            // 
            // jucatorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iesire);
            this.Controls.Add(this.clasament);
            this.Controls.Add(this.jocNou);
            this.Name = "jucatorMenu";
            this.Text = "jucatorMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jocNou;
        private System.Windows.Forms.Button clasament;
        private System.Windows.Forms.Button iesire;
    }
}