namespace EditorDeTexto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Novo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Abrir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Copiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Negrito = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Italico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Sublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Justificado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.Centralizado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.Esquerda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.Direita = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.impressao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(172, 86);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(693, 461);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Novo,
            this.toolStripSeparator1,
            this.Abrir,
            this.toolStripSeparator2,
            this.Copiar,
            this.toolStripSeparator4,
            this.Colar,
            this.toolStripSeparator5,
            this.Negrito,
            this.toolStripSeparator6,
            this.Italico,
            this.toolStripSeparator7,
            this.Sublinhado,
            this.toolStripSeparator8,
            this.Justificado,
            this.toolStripSeparator9,
            this.Centralizado,
            this.toolStripSeparator10,
            this.Esquerda,
            this.toolStripSeparator11,
            this.Direita,
            this.toolStripSeparator12,
            this.impressao});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(41, 663);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Novo
            // 
            this.Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Novo.Image = ((System.Drawing.Image)(resources.GetObject("Novo.Image")));
            this.Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(36, 24);
            this.Novo.Text = "btn_novo";
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(36, 6);
            // 
            // Abrir
            // 
            this.Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Abrir.Image")));
            this.Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(36, 24);
            this.Abrir.Text = "btn_abrir";
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(36, 6);
            // 
            // Copiar
            // 
            this.Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Copiar.Image = ((System.Drawing.Image)(resources.GetObject("Copiar.Image")));
            this.Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Copiar.Name = "Copiar";
            this.Copiar.Size = new System.Drawing.Size(36, 24);
            this.Copiar.Text = "btn_copiar";
            this.Copiar.Click += new System.EventHandler(this.Copiar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(36, 6);
            // 
            // Colar
            // 
            this.Colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Colar.Image = ((System.Drawing.Image)(resources.GetObject("Colar.Image")));
            this.Colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Colar.Name = "Colar";
            this.Colar.Size = new System.Drawing.Size(36, 24);
            this.Colar.Text = "btn_colar";
            this.Colar.Click += new System.EventHandler(this.Colar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(36, 6);
            // 
            // Negrito
            // 
            this.Negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Negrito.Image = ((System.Drawing.Image)(resources.GetObject("Negrito.Image")));
            this.Negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Negrito.Name = "Negrito";
            this.Negrito.Size = new System.Drawing.Size(36, 24);
            this.Negrito.Text = "btn_negrito";
            this.Negrito.Click += new System.EventHandler(this.Negrito_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(36, 6);
            // 
            // Italico
            // 
            this.Italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italico.Image = ((System.Drawing.Image)(resources.GetObject("Italico.Image")));
            this.Italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italico.Name = "Italico";
            this.Italico.Size = new System.Drawing.Size(36, 24);
            this.Italico.Text = "btn_italico";
            this.Italico.Click += new System.EventHandler(this.Italico_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(36, 6);
            // 
            // Sublinhado
            // 
            this.Sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sublinhado.Image = ((System.Drawing.Image)(resources.GetObject("Sublinhado.Image")));
            this.Sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sublinhado.Name = "Sublinhado";
            this.Sublinhado.Size = new System.Drawing.Size(36, 24);
            this.Sublinhado.Text = "btn_sublinhado";
            this.Sublinhado.Click += new System.EventHandler(this.Sublinhado_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(36, 6);
            // 
            // Justificado
            // 
            this.Justificado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Justificado.Image = ((System.Drawing.Image)(resources.GetObject("Justificado.Image")));
            this.Justificado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Justificado.Name = "Justificado";
            this.Justificado.Size = new System.Drawing.Size(36, 24);
            this.Justificado.Text = "btn_justificado";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(36, 6);
            // 
            // Centralizado
            // 
            this.Centralizado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Centralizado.Image = ((System.Drawing.Image)(resources.GetObject("Centralizado.Image")));
            this.Centralizado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Centralizado.Name = "Centralizado";
            this.Centralizado.Size = new System.Drawing.Size(36, 24);
            this.Centralizado.Text = "btn_centralizado";
            this.Centralizado.Click += new System.EventHandler(this.Centralizado_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(36, 6);
            // 
            // Esquerda
            // 
            this.Esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Esquerda.Image = ((System.Drawing.Image)(resources.GetObject("Esquerda.Image")));
            this.Esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Esquerda.Name = "Esquerda";
            this.Esquerda.Size = new System.Drawing.Size(36, 24);
            this.Esquerda.Text = "btn_esquerda";
            this.Esquerda.Click += new System.EventHandler(this.Esquerda_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(36, 6);
            // 
            // Direita
            // 
            this.Direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Direita.Image = ((System.Drawing.Image)(resources.GetObject("Direita.Image")));
            this.Direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Direita.Name = "Direita";
            this.Direita.Size = new System.Drawing.Size(36, 24);
            this.Direita.Text = "btn_direita";
            this.Direita.Click += new System.EventHandler(this.Direita_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 110);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(490, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(33, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 556);
            this.panel2.TabIndex = 4;
            // 
            // impressao
            // 
            this.impressao.BackColor = System.Drawing.Color.White;
            this.impressao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.impressao.Image = ((System.Drawing.Image)(resources.GetObject("impressao.Image")));
            this.impressao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.impressao.Name = "impressao";
            this.impressao.Size = new System.Drawing.Size(36, 24);
            this.impressao.Text = "Impressao";
            this.impressao.Click += new System.EventHandler(this.impressao_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(36, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 663);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Novo;
        private System.Windows.Forms.ToolStripButton Abrir;
        private System.Windows.Forms.ToolStripButton Copiar;
        private System.Windows.Forms.ToolStripButton Colar;
        private System.Windows.Forms.ToolStripButton Negrito;
        private System.Windows.Forms.ToolStripButton Italico;
        private System.Windows.Forms.ToolStripButton Sublinhado;
        private System.Windows.Forms.ToolStripButton Justificado;
        private System.Windows.Forms.ToolStripButton Esquerda;
        private System.Windows.Forms.ToolStripButton Direita;
        private System.Windows.Forms.ToolStripButton Centralizado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton impressao;
    }
}

