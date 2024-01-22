
namespace Puzzle_Ionescu_Oana
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
            this.Login_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Login1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.parolaJucator = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.parolaAdministrator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Login2 = new System.Windows.Forms.Button();
            this.Login_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_tab
            // 
            this.Login_tab.Controls.Add(this.tabPage1);
            this.Login_tab.Controls.Add(this.tabPage2);
            this.Login_tab.Location = new System.Drawing.Point(239, 87);
            this.Login_tab.Name = "Login_tab";
            this.Login_tab.SelectedIndex = 0;
            this.Login_tab.Size = new System.Drawing.Size(399, 251);
            this.Login_tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.parolaJucator);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Login1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jucator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Login2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.parolaAdministrator);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administrator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Login1
            // 
            this.btn_Login1.Location = new System.Drawing.Point(156, 166);
            this.btn_Login1.Name = "btn_Login1";
            this.btn_Login1.Size = new System.Drawing.Size(75, 30);
            this.btn_Login1.TabIndex = 0;
            this.btn_Login1.Text = "Login";
            this.btn_Login1.UseVisualStyleBackColor = true;
            this.btn_Login1.Click += new System.EventHandler(this.btn_Login1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // parolaJucator
            // 
            this.parolaJucator.Location = new System.Drawing.Point(156, 104);
            this.parolaJucator.Name = "parolaJucator";
            this.parolaJucator.Size = new System.Drawing.Size(100, 22);
            this.parolaJucator.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // parolaAdministrator
            // 
            this.parolaAdministrator.Location = new System.Drawing.Point(136, 101);
            this.parolaAdministrator.Name = "parolaAdministrator";
            this.parolaAdministrator.Size = new System.Drawing.Size(100, 22);
            this.parolaAdministrator.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola";
            // 
            // btn_Login2
            // 
            this.btn_Login2.Location = new System.Drawing.Point(161, 163);
            this.btn_Login2.Name = "btn_Login2";
            this.btn_Login2.Size = new System.Drawing.Size(75, 32);
            this.btn_Login2.TabIndex = 4;
            this.btn_Login2.Text = "Login";
            this.btn_Login2.UseVisualStyleBackColor = true;
            this.btn_Login2.Click += new System.EventHandler(this.btn_Login2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Login_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Login_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox parolaJucator;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Login2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parolaAdministrator;
        private System.Windows.Forms.TextBox textBox2;
    }
}

