namespace TESTE_LINHA_COMERCIAL
{
    partial class dados_pci_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dados_pci_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_linha = new System.Windows.Forms.Label();
            this.produto_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codigo_list = new System.Windows.Forms.ComboBox();
            this.serie_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gravar_bnt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_usuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_linha);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 97);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(14, 39);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(54, 13);
            this.label_usuario.TabIndex = 4;
            this.label_usuario.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label_linha
            // 
            this.label_linha.AutoSize = true;
            this.label_linha.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F);
            this.label_linha.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_linha.Location = new System.Drawing.Point(14, 9);
            this.label_linha.Name = "label_linha";
            this.label_linha.Size = new System.Drawing.Size(182, 30);
            this.label_linha.TabIndex = 2;
            this.label_linha.Text = "Linha Comercial";
            // 
            // produto_list
            // 
            this.produto_list.FormattingEnabled = true;
            this.produto_list.Location = new System.Drawing.Point(132, 152);
            this.produto_list.Name = "produto_list";
            this.produto_list.Size = new System.Drawing.Size(121, 21);
            this.produto_list.TabIndex = 2;
            this.produto_list.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(129, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(129, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código PCI";
            // 
            // codigo_list
            // 
            this.codigo_list.FormattingEnabled = true;
            this.codigo_list.Location = new System.Drawing.Point(132, 225);
            this.codigo_list.Name = "codigo_list";
            this.codigo_list.Size = new System.Drawing.Size(121, 21);
            this.codigo_list.TabIndex = 4;
            // 
            // serie_box
            // 
            this.serie_box.Location = new System.Drawing.Point(132, 293);
            this.serie_box.Name = "serie_box";
            this.serie_box.Size = new System.Drawing.Size(121, 20);
            this.serie_box.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(129, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Série";
            // 
            // gravar_bnt
            // 
            this.gravar_bnt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gravar_bnt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gravar_bnt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gravar_bnt.Location = new System.Drawing.Point(148, 345);
            this.gravar_bnt.Name = "gravar_bnt";
            this.gravar_bnt.Size = new System.Drawing.Size(87, 27);
            this.gravar_bnt.TabIndex = 8;
            this.gravar_bnt.Text = "Gravar";
            this.gravar_bnt.UseVisualStyleBackColor = false;
            this.gravar_bnt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(246, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Engenharia Industrial";
            // 
            // dados_pci_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(371, 384);
            this.Controls.Add(this.gravar_bnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serie_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codigo_list);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.produto_list);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dados_pci_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software de teste - Linha Comercial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.tela_inicial_form_FormClosed);
            this.Load += new System.EventHandler(this.tela_inicial_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_linha;
        private System.Windows.Forms.ComboBox produto_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox codigo_list;
        private System.Windows.Forms.TextBox serie_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gravar_bnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.Label label5;
    }
}