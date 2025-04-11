namespace Bai20_BaiThiThu
{
    partial class giaiphuongtrinhbac2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtso3 = new System.Windows.Forms.TextBox();
            this.btnkq = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TrackBar();
            this.tb2 = new System.Windows.Forms.TrackBar();
            this.tb3 = new System.Windows.Forms.TrackBar();
            this.lblkq = new System.Windows.Forms.Label();
            this.LBL = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "nhập b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "nhập c";
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(96, 108);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 1;
            this.txtso1.TextChanged += new System.EventHandler(this.giaiphuongtrinhbac2_Load);
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(96, 169);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 1;
            // 
            // txtso3
            // 
            this.txtso3.Location = new System.Drawing.Point(96, 231);
            this.txtso3.Name = "txtso3";
            this.txtso3.Size = new System.Drawing.Size(100, 20);
            this.txtso3.TabIndex = 1;
            // 
            // btnkq
            // 
            this.btnkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkq.Location = new System.Drawing.Point(224, 298);
            this.btnkq.Name = "btnkq";
            this.btnkq.Size = new System.Drawing.Size(173, 40);
            this.btnkq.TabIndex = 2;
            this.btnkq.Text = "Giải Phương Trình";
            this.btnkq.UseVisualStyleBackColor = true;
            this.btnkq.Click += new System.EventHandler(this.btnkq_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(224, 108);
            this.tb1.Minimum = -10;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(227, 45);
            this.tb1.TabIndex = 3;
            this.tb1.Value = 1;
            this.tb1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(224, 169);
            this.tb2.Minimum = -10;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(227, 45);
            this.tb2.TabIndex = 3;
            this.tb2.Scroll += new System.EventHandler(this.tb2_Scroll);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(224, 231);
            this.tb3.Minimum = -10;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(227, 45);
            this.tb3.TabIndex = 3;
            this.tb3.Scroll += new System.EventHandler(this.tb3_Scroll);
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(56, 347);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(43, 13);
            this.lblkq.TabIndex = 4;
            this.lblkq.Text = "kết quả";
            // 
            // LBL
            // 
            this.LBL.AutoSize = true;
            this.LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL.Location = new System.Drawing.Point(71, 26);
            this.LBL.Name = "LBL";
            this.LBL.Size = new System.Drawing.Size(666, 33);
            this.LBL.TabIndex = 5;
            this.LBL.Text = "PHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 72);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 18);
            this.progressBar1.TabIndex = 6;
            // 
            // giaiphuongtrinhbac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LBL);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.btnkq);
            this.Controls.Add(this.txtso3);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "giaiphuongtrinhbac2";
            this.Text = "giaiphuongtrinhbac2";
            this.Load += new System.EventHandler(this.giaiphuongtrinhbac2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtso3;
        private System.Windows.Forms.Button btnkq;
        private System.Windows.Forms.TrackBar tb1;
        private System.Windows.Forms.TrackBar tb2;
        private System.Windows.Forms.TrackBar tb3;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.Label LBL;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}