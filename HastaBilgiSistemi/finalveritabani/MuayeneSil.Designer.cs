namespace finalveritabani
{
    partial class MuayeneSil
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
            this.tckimlik = new System.Windows.Forms.TextBox();
            this.button_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silmek istediğiniz muayene kaydının hasta tc\'sini giriniz:";
            // 
            // tckimlik
            // 
            this.tckimlik.Location = new System.Drawing.Point(387, 9);
            this.tckimlik.Name = "tckimlik";
            this.tckimlik.Size = new System.Drawing.Size(100, 22);
            this.tckimlik.TabIndex = 1;
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.Color.LightGray;
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Location = new System.Drawing.Point(526, 6);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(86, 26);
            this.button_sil.TabIndex = 2;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(601, 276);
            this.dataGridView1.TabIndex = 3;
            // 
            // button_listele
            // 
            this.button_listele.BackColor = System.Drawing.Color.LightGray;
            this.button_listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_listele.Location = new System.Drawing.Point(99, 94);
            this.button_listele.Name = "button_listele";
            this.button_listele.Size = new System.Drawing.Size(119, 34);
            this.button_listele.TabIndex = 4;
            this.button_listele.Text = "LİSTELE";
            this.button_listele.UseVisualStyleBackColor = false;
            this.button_listele.Click += new System.EventHandler(this.button_listele_Click);
            // 
            // MuayeneSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_listele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.tckimlik);
            this.Controls.Add(this.label1);
            this.Name = "MuayeneSil";
            this.Text = "MuayeneSil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tckimlik;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_listele;
    }
}