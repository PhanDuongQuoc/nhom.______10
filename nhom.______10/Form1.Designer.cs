namespace nhom.______10
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
            this.btnvedau = new System.Windows.Forms.Button();
            this.btnquatrai = new System.Windows.Forms.Button();
            this.btnquaphai = new System.Windows.Forms.Button();
            this.btnvecuoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmnv = new System.Windows.Forms.TextBox();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.txtkhoa = new System.Windows.Forms.TextBox();
            this.lblvitritongso = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvedau
            // 
            this.btnvedau.Location = new System.Drawing.Point(143, 44);
            this.btnvedau.Name = "btnvedau";
            this.btnvedau.Size = new System.Drawing.Size(75, 41);
            this.btnvedau.TabIndex = 0;
            this.btnvedau.Text = "|<";
            this.btnvedau.UseVisualStyleBackColor = true;
            this.btnvedau.Click += new System.EventHandler(this.btnvedau_Click);
            // 
            // btnquatrai
            // 
            this.btnquatrai.Location = new System.Drawing.Point(261, 44);
            this.btnquatrai.Name = "btnquatrai";
            this.btnquatrai.Size = new System.Drawing.Size(75, 41);
            this.btnquatrai.TabIndex = 1;
            this.btnquatrai.Text = "<<";
            this.btnquatrai.UseVisualStyleBackColor = true;
            this.btnquatrai.Click += new System.EventHandler(this.btnquatrai_Click);
            // 
            // btnquaphai
            // 
            this.btnquaphai.Location = new System.Drawing.Point(461, 44);
            this.btnquaphai.Name = "btnquaphai";
            this.btnquaphai.Size = new System.Drawing.Size(75, 41);
            this.btnquaphai.TabIndex = 2;
            this.btnquaphai.Text = ">>";
            this.btnquaphai.UseVisualStyleBackColor = true;
            this.btnquaphai.Click += new System.EventHandler(this.btnquaphai_Click);
            // 
            // btnvecuoi
            // 
            this.btnvecuoi.Location = new System.Drawing.Point(581, 44);
            this.btnvecuoi.Name = "btnvecuoi";
            this.btnvecuoi.Size = new System.Drawing.Size(75, 41);
            this.btnvecuoi.TabIndex = 3;
            this.btnvecuoi.Text = ">|";
            this.btnvecuoi.UseVisualStyleBackColor = true;
            this.btnvecuoi.Click += new System.EventHandler(this.btnvecuoi_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(82, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANV:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(82, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "TenNV:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(82, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điểm:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(82, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Khoa:";
            // 
            // txtmnv
            // 
            this.txtmnv.Location = new System.Drawing.Point(236, 132);
            this.txtmnv.Name = "txtmnv";
            this.txtmnv.Size = new System.Drawing.Size(420, 22);
            this.txtmnv.TabIndex = 8;
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(236, 190);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(420, 22);
            this.txttennv.TabIndex = 9;
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(236, 235);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(420, 22);
            this.txtdiem.TabIndex = 10;
            // 
            // txtkhoa
            // 
            this.txtkhoa.Location = new System.Drawing.Point(236, 274);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(420, 22);
            this.txtkhoa.TabIndex = 11;
            // 
            // lblvitritongso
            // 
            this.lblvitritongso.Location = new System.Drawing.Point(355, 62);
            this.lblvitritongso.Name = "lblvitritongso";
            this.lblvitritongso.Size = new System.Drawing.Size(100, 23);
            this.lblvitritongso.TabIndex = 12;
            this.lblvitritongso.Text = "vi tri/tong so";
            this.lblvitritongso.Click += new System.EventHandler(this.btnvedau_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(252, 321);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 41);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(380, 321);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 41);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(495, 321);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 41);
            this.btnluu.TabIndex = 15;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lblvitritongso);
            this.Controls.Add(this.txtkhoa);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtmnv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvecuoi);
            this.Controls.Add(this.btnquaphai);
            this.Controls.Add(this.btnquatrai);
            this.Controls.Add(this.btnvedau);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvedau;
        private System.Windows.Forms.Button btnquatrai;
        private System.Windows.Forms.Button btnquaphai;
        private System.Windows.Forms.Button btnvecuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmnv;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.TextBox txtkhoa;
        private System.Windows.Forms.Label lblvitritongso;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
    }
}

