using System;
using System.IO;
using System.Windows.Forms;

namespace CriadorDeSnnipet
{
    public partial class frmCriar : Form
    {
        public frmCriar()
        {
            InitializeComponent();
        }
        string nomeArquivo = null;
        private void frmCriar_Load(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                CodeSnnipet code = new CodeSnnipet();
                code.Autor = txtAutor.Text;
                code.Atalho = txtAtalho.Text;
                code.Descricao = txtDescricao.Text;
                code.Titulo = txtTitulo.Text;
                code.Codigo = txtCodigo.Text;
                string snnipet = code.CriarSnnipet().Contains("'") ? code.CriarSnnipet().Replace("'", "\"") : code.CriarSnnipet();
                if (snnipet != "")
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {

                        sfd.Filter = "snippet files (*.snippet)|*.snippet";
                        sfd.FilterIndex = 2;
                        sfd.AddExtension = false;
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            string mike = null;
                            if (sfd.FileName.Contains(".txt"))
                            {
                                mike = sfd.FileName.Replace(".txt", ".snippet");
                            }

                            File.WriteAllText(mike != null ? mike : sfd.FileName, snnipet);
                            ZerarTxt();
                        }
                    }
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }

        }

        private void ZerarTxt()
        {
            txtAutor.Text = string.Empty;
            txtAtalho.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtTitulo.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            MessageBox.Show("Code Snnipet criado com sucesso!");
        }

        private void txtAtalho_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

    }
}
