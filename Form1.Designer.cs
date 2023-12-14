namespace Tooded_TARpv22
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kat_Box = new System.Windows.Forms.ComboBox();
            this.kat_lbl = new System.Windows.Forms.Label();
            this.Lisa_Kat_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.Kogus_txt = new System.Windows.Forms.TextBox();
            this.Hind_txt = new System.Windows.Forms.TextBox();
            this.Lisa_btn = new System.Windows.Forms.Button();
            this.Uuenda_btn = new System.Windows.Forms.Button();
            this.Kust_btn = new System.Windows.Forms.Button();
            this.kustuta_btn = new System.Windows.Forms.Button();
            this.Toode_pb = new System.Windows.Forms.PictureBox();
            this.otsi_fail_btn = new System.Windows.Forms.Button();
            this.eemalda_btn = new System.Windows.Forms.Button();
            this.Maksta_btn = new System.Windows.Forms.Button();
            this.Makseweb = new System.Windows.Forms.WebBrowser();
            this.Valik_btn = new System.Windows.Forms.Button();
            this.Ostan_btn = new System.Windows.Forms.Button();
            this.SaadaArve_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(102, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Kat_Box
            // 
            this.Kat_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kat_Box.FormattingEnabled = true;
            this.Kat_Box.Location = new System.Drawing.Point(145, 202);
            this.Kat_Box.Name = "Kat_Box";
            this.Kat_Box.Size = new System.Drawing.Size(185, 33);
            this.Kat_Box.TabIndex = 1;
            // 
            // kat_lbl
            // 
            this.kat_lbl.AutoSize = true;
            this.kat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.kat_lbl.Location = new System.Drawing.Point(4, 206);
            this.kat_lbl.Name = "kat_lbl";
            this.kat_lbl.Size = new System.Drawing.Size(135, 26);
            this.kat_lbl.TabIndex = 2;
            this.kat_lbl.Text = "Kategooriad:";
            // 
            // Lisa_Kat_btn
            // 
            this.Lisa_Kat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Lisa_Kat_btn.Location = new System.Drawing.Point(102, 246);
            this.Lisa_Kat_btn.Name = "Lisa_Kat_btn";
            this.Lisa_Kat_btn.Size = new System.Drawing.Size(138, 33);
            this.Lisa_Kat_btn.TabIndex = 3;
            this.Lisa_Kat_btn.Text = "Lisa kategooriat";
            this.Lisa_Kat_btn.UseVisualStyleBackColor = true;
            this.Lisa_Kat_btn.Click += new System.EventHandler(this.Lisa_Kat_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(41, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kogus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(58, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hind:";
            // 
            // Toode_txt
            // 
            this.Toode_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Toode_txt.Location = new System.Drawing.Point(145, 23);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(180, 32);
            this.Toode_txt.TabIndex = 7;
            // 
            // Kogus_txt
            // 
            this.Kogus_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kogus_txt.Location = new System.Drawing.Point(145, 88);
            this.Kogus_txt.Name = "Kogus_txt";
            this.Kogus_txt.Size = new System.Drawing.Size(180, 32);
            this.Kogus_txt.TabIndex = 8;
            // 
            // Hind_txt
            // 
            this.Hind_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Hind_txt.Location = new System.Drawing.Point(145, 141);
            this.Hind_txt.Name = "Hind_txt";
            this.Hind_txt.Size = new System.Drawing.Size(180, 32);
            this.Hind_txt.TabIndex = 9;
            // 
            // Lisa_btn
            // 
            this.Lisa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Lisa_btn.Location = new System.Drawing.Point(102, 285);
            this.Lisa_btn.Name = "Lisa_btn";
            this.Lisa_btn.Size = new System.Drawing.Size(75, 23);
            this.Lisa_btn.TabIndex = 10;
            this.Lisa_btn.Text = "Lisa";
            this.Lisa_btn.UseVisualStyleBackColor = true;
            this.Lisa_btn.Click += new System.EventHandler(this.Lisa_btn_Click);
            // 
            // Uuenda_btn
            // 
            this.Uuenda_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Uuenda_btn.Location = new System.Drawing.Point(183, 285);
            this.Uuenda_btn.Name = "Uuenda_btn";
            this.Uuenda_btn.Size = new System.Drawing.Size(75, 23);
            this.Uuenda_btn.TabIndex = 11;
            this.Uuenda_btn.Text = "Uuenda";
            this.Uuenda_btn.UseVisualStyleBackColor = true;
            this.Uuenda_btn.Click += new System.EventHandler(this.Uuenda_btn_Click);
            // 
            // Kust_btn
            // 
            this.Kust_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Kust_btn.Location = new System.Drawing.Point(264, 285);
            this.Kust_btn.Name = "Kust_btn";
            this.Kust_btn.Size = new System.Drawing.Size(75, 23);
            this.Kust_btn.TabIndex = 12;
            this.Kust_btn.Text = "Kustuta";
            this.Kust_btn.UseVisualStyleBackColor = true;
            this.Kust_btn.Click += new System.EventHandler(this.Kust_btn_Click);
            // 
            // kustuta_btn
            // 
            this.kustuta_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.kustuta_btn.Location = new System.Drawing.Point(246, 246);
            this.kustuta_btn.Name = "kustuta_btn";
            this.kustuta_btn.Size = new System.Drawing.Size(142, 33);
            this.kustuta_btn.TabIndex = 13;
            this.kustuta_btn.Text = "Kustuta kategooriat";
            this.kustuta_btn.UseVisualStyleBackColor = true;
            this.kustuta_btn.Click += new System.EventHandler(this.kustuta_btn_Click);
            // 
            // Toode_pb
            // 
            this.Toode_pb.Location = new System.Drawing.Point(446, 23);
            this.Toode_pb.Name = "Toode_pb";
            this.Toode_pb.Size = new System.Drawing.Size(382, 223);
            this.Toode_pb.TabIndex = 14;
            this.Toode_pb.TabStop = false;
            // 
            // otsi_fail_btn
            // 
            this.otsi_fail_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.otsi_fail_btn.Location = new System.Drawing.Point(446, 255);
            this.otsi_fail_btn.Name = "otsi_fail_btn";
            this.otsi_fail_btn.Size = new System.Drawing.Size(90, 24);
            this.otsi_fail_btn.TabIndex = 15;
            this.otsi_fail_btn.Text = "Otsi fail";
            this.otsi_fail_btn.UseVisualStyleBackColor = true;
            this.otsi_fail_btn.Click += new System.EventHandler(this.otsi_fail_btn_Click);
            // 
            // eemalda_btn
            // 
            this.eemalda_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.eemalda_btn.Location = new System.Drawing.Point(345, 285);
            this.eemalda_btn.Name = "eemalda_btn";
            this.eemalda_btn.Size = new System.Drawing.Size(75, 23);
            this.eemalda_btn.TabIndex = 16;
            this.eemalda_btn.Text = "Eemalda";
            this.eemalda_btn.UseVisualStyleBackColor = true;
            this.eemalda_btn.Click += new System.EventHandler(this.eemalda_btn_Click);
            // 
            // Maksta_btn
            // 
            this.Maksta_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Maksta_btn.Location = new System.Drawing.Point(446, 285);
            this.Maksta_btn.Name = "Maksta_btn";
            this.Maksta_btn.Size = new System.Drawing.Size(75, 23);
            this.Maksta_btn.TabIndex = 17;
            this.Maksta_btn.Text = "Maksta";
            this.Maksta_btn.UseVisualStyleBackColor = true;
            // 
            // Makseweb
            // 
            this.Makseweb.Location = new System.Drawing.Point(872, 29);
            this.Makseweb.MinimumSize = new System.Drawing.Size(20, 20);
            this.Makseweb.Name = "Makseweb";
            this.Makseweb.Size = new System.Drawing.Size(478, 521);
            this.Makseweb.TabIndex = 18;
            this.Makseweb.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Valik_btn
            // 
            this.Valik_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Valik_btn.Location = new System.Drawing.Point(571, 256);
            this.Valik_btn.Name = "Valik_btn";
            this.Valik_btn.Size = new System.Drawing.Size(75, 23);
            this.Valik_btn.TabIndex = 19;
            this.Valik_btn.Text = "Valin";
            this.Valik_btn.UseVisualStyleBackColor = true;
            this.Valik_btn.Click += new System.EventHandler(this.Valik_btn_Click);
            // 
            // Ostan_btn
            // 
            this.Ostan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Ostan_btn.Location = new System.Drawing.Point(652, 256);
            this.Ostan_btn.Name = "Ostan_btn";
            this.Ostan_btn.Size = new System.Drawing.Size(75, 23);
            this.Ostan_btn.TabIndex = 20;
            this.Ostan_btn.Text = "Ostan";
            this.Ostan_btn.UseVisualStyleBackColor = true;
            this.Ostan_btn.Click += new System.EventHandler(this.Ostan_btn_Click);
            // 
            // SaadaArve_btn
            // 
            this.SaadaArve_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SaadaArve_btn.Location = new System.Drawing.Point(733, 255);
            this.SaadaArve_btn.Name = "SaadaArve_btn";
            this.SaadaArve_btn.Size = new System.Drawing.Size(95, 24);
            this.SaadaArve_btn.TabIndex = 21;
            this.SaadaArve_btn.Text = "Saada arve";
            this.SaadaArve_btn.UseVisualStyleBackColor = true;
            this.SaadaArve_btn.Click += new System.EventHandler(this.SaadaArve_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 556);
            this.Controls.Add(this.SaadaArve_btn);
            this.Controls.Add(this.Ostan_btn);
            this.Controls.Add(this.Valik_btn);
            this.Controls.Add(this.Makseweb);
            this.Controls.Add(this.Maksta_btn);
            this.Controls.Add(this.eemalda_btn);
            this.Controls.Add(this.otsi_fail_btn);
            this.Controls.Add(this.Toode_pb);
            this.Controls.Add(this.kustuta_btn);
            this.Controls.Add(this.Kust_btn);
            this.Controls.Add(this.Uuenda_btn);
            this.Controls.Add(this.Lisa_btn);
            this.Controls.Add(this.Hind_txt);
            this.Controls.Add(this.Kogus_txt);
            this.Controls.Add(this.Toode_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lisa_Kat_btn);
            this.Controls.Add(this.kat_lbl);
            this.Controls.Add(this.Kat_Box);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Minu Epood";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Kat_Box;
        private System.Windows.Forms.Label kat_lbl;
        private System.Windows.Forms.Button Lisa_Kat_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.TextBox Kogus_txt;
        private System.Windows.Forms.TextBox Hind_txt;
        private System.Windows.Forms.Button Lisa_btn;
        private System.Windows.Forms.Button Uuenda_btn;
        private System.Windows.Forms.Button Kust_btn;
        private System.Windows.Forms.Button kustuta_btn;
        private System.Windows.Forms.PictureBox Toode_pb;
        private System.Windows.Forms.Button otsi_fail_btn;
        private System.Windows.Forms.Button eemalda_btn;
        private System.Windows.Forms.Button Maksta_btn;
        private System.Windows.Forms.WebBrowser Makseweb;
        private System.Windows.Forms.Button Valik_btn;
        private System.Windows.Forms.Button Ostan_btn;
        private System.Windows.Forms.Button SaadaArve_btn;
    }
}

