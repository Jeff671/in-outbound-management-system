
namespace test
{
    partial class Form2
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
            this.LoginBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.AccInp = new System.Windows.Forms.TextBox();
            this.PasInp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBut
            // 
            this.LoginBut.Font = new System.Drawing.Font("新細明體", 11F);
            this.LoginBut.Location = new System.Drawing.Point(72, 130);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(75, 23);
            this.LoginBut.TabIndex = 0;
            this.LoginBut.Text = "登入";
            this.LoginBut.UseVisualStyleBackColor = true;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // CancelBut
            // 
            this.CancelBut.Font = new System.Drawing.Font("新細明體", 11F);
            this.CancelBut.Location = new System.Drawing.Point(214, 130);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(75, 23);
            this.CancelBut.TabIndex = 1;
            this.CancelBut.Text = "取消";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // AccInp
            // 
            this.AccInp.Location = new System.Drawing.Point(141, 33);
            this.AccInp.Name = "AccInp";
            this.AccInp.Size = new System.Drawing.Size(100, 22);
            this.AccInp.TabIndex = 2;
            this.AccInp.TextChanged += new System.EventHandler(this.AccInp_TextChanged);
            // 
            // PasInp
            // 
            this.PasInp.Location = new System.Drawing.Point(141, 81);
            this.PasInp.Name = "PasInp";
            this.PasInp.Size = new System.Drawing.Size(100, 22);
            this.PasInp.TabIndex = 3;
            this.PasInp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 11F);
            this.label1.Location = new System.Drawing.Point(98, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 11F);
            this.label2.Location = new System.Drawing.Point(98, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "密碼";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasInp);
            this.Controls.Add(this.AccInp);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.LoginBut);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.TextBox AccInp;
        private System.Windows.Forms.TextBox PasInp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}