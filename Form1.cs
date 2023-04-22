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
    public partial class FrmPrincipal : Form
    {
        float n1, n2, n3, n4, media;

        public FrmPrincipal(string categoriaPessoa)
        {
            InitializeComponent();

            lblPessoa.Text = categoriaPessoa;

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            mediaAluno();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dtDate.Text = DateTime.Today.ToString();
            Pessoa pessoa = new Pessoa();
            lblNome.Text = Program.usuario; 
        }

        public void resultado()
        {
            n1 = float.Parse(txtNota1.Text);
            n2 = float.Parse(txtNota2.Text);
            n3 = float.Parse(txtNota3.Text);
            n4 = float.Parse(txtNota4.Text);

            media = (n1 + n2 + n3 + n4) / 4;

            lblMedia.Text = media.ToString();
        }
        public void mediaAluno()
        {
            if (media < 7)
            {
                lblStatus.Text = "Reprovado!";
            }
            else if(media == 7)
            {
                lblStatus.Text = "Aprovado com o minimo!";
            }
            else if(media > 7)
            {
                lblStatus.Text = "Aprovado acima da media, Parabens!";
            }
        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            resultado();
           
        }
    }
}
