
namespace MongoDB_demo
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
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.dgvChuyenBay = new System.Windows.Forms.DataGridView();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.btnLoadKhach = new System.Windows.Forms.Button();
            this.btnLoadChuyenBay = new System.Windows.Forms.Button();
            this.btnLoadVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhach
            // 
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Location = new System.Drawing.Point(25, 12);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.RowTemplate.Height = 24;
            this.dgvKhach.Size = new System.Drawing.Size(335, 199);
            this.dgvKhach.TabIndex = 0;
            this.dgvKhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhach_CellContentClick);
            // 
            // dgvChuyenBay
            // 
            this.dgvChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenBay.Location = new System.Drawing.Point(25, 238);
            this.dgvChuyenBay.Name = "dgvChuyenBay";
            this.dgvChuyenBay.RowHeadersWidth = 51;
            this.dgvChuyenBay.RowTemplate.Height = 24;
            this.dgvChuyenBay.Size = new System.Drawing.Size(335, 187);
            this.dgvChuyenBay.TabIndex = 2;
            // 
            // dgvVe
            // 
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Location = new System.Drawing.Point(431, 16);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.RowHeadersWidth = 51;
            this.dgvVe.RowTemplate.Height = 24;
            this.dgvVe.Size = new System.Drawing.Size(335, 187);
            this.dgvVe.TabIndex = 3;
            // 
            // btnLoadKhach
            // 
            this.btnLoadKhach.Location = new System.Drawing.Point(431, 238);
            this.btnLoadKhach.Name = "btnLoadKhach";
            this.btnLoadKhach.Size = new System.Drawing.Size(335, 31);
            this.btnLoadKhach.TabIndex = 4;
            this.btnLoadKhach.Text = "Load Du Lieu\r\n Khach";
            this.btnLoadKhach.UseVisualStyleBackColor = true;
            this.btnLoadKhach.Click += new System.EventHandler(this.btnLoadKhach_Click);
            // 
            // btnLoadChuyenBay
            // 
            this.btnLoadChuyenBay.Location = new System.Drawing.Point(431, 285);
            this.btnLoadChuyenBay.Name = "btnLoadChuyenBay";
            this.btnLoadChuyenBay.Size = new System.Drawing.Size(335, 31);
            this.btnLoadChuyenBay.TabIndex = 5;
            this.btnLoadChuyenBay.Text = "Load du lieu Chuyen Bay";
            this.btnLoadChuyenBay.UseVisualStyleBackColor = true;
            this.btnLoadChuyenBay.Click += new System.EventHandler(this.btnLoadChuyenBay_Click);
            // 
            // btnLoadVe
            // 
            this.btnLoadVe.Location = new System.Drawing.Point(431, 338);
            this.btnLoadVe.Name = "btnLoadVe";
            this.btnLoadVe.Size = new System.Drawing.Size(335, 31);
            this.btnLoadVe.TabIndex = 6;
            this.btnLoadVe.Text = "Load du lieu Ve";
            this.btnLoadVe.UseVisualStyleBackColor = true;
            this.btnLoadVe.Click += new System.EventHandler(this.btnLoadVe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "[Khach]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "[Ve]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "[ChuyenBay]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadVe);
            this.Controls.Add(this.btnLoadChuyenBay);
            this.Controls.Add(this.btnLoadKhach);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.dgvChuyenBay);
            this.Controls.Add(this.dgvKhach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.DataGridView dgvChuyenBay;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.Button btnLoadKhach;
        private System.Windows.Forms.Button btnLoadChuyenBay;
        private System.Windows.Forms.Button btnLoadVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

