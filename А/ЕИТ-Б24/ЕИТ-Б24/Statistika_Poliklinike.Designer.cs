namespace ЕИТ_Б24
{
    partial class Statistika_Poliklinike
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIsti = new System.Windows.Forms.RadioButton();
            this.rbDrugi = new System.Windows.Forms.RadioButton();
            this.rbSvi = new System.Windows.Forms.RadioButton();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbOdDat = new System.Windows.Forms.TextBox();
            this.tbDoDat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSvi);
            this.groupBox1.Controls.Add(this.rbDrugi);
            this.groupBox1.Controls.Add(this.rbIsti);
            this.groupBox1.Location = new System.Drawing.Point(507, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacijenti";
            // 
            // rbIsti
            // 
            this.rbIsti.AutoSize = true;
            this.rbIsti.Location = new System.Drawing.Point(3, 16);
            this.rbIsti.Name = "rbIsti";
            this.rbIsti.Size = new System.Drawing.Size(88, 17);
            this.rbIsti.TabIndex = 0;
            this.rbIsti.TabStop = true;
            this.rbIsti.Text = "Iz istog grada";
            this.rbIsti.UseVisualStyleBackColor = true;
            // 
            // rbDrugi
            // 
            this.rbDrugi.AutoSize = true;
            this.rbDrugi.Location = new System.Drawing.Point(6, 39);
            this.rbDrugi.Name = "rbDrugi";
            this.rbDrugi.Size = new System.Drawing.Size(107, 17);
            this.rbDrugi.TabIndex = 1;
            this.rbDrugi.TabStop = true;
            this.rbDrugi.Text = "Iz drugih gradova";
            this.rbDrugi.UseVisualStyleBackColor = true;
            // 
            // rbSvi
            // 
            this.rbSvi.AutoSize = true;
            this.rbSvi.Location = new System.Drawing.Point(6, 62);
            this.rbSvi.Name = "rbSvi";
            this.rbSvi.Size = new System.Drawing.Size(40, 17);
            this.rbSvi.TabIndex = 2;
            this.rbSvi.TabStop = true;
            this.rbSvi.Text = "Svi";
            this.rbSvi.UseVisualStyleBackColor = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(657, 25);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(656, 71);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(75, 23);
            this.btnIzadji.TabIndex = 4;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 225);
            this.dataGridView1.TabIndex = 6;
            // 
            // tbOdDat
            // 
            this.tbOdDat.Location = new System.Drawing.Point(109, 12);
            this.tbOdDat.Name = "tbOdDat";
            this.tbOdDat.Size = new System.Drawing.Size(100, 20);
            this.tbOdDat.TabIndex = 7;
            // 
            // tbDoDat
            // 
            this.tbDoDat.Location = new System.Drawing.Point(109, 71);
            this.tbDoDat.Name = "tbDoDat";
            this.tbDoDat.Size = new System.Drawing.Size(100, 20);
            this.tbDoDat.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Od datuma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Do datuma";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(456, 162);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(275, 225);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Statistika_Poliklinike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 406);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDoDat);
            this.Controls.Add(this.tbOdDat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Statistika_Poliklinike";
            this.Text = "Statistika_Poliklinike";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSvi;
        private System.Windows.Forms.RadioButton rbDrugi;
        private System.Windows.Forms.RadioButton rbIsti;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbOdDat;
        private System.Windows.Forms.TextBox tbDoDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
    }
}