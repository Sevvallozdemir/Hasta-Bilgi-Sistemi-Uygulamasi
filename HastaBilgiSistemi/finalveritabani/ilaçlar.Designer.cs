namespace finalveritabani
{
    partial class ilaçlar
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
            this.barkod_no = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ilac_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ilac_tipi = new System.Windows.Forms.TextBox();
            this.ilacekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(354, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlaçtar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlacın Barkod Numarası:";
            // 
            // barkod_no
            // 
            this.barkod_no.Location = new System.Drawing.Point(206, 58);
            this.barkod_no.Name = "barkod_no";
            this.barkod_no.Size = new System.Drawing.Size(100, 22);
            this.barkod_no.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "İlacın Adı:";
            // 
            // ilac_adi
            // 
            this.ilac_adi.Location = new System.Drawing.Point(100, 92);
            this.ilac_adi.Name = "ilac_adi";
            this.ilac_adi.Size = new System.Drawing.Size(130, 22);
            this.ilac_adi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "İlacın Tipi:";
            // 
            // ilac_tipi
            // 
            this.ilac_tipi.Location = new System.Drawing.Point(103, 135);
            this.ilac_tipi.Name = "ilac_tipi";
            this.ilac_tipi.Size = new System.Drawing.Size(100, 22);
            this.ilac_tipi.TabIndex = 6;
            // 
            // ilacekle
            // 
            this.ilacekle.BackColor = System.Drawing.Color.LightGray;
            this.ilacekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilacekle.Location = new System.Drawing.Point(379, 77);
            this.ilacekle.Name = "ilacekle";
            this.ilacekle.Size = new System.Drawing.Size(190, 57);
            this.ilacekle.TabIndex = 7;
            this.ilacekle.Text = "İlaç Ekle";
            this.ilacekle.UseVisualStyleBackColor = false;
            this.ilacekle.Click += new System.EventHandler(this.ilacekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(556, 206);
            this.dataGridView1.TabIndex = 8;
            // 
            // listele
            // 
            this.listele.BackColor = System.Drawing.Color.LightGray;
            this.listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listele.Location = new System.Drawing.Point(118, 182);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(122, 39);
            this.listele.TabIndex = 9;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = false;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // ilaçlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ilacekle);
            this.Controls.Add(this.ilac_tipi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ilac_adi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barkod_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ilaçlar";
            this.Text = "ilaçlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barkod_no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ilac_adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ilac_tipi;
        private System.Windows.Forms.Button ilacekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listele;
    }
}