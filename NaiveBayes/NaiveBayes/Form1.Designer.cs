﻿namespace NaiveBayes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSoNhom = new System.Windows.Forms.NumericUpDown();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.pnHinhVe = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btThucHien = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tệp dữ liệu";
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(16, 34);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.Size = new System.Drawing.Size(464, 23);
            this.tbDuongDan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số nhóm";
            // 
            // nudSoNhom
            // 
            this.nudSoNhom.Location = new System.Drawing.Point(19, 85);
            this.nudSoNhom.Name = "nudSoNhom";
            this.nudSoNhom.Size = new System.Drawing.Size(120, 23);
            this.nudSoNhom.TabIndex = 4;
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(19, 171);
            this.tbKetQua.Multiline = true;
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(542, 410);
            this.tbKetQua.TabIndex = 6;
            // 
            // pnHinhVe
            // 
            this.pnHinhVe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHinhVe.Location = new System.Drawing.Point(568, 13);
            this.pnHinhVe.Name = "pnHinhVe";
            this.pnHinhVe.Size = new System.Drawing.Size(578, 568);
            this.pnHinhVe.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả thực hiện";
            // 
            // btThucHien
            // 
            this.btThucHien.Image = global::NaiveBayes.Properties.Resources.FireMan20;
            this.btThucHien.Location = new System.Drawing.Point(19, 115);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(137, 33);
            this.btThucHien.TabIndex = 5;
            this.btThucHien.Text = "Thực hiện";
            this.btThucHien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThucHien.UseVisualStyleBackColor = true;
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // btTim
            // 
            this.btTim.Image = global::NaiveBayes.Properties.Resources.SearchIcon20;
            this.btTim.Location = new System.Drawing.Point(486, 32);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 27);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm";
            this.btTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnHinhVe);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.nudSoNhom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Naive Bayes";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSoNhom;
        private System.Windows.Forms.Button btThucHien;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Panel pnHinhVe;
        private System.Windows.Forms.Label label3;
    }
}

