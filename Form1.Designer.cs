namespace TorrediHanoi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_ya = new System.Windows.Forms.Panel();
            this.pnl_yb = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_yc = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_dischi = new System.Windows.Forms.NumericUpDown();
            this.btn_invio = new System.Windows.Forms.Button();
            this.lst_passaggi = new System.Windows.Forms.ListBox();
            this.btn_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_dischi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(81, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 12);
            this.panel1.TabIndex = 0;
            // 
            // pnl_ya
            // 
            this.pnl_ya.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_ya.Location = new System.Drawing.Point(152, 60);
            this.pnl_ya.Name = "pnl_ya";
            this.pnl_ya.Size = new System.Drawing.Size(13, 319);
            this.pnl_ya.TabIndex = 1;
            // 
            // pnl_yb
            // 
            this.pnl_yb.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_yb.Location = new System.Drawing.Point(318, 60);
            this.pnl_yb.Name = "pnl_yb";
            this.pnl_yb.Size = new System.Drawing.Size(13, 319);
            this.pnl_yb.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Location = new System.Drawing.Point(247, 367);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 12);
            this.panel4.TabIndex = 2;
            // 
            // pnl_yc
            // 
            this.pnl_yc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_yc.Location = new System.Drawing.Point(485, 60);
            this.pnl_yc.Name = "pnl_yc";
            this.pnl_yc.Size = new System.Drawing.Size(13, 319);
            this.pnl_yc.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Location = new System.Drawing.Point(414, 367);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(156, 12);
            this.panel6.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "C";
            // 
            // num_dischi
            // 
            this.num_dischi.Location = new System.Drawing.Point(607, 78);
            this.num_dischi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_dischi.Name = "num_dischi";
            this.num_dischi.Size = new System.Drawing.Size(164, 26);
            this.num_dischi.TabIndex = 7;
            this.num_dischi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_invio
            // 
            this.btn_invio.Location = new System.Drawing.Point(607, 110);
            this.btn_invio.Name = "btn_invio";
            this.btn_invio.Size = new System.Drawing.Size(162, 55);
            this.btn_invio.TabIndex = 8;
            this.btn_invio.Text = "submit";
            this.btn_invio.UseVisualStyleBackColor = true;
            this.btn_invio.Click += new System.EventHandler(this.btn_invio_Click_1);
            // 
            // lst_passaggi
            // 
            this.lst_passaggi.FormattingEnabled = true;
            this.lst_passaggi.ItemHeight = 20;
            this.lst_passaggi.Location = new System.Drawing.Point(607, 266);
            this.lst_passaggi.Name = "lst_passaggi";
            this.lst_passaggi.Size = new System.Drawing.Size(162, 144);
            this.lst_passaggi.TabIndex = 10;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(607, 187);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(162, 55);
            this.btn_start.TabIndex = 11;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lst_passaggi);
            this.Controls.Add(this.btn_invio);
            this.Controls.Add(this.num_dischi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_yc);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pnl_yb);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_ya);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Torre di Hannoi";
            ((System.ComponentModel.ISupportInitialize)(this.num_dischi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_ya;
        private System.Windows.Forms.Panel pnl_yb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnl_yc;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_dischi;
        private System.Windows.Forms.Button btn_invio;
        private System.Windows.Forms.ListBox lst_passaggi;
        private System.Windows.Forms.Button btn_start;
    }
}

