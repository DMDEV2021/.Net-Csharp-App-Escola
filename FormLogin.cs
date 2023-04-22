using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAlunoApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void login_senha()
        {
            if (txtUsuario.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Digite seu usuário");
                return;
            }
            if (txtSenha.Text != "123")
            {
                MessageBox.Show("Senha inválida");
                return;
            }
        }
        private void CategoriaPessoa()
        {
            if (comboBoxLog.Text == "Aluno(ª)")
            {
                FrmPrincipal frm = new FrmPrincipal(comboBoxLog.Text);

                frm.ShowDialog();
            }
            else if (comboBoxLog.Text == "Professor(ª)" || comboBoxLog.Text == "Direção")
            {
                FrmProf frmProf = new FrmProf();
                frmProf.ShowDialog();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_senha();

            Pessoa pessoa = new Pessoa();
            Program.usuario = pessoa.PrimeiraLetraMaiuscula(txtUsuario.Text);

            CategoriaPessoa();   
            
            this.Close();

        }

       
    }
}
