using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {

        StreamReader leitura = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void eDITAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NovoArquivo()
        {
            //LIMPAR A CAIXA DE TEXTO E COLOCAR O CURSOR
            richTextBox1.Clear();
            richTextBox1.Focus();
        }
        
        //CHAMANDO A FUNÇÃO NOVO NO BOTÃO
        private void Novo_Click(object sender, EventArgs e)
        {
            NovoArquivo();
        }

        //FUNÇÃO SALVAR
        private void SalvarArquivo()
        {
            try
            {
                // FAZ A CHAMADA DA JANELA DE SALVAR O ARQUIVO
                //E SE ESTIVER TUDO CERTO, VAI SALVAR
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter escrita = new StreamWriter(arquivo);
                    escrita.Flush();
                    //COMEÇA A SALVAR DO INICIO
                    escrita.BaseStream.Seek(0, SeekOrigin.Begin);
                    escrita.Write(this.richTextBox1.Text);
                    escrita.Flush();
                    escrita.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"NÃO FOI POSSÍVEL SALVAR O ARQUIVO. {ex.Message} \"Erro ao salvar o arquivo.\" {MessageBoxButtons.OK} {MessageBoxIcon.Error}");
            }
        }

        //BOTÃO SALVAR
        private void Salvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }


        //FUNÇÃO ABRIR AERQUIVO
        private void AbrirArquivo()
        {
            // NÃO SERÁ POSSÍVEL ABRIR VÁRIOS ARQUIVOS
            this.openFileDialog1.Multiselect = false;

            this.openFileDialog1.Title = "ABRIR ARQUIVO";
            openFileDialog1.InitialDirectory = @"C:\\Anotação Programação\";
            
            // ARQUIVOS QUE PODEM SER ABERTOS
            openFileDialog1.Filter = "(*.TXT)|*.TXT";

            DialogResult dialogResult = this.openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK) 
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                    StreamReader LerArquivo = new StreamReader(arquivo);
                    LerArquivo.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = LerArquivo.ReadLine();
                    
                    while (linha != null )
                    {
                        this.richTextBox1.Text = linha + "\n";
                        this.richTextBox1.Text += $@"{linha}";
                        linha = LerArquivo.ReadLine();
                    }

                    LerArquivo.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"NÃO FOI POSSÍVEL ABRIR O ARQUIVO. {ex.Message} {MessageBoxButtons.OK} {MessageBoxIcon.Error}");
                }
            }
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            AbrirArquivo();
        }

        private void CopiarArquivo()
        {
            // SE TEM CONTEÚDO MAIOR QUE ZERO VAI COPIAR
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            CopiarArquivo();
        }

        private void ColarArquivo()
        {
            richTextBox1.Paste();
        }

        private void Colar_Click(object sender, EventArgs e)
        {
            ColarArquivo();
        }

        private void ArquivoNegrito()
        {
            string NomeFonte = null;
            float TamanhoFonte = 0;
            bool Negrito = false;
            
            NomeFonte = richTextBox1.Font.Name;
            TamanhoFonte = richTextBox1.Font.Size;
            Negrito = richTextBox1.Font.Bold;

            if (Negrito == false)
            {
                richTextBox1.SelectionFont = new  Font(NomeFonte, TamanhoFonte, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Regular);
            }
        }

        private void Negrito_Click(object sender, EventArgs e)
        {
            ArquivoNegrito();
        }

        private void ArquivoItalico()
        {
            string NomeFonte = null;
            float TamanhoFonte = 0;
            bool Italico = false;

            NomeFonte = richTextBox1.Font.Name;
            TamanhoFonte = richTextBox1.Font.Size;
            Italico = richTextBox1.Font.Italic;

            if (Italico == false)
            {
                richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Italic);
            }
        }

        private void Italico_Click(object sender, EventArgs e)
        {
            ArquivoItalico();
        }
        
        private void ArquivoSublinhado()
        {
            string NomeFonte = null;
            float TamanhoFonte = 0;
            bool Sublinhado = false;

            NomeFonte = richTextBox1.Font.Name;
            TamanhoFonte = richTextBox1.Font.Size;
            Sublinhado = richTextBox1.Font.Underline;

            if (Sublinhado == false)
            {
                richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Underline);
            }
        }

        private void Sublinhado_Click(object sender, EventArgs e)
        {
            ArquivoSublinhado();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
