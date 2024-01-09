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
using System.Windows.Forms.VisualStyles;

namespace EditorDeTexto
{
    public partial class Form1 : Form
    {

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
            bool Negrito, italico, sublinhado = false;
            
            NomeFonte = richTextBox1.Font.Name;
            TamanhoFonte = richTextBox1.Font.Size;
            Negrito = richTextBox1.SelectionFont.Bold;
            italico = richTextBox1.SelectionFont.Italic;
            sublinhado = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Regular);

            if (Negrito == false)
            {
                if(italico == true & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (italico == true & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (italico == false & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (italico == false & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold);
                }

            }
            else
            {
                if (italico == true & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (italico == true & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Italic);
                }
                else if (italico == false & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Underline);
                }
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
            bool Negrito, italico, sublinhado = false;

            NomeFonte = richTextBox1.Font.Name;
            TamanhoFonte = richTextBox1.Font.Size;
            Negrito = richTextBox1.SelectionFont.Bold;
            italico = richTextBox1.SelectionFont.Italic;
            sublinhado = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Regular);

            if (italico == false)
            {
                if (Negrito == true & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (Negrito == true & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (Negrito == false & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (Negrito == false & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Italic);
                }
            }
            else
            {
                if (Negrito == true & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (Negrito == true & sublinhado == false)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold);
                }
                else if (Negrito == false & sublinhado == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Underline);
                }
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
            bool Negrito, italico, sublinhado = false;

            NomeFonte = richTextBox1.Font.Name;
            TamanhoFonte = richTextBox1.Font.Size;
            Negrito = richTextBox1.SelectionFont.Bold;
            italico = richTextBox1.SelectionFont.Italic;
            sublinhado = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Regular);

            if (sublinhado == false)
            {
                if (Negrito == true & italico == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (Negrito == true & italico == false)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (Negrito == false & italico == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (Negrito == false & italico == false)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Underline);
                }
            }
            else
            {
                if (Negrito == true & italico == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (Negrito == true & italico == false)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Bold);
                }
                else if (Negrito == false & italico == true)
                {
                    richTextBox1.SelectionFont = new Font(NomeFonte, TamanhoFonte, FontStyle.Italic);
                }
            }
        }
 

        private void Sublinhado_Click(object sender, EventArgs e)
        {
            ArquivoSublinhado();
        }

        // ALINHAMENTO DO TEXTO

        private void AlinharTextoEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void Esquerda_Click(object sender, EventArgs e)
        {
            AlinharTextoEsquerda();
        }
        
        private void AlinharTextoDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Direita_Click(object sender, EventArgs e)
        {
            AlinharTextoDireita();
        }
        
        private void AlinharTextoCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        
        private void Centralizado_Click(object sender, EventArgs e)
        {
            AlinharTextoCentro();
        }


        StringReader leitura = null;
        // IMPRESSÃO DO TEXTO
        private void Imprimir()
        {
            printDialog1.Document = printDocument1;

            // TRAZENDO O TEXTO DA CAIXA DE TEXTO PARA A VARIAVEL
            string imprimirTexto = this.richTextBox1.Text;
            leitura = new StringReader(imprimirTexto);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        // ROTINA DE IMPRESSÃO
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhaPagina = 0;
            float posicaoY = 0;
            int contador = 0;

            // MARGEM
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;

            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }

            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            string linha = null;
            // PASSANDO A INFORMAÇÃO DA FONTE E DA COR
            Font font = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
