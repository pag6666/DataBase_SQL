
namespace WindowsFormsApp2
{
    partial class RegistWindows
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
            this.button1 = new System.Windows.Forms.Button();
            this.eye = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PASSWORD_us = new System.Windows.Forms.TextBox();
            this.LOGIN_us = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eye)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(113, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eye
            // 
            this.eye.Location = new System.Drawing.Point(238, 155);
            this.eye.Name = "eye";
            this.eye.Size = new System.Drawing.Size(28, 27);
            this.eye.TabIndex = 1;
            this.eye.TabStop = false;
            this.eye.Click += new System.EventHandler(this.eye_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.PASSWORD_us);
            this.groupBox1.Controls.Add(this.LOGIN_us);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.eye);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(75, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 235);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // PASSWORD_us
            // 
            this.PASSWORD_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PASSWORD_us.Location = new System.Drawing.Point(12, 138);
            this.PASSWORD_us.Multiline = true;
            this.PASSWORD_us.Name = "PASSWORD_us";
            this.PASSWORD_us.Size = new System.Drawing.Size(211, 20);
            this.PASSWORD_us.TabIndex = 5;
            this.PASSWORD_us.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PASSWORD_us_KeyDown);
            // 
            // LOGIN_us
            // 
            this.LOGIN_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LOGIN_us.Location = new System.Drawing.Point(12, 50);
            this.LOGIN_us.Multiline = true;
            this.LOGIN_us.Name = "LOGIN_us";
            this.LOGIN_us.Size = new System.Drawing.Size(211, 50);
            this.LOGIN_us.TabIndex = 4;
            // 
            // RegistWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "RegistWindows";
            this.Text = "RegistWindows";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistWindows_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.eye)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox eye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PASSWORD_us;
        private System.Windows.Forms.TextBox LOGIN_us;
    }
}