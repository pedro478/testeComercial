using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_LINHA_COMERCIAL
{
    public partial class dados_pci_form : Form

    {

        string serie_user = "";
        string fornecedor = "";




        public dados_pci_form(string new_user)
        {
            InitializeComponent();
            label2.Text = new_user;
            fornecedor = new_user;


        }




        private void tela_inicial_form_Load(object sender, EventArgs e)
        {
            //classe_dados_placa Dados2 = new classe_dados_placa();
            //label2.Text = Dados2.Usuario;
            

            produto_list.DropDownStyle = ComboBoxStyle.DropDownList;
            codigo_list.DropDownStyle = ComboBoxStyle.DropDownList;

            produto_list.Items.Add("PRIX5 LC");
            produto_list.Items.Add("PRIX4 DUE NOVA");



        }

        private void tela_inicial_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (produto_list.SelectedItem == "PRIX5 LC")

            {

                codigo_list.Items.Add("6213062");
                codigo_list.Items.Remove("6214737");

            }

            else if (produto_list.SelectedItem == "PRIX4 DUE NOVA")

            {

                codigo_list.Items.Add("6214737");
                codigo_list.Items.Remove("6213062");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if ( produto_list.SelectedIndex == -1 || codigo_list.SelectedIndex == -1 || serie_box.Text == "")

            {

                MessageBox.Show("SELECIONE TODOS OS CAMPOS");
            }

            else if ( produto_list.SelectedItem == "PRIX5 LC" )

            {
                
                serie_user = serie_box.Text + "-" +  fornecedor;


               
                var Form = new tela_teste_p5(serie_user);
                Form.Show();

                this.Hide();


            }

            else if (produto_list.SelectedItem == "PRIX4 DUE NOVA")

            {
                
                serie_user = serie_box.Text + fornecedor;

                var Form = new tela_teste_p5(serie_user);
                Form.Show();

                this.Hide();
                
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

