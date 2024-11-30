using IFSPStore.App.Cadastros;
using IFSPStore.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCidade>();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroUsuario>();
        }

        private void grupoDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroGrupo>();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroProduto>();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCliente>();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroVenda>();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
