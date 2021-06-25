
namespace project2
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.NameText3 = new System.Windows.Forms.TextBox();
            this.SurnameText3 = new System.Windows.Forms.TextBox();
            this.Username2 = new System.Windows.Forms.TextBox();
            this.Password2 = new System.Windows.Forms.TextBox();
            this.Apply = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Back3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Phonenumber = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameText3
            // 
            this.NameText3.Location = new System.Drawing.Point(955, 135);
            this.NameText3.Name = "NameText3";
            this.NameText3.Size = new System.Drawing.Size(152, 22);
            this.NameText3.TabIndex = 3;
            // 
            // SurnameText3
            // 
            this.SurnameText3.Location = new System.Drawing.Point(1125, 135);
            this.SurnameText3.Name = "SurnameText3";
            this.SurnameText3.Size = new System.Drawing.Size(157, 22);
            this.SurnameText3.TabIndex = 4;
            // 
            // Username2
            // 
            this.Username2.Location = new System.Drawing.Point(955, 365);
            this.Username2.Name = "Username2";
            this.Username2.Size = new System.Drawing.Size(327, 22);
            this.Username2.TabIndex = 6;
            this.Username2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Username2_KeyPress);
            // 
            // Password2
            // 
            this.Password2.Location = new System.Drawing.Point(955, 443);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(327, 22);
            this.Password2.TabIndex = 7;
            this.Password2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password2_KeyPress);
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.Maroon;
            this.Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Apply.ForeColor = System.Drawing.Color.White;
            this.Apply.Location = new System.Drawing.Point(1032, 576);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(185, 62);
            this.Apply.TabIndex = 8;
            this.Apply.Text = "สร้างบัญชีผู้ใช้";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 714);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(950, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "ชื่อ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(1120, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "นามสกุล";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(950, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "ชื่อผู้ใช้";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(950, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "รหัสผ่าน";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(1010, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "สร้างบัญชีผู้ใช้ใหม่";
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.Location = new System.Drawing.Point(955, 526);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Size = new System.Drawing.Size(327, 22);
            this.ConfirmPass.TabIndex = 20;
            this.ConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmPass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(950, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "ยืนยันรหัสผ่าน";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Silver;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Next.Location = new System.Drawing.Point(873, 662);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(255, 51);
            this.Next.TabIndex = 22;
            this.Next.Text = "เข้าสู่ระบบ";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back3
            // 
            this.Back3.BackColor = System.Drawing.Color.Silver;
            this.Back3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Back3.Location = new System.Drawing.Point(1125, 662);
            this.Back3.Name = "Back3";
            this.Back3.Size = new System.Drawing.Size(230, 51);
            this.Back3.TabIndex = 23;
            this.Back3.Text = "ย้อนกลับ";
            this.Back3.UseVisualStyleBackColor = false;
            this.Back3.Click += new System.EventHandler(this.Back3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(950, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "เบอร์โทรศัพท์";
            // 
            // Phonenumber
            // 
            this.Phonenumber.Location = new System.Drawing.Point(955, 206);
            this.Phonenumber.MaxLength = 10;
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(327, 22);
            this.Phonenumber.TabIndex = 25;
            this.Phonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phonenumber_KeyPress);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(955, 289);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(327, 22);
            this.address.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(950, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "ที่อยู่";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1355, 712);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address);
            this.Controls.Add(this.Phonenumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Back3);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.Password2);
            this.Controls.Add(this.Username2);
            this.Controls.Add(this.SurnameText3);
            this.Controls.Add(this.NameText3);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form6";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameText3;
        private System.Windows.Forms.TextBox SurnameText3;
        private System.Windows.Forms.TextBox Username2;
        private System.Windows.Forms.TextBox Password2;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Phonenumber;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label5;
    }
}