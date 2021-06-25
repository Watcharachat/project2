
namespace project2
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataApplicants4 = new System.Windows.Forms.DataGridView();
            this.search2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Back2 = new System.Windows.Forms.Button();
            this.Exit2 = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataApplicants4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ตรวจสอบข้อมูลการสมัคร";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(330, -109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataApplicants4
            // 
            this.dataApplicants4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataApplicants4.Location = new System.Drawing.Point(43, 376);
            this.dataApplicants4.Name = "dataApplicants4";
            this.dataApplicants4.RowHeadersWidth = 51;
            this.dataApplicants4.RowTemplate.Height = 24;
            this.dataApplicants4.Size = new System.Drawing.Size(973, 160);
            this.dataApplicants4.TabIndex = 3;
            // 
            // search2
            // 
            this.search2.BackColor = System.Drawing.Color.MistyRose;
            this.search2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.search2.Location = new System.Drawing.Point(43, 343);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(256, 27);
            this.search2.TabIndex = 4;
            this.search2.TextChanged += new System.EventHandler(this.search2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(185, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(677, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "คุณได้ยืนยันการสมัครเรียบร้อยแล้ว";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(287, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(494, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "You have confirmed the application";
            // 
            // Back2
            // 
            this.Back2.BackColor = System.Drawing.Color.Maroon;
            this.Back2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Back2.ForeColor = System.Drawing.Color.White;
            this.Back2.Location = new System.Drawing.Point(581, 575);
            this.Back2.Name = "Back2";
            this.Back2.Size = new System.Drawing.Size(200, 42);
            this.Back2.TabIndex = 7;
            this.Back2.Text = "กลับสู่หน้าหลัก";
            this.Back2.UseVisualStyleBackColor = false;
            this.Back2.Click += new System.EventHandler(this.Back2_Click);
            // 
            // Exit2
            // 
            this.Exit2.BackColor = System.Drawing.Color.Maroon;
            this.Exit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Exit2.ForeColor = System.Drawing.Color.White;
            this.Exit2.Location = new System.Drawing.Point(787, 575);
            this.Exit2.Name = "Exit2";
            this.Exit2.Size = new System.Drawing.Size(229, 42);
            this.Exit2.TabIndex = 8;
            this.Exit2.Text = "ออกจากระบบ";
            this.Exit2.UseVisualStyleBackColor = false;
            this.Exit2.Click += new System.EventHandler(this.Exit2_Click);
            // 
            // Print
            // 
            this.Print.BackColor = System.Drawing.Color.DodgerBlue;
            this.Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Print.ForeColor = System.Drawing.Color.Black;
            this.Print.Location = new System.Drawing.Point(317, 329);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(162, 41);
            this.Print.TabIndex = 9;
            this.Print.Text = "พิมพ์เอกสาร";
            this.Print.UseVisualStyleBackColor = false;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 629);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Exit2);
            this.Controls.Add(this.Back2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.dataApplicants4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataApplicants4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataApplicants4;
        private System.Windows.Forms.TextBox search2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Back2;
        private System.Windows.Forms.Button Exit2;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}