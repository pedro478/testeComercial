namespace TESTE_LINHA_COMERCIAL
{
    partial class tela_teste_p5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_teste_p5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ip_host = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serie_label = new System.Windows.Forms.Label();
            this.usuario_label = new System.Windows.Forms.Label();
            this.codigo_label = new System.Windows.Forms.Label();
            this.conection_panel = new System.Windows.Forms.Panel();
            this.conection_status_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.conection_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.conection_panel);
            this.panel1.Controls.Add(this.btn_desconectar);
            this.panel1.Controls.Add(this.btn_conectar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.port_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ip_host);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 97);
            this.panel1.TabIndex = 2;
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_desconectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_desconectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_desconectar.Location = new System.Drawing.Point(490, 67);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(71, 20);
            this.btn_desconectar.TabIndex = 10;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = false;
            this.btn_desconectar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_conectar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_conectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_conectar.Location = new System.Drawing.Point(430, 67);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(54, 20);
            this.btn_conectar.TabIndex = 9;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = false;
            this.btn_conectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(364, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(44, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "PRIX5 LC";
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(367, 67);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(57, 20);
            this.port_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(364, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP/ Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Linha Comercial";
            // 
            // ip_host
            // 
            this.ip_host.Location = new System.Drawing.Point(367, 27);
            this.ip_host.Name = "ip_host";
            this.ip_host.Size = new System.Drawing.Size(166, 20);
            this.ip_host.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.codigo_label);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.serie_label);
            this.panel2.Controls.Add(this.usuario_label);
            this.panel2.Location = new System.Drawing.Point(1, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 401);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(83, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Engenharia Industrial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(14, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dados da PCI";
            // 
            // serie_label
            // 
            this.serie_label.AutoSize = true;
            this.serie_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serie_label.Location = new System.Drawing.Point(3, 80);
            this.serie_label.Name = "serie_label";
            this.serie_label.Size = new System.Drawing.Size(96, 20);
            this.serie_label.TabIndex = 11;
            this.serie_label.Text = "serie_label";
            // 
            // usuario_label
            // 
            this.usuario_label.AutoSize = true;
            this.usuario_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_label.Location = new System.Drawing.Point(2, 50);
            this.usuario_label.Name = "usuario_label";
            this.usuario_label.Size = new System.Drawing.Size(116, 20);
            this.usuario_label.TabIndex = 12;
            this.usuario_label.Text = "usuario_label";
            this.usuario_label.Click += new System.EventHandler(this.usuario_label_Click);
            // 
            // codigo_label
            // 
            this.codigo_label.AutoSize = true;
            this.codigo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigo_label.Location = new System.Drawing.Point(3, 109);
            this.codigo_label.Name = "codigo_label";
            this.codigo_label.Size = new System.Drawing.Size(110, 20);
            this.codigo_label.TabIndex = 15;
            this.codigo_label.Text = "codigo_label";
            // 
            // conection_panel
            // 
            this.conection_panel.Controls.Add(this.conection_status_label);
            this.conection_panel.Location = new System.Drawing.Point(573, 27);
            this.conection_panel.Name = "conection_panel";
            this.conection_panel.Size = new System.Drawing.Size(143, 60);
            this.conection_panel.TabIndex = 16;
            // 
            // conection_status_label
            // 
            this.conection_status_label.AutoSize = true;
            this.conection_status_label.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conection_status_label.Location = new System.Drawing.Point(3, 22);
            this.conection_status_label.Name = "conection_status_label";
            this.conection_status_label.Size = new System.Drawing.Size(43, 15);
            this.conection_status_label.TabIndex = 0;
            this.conection_status_label.Text = "label7";
            // 
            // tela_teste_p5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(729, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_teste_p5";
            this.Text = "Software de teste - Linha Comercial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tela_teste_p5_FormClosed);
            this.Load += new System.EventHandler(this.tela_teste_p5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.conection_panel.ResumeLayout(false);
            this.conection_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.TextBox ip_host;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label usuario_label;
        private System.Windows.Forms.Label serie_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel conection_panel;
        private System.Windows.Forms.Label codigo_label;
        private System.Windows.Forms.Label conection_status_label;
    }
}