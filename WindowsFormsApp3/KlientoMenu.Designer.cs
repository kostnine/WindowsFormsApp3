namespace WindowsFormsApp3
{
    partial class KlientoMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ID_Filmas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pavadinimas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Reziserius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trukme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Kalba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amzius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Studija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID_Seanso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filmas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laikas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pritaikimo_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "KA KinoTeatras";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 100);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tapti klubo nariu!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Filmas,
            this.Pavadinimas,
            this.Metai,
            this.ID_Reziserius,
            this.Trukme,
            this.ID_Kalba,
            this.Amzius,
            this.ID_Studija});
            this.dataGridView1.Location = new System.Drawing.Point(274, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 251);
            this.dataGridView1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Pritaikyti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID_Filmas
            // 
            this.ID_Filmas.DataPropertyName = "ID_Filmas";
            this.ID_Filmas.HeaderText = "Column1";
            this.ID_Filmas.Name = "ID_Filmas";
            this.ID_Filmas.Visible = false;
            // 
            // Pavadinimas
            // 
            this.Pavadinimas.DataPropertyName = "Pavadinimas";
            this.Pavadinimas.HeaderText = "Filmo Pavadinimas";
            this.Pavadinimas.Name = "Pavadinimas";
            // 
            // Metai
            // 
            this.Metai.DataPropertyName = "Metai";
            this.Metai.HeaderText = "Metai";
            this.Metai.Name = "Metai";
            // 
            // ID_Reziserius
            // 
            this.ID_Reziserius.DataPropertyName = "ID_Reziserius";
            this.ID_Reziserius.HeaderText = "Reziserius";
            this.ID_Reziserius.Name = "ID_Reziserius";
            this.ID_Reziserius.Visible = false;
            // 
            // Trukme
            // 
            this.Trukme.DataPropertyName = "Trukme";
            this.Trukme.HeaderText = "Trukme";
            this.Trukme.Name = "Trukme";
            // 
            // ID_Kalba
            // 
            this.ID_Kalba.DataPropertyName = "ID_Kalba";
            this.ID_Kalba.HeaderText = "Kalba";
            this.ID_Kalba.Name = "ID_Kalba";
            // 
            // Amzius
            // 
            this.Amzius.DataPropertyName = "Amzio Cenzas";
            this.Amzius.HeaderText = "Amzius";
            this.Amzius.Name = "Amzius";
            // 
            // ID_Studija
            // 
            this.ID_Studija.DataPropertyName = "ID_Studija";
            this.ID_Studija.HeaderText = "Studija";
            this.ID_Studija.Name = "ID_Studija";
            this.ID_Studija.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtruoti pagal leidimo metus:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(274, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "Paziureti seansus!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Seanso,
            this.Filmas,
            this.Sales_nr,
            this.Laikas,
            this.Data,
            this.Pritaikimo_ID});
            this.dataGridView2.Location = new System.Drawing.Point(157, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(492, 251);
            this.dataGridView2.TabIndex = 8;
            // 
            // ID_Seanso
            // 
            this.ID_Seanso.DataPropertyName = "ID_Seanso";
            this.ID_Seanso.HeaderText = "ID_Seanso";
            this.ID_Seanso.Name = "ID_Seanso";
            this.ID_Seanso.Visible = false;
            // 
            // Filmas
            // 
            this.Filmas.DataPropertyName = "ID_Filmas";
            this.Filmas.HeaderText = "Filmas";
            this.Filmas.Name = "Filmas";
            // 
            // Sales_nr
            // 
            this.Sales_nr.DataPropertyName = "Sales_nr";
            this.Sales_nr.HeaderText = "Sale";
            this.Sales_nr.Name = "Sales_nr";
            // 
            // Laikas
            // 
            this.Laikas.DataPropertyName = "Laikas";
            this.Laikas.HeaderText = "Laikas";
            this.Laikas.Name = "Laikas";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Pritaikimo_ID
            // 
            this.Pritaikimo_ID.DataPropertyName = "Pritaikimo_ID";
            this.Pritaikimo_ID.HeaderText = "Pritaikimas";
            this.Pritaikimo_ID.Name = "Pritaikimo_ID";
            this.Pritaikimo_ID.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 29);
            this.button4.TabIndex = 9;
            this.button4.Text = "Pirkti biletus!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // KlientoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KlientoMenu";
            this.Text = "KlientoMenu";
            this.Load += new System.EventHandler(this.KlientoMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Filmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pavadinimas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Reziserius;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trukme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Kalba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amzius;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Studija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Seanso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laikas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pritaikimo_ID;
        private System.Windows.Forms.Button button4;
    }
}