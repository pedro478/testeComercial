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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
            this.AcceptButton = btn_login;
        }

        string login_sisvoo = "TESTE_SISVOO";
        string login_newtechnik = "TESTE_NEWTECHNIK";
        string login_lab = "TESTE_LAB";
        string login_adm = "ADMINISTRADOR";

        string senha_sisvoo = "TESTE_SISVOO";
        string senha_newtechnik = "TESTE_NEWTECHNIK";
        string senha_lab = "TESTE_LAB";
        string senha_adm = "ADMINISTRADOR";

        string usuario_atual = "";
        

        private void Form1_Load(object sender, EventArgs e)
        {


            //define os textbox de login e senha como nulo
            senha_box.Text = "";
            login_box.Text = "";
            // o caracter do senha_box é *
            senha_box.PasswordChar = '*';
            // o maximo de caracteres são 14.
            senha_box.MaxLength = 20;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (senha_box.Text == "" ||  login_box.Text == "")

            {

                errorProvider1.SetError(login_box, "Preencha Todos Os Campos");
                

            }
  
            else if (login_box.Text == login_sisvoo && senha_box.Text == senha_sisvoo )

            {
                usuario_atual = "SISVOO";

                var Form = new dados_pci_form(usuario_atual);
                Form.Show();

              /* classe_dados_placa Dados = new classe_dados_placa();
               Dados.Usuario = usuario_atual;*/

                this.Hide();



            }



            else if (login_box.Text == login_newtechnik && senha_box.Text == senha_newtechnik)

            {

                usuario_atual = "NEWTECHNIK";

                var User = new dados_pci_form(usuario_atual);
                User.Show();

                this.Hide();

            }




            else if (login_box.Text == login_lab && senha_box.Text == senha_lab)

            {

                usuario_atual = "LAB DE PLACAS";

                var User = new dados_pci_form(usuario_atual);
                User.Show();

                this.Hide();

            }


            else if (login_box.Text == login_adm && senha_box.Text == senha_adm)

            {

                usuario_atual = "ADMNISTRADOR";

                var User = new dados_pci_form(usuario_atual);
                User.Show();

                this.Hide();
            }

            else

            {

                MessageBox.Show("LOGIN OU SENHA INVALIDO");

                login_box.Text = "";
                senha_box.Text = "";
                            
            }




        }
    }
}
