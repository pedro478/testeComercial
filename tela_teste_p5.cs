using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;


namespace TESTE_LINHA_COMERCIAL
{
    public partial class tela_teste_p5 : Form


    {


        string serie = "";
        string fornecedor = "";

        public tela_teste_p5(string serie_user)
        {
            InitializeComponent();


            conection_panel.BackColor = Color.DarkRed;
            conection_status_label.Location = new Point(3, 22);
            conection_status_label.Text = "PCI NÃO CONECTADA";
            btn_desconectar.Enabled = false;

          /*  string pass = serie_user;

            string[] dados_placa_fornecedor = pass.Split('-');

            serie = dados_placa_fornecedor[0];
            fornecedor = dados_placa_fornecedor[1];

            serie_label.Text = "Numero de Série:" + serie;
            usuario_label.Text = "Usuario:" + fornecedor;*/

        }
            
        



        private void tela_teste_p5_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void tela_teste_p5_Load(object sender, EventArgs e)

        {
           /* classe_dados_placa Dados = new classe_dados_placa();
            usuario_label.Text = Dados.Usuario;*/
        }

        private void usuario_label_Click(object sender, EventArgs e)
        {

        }



        


        private void button1_Click(object sender, EventArgs e)
        {

     

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }
      



    }
}
