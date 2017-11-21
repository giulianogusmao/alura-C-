using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.IO
{
    public partial class Form1 : Form
    {
        string file = "entrada.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LeArquivo(this.file);
        }

        private void LeArquivo(string arquivo)
        {
            if (File.Exists(arquivo))
            {
                Stream entrada = File.Open(arquivo, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                //string linha = leitor.ReadToEnd();

                //while (linha != null)
                //{
                //    texto.Text += linha;
                //    linha = leitor.ReadLine();
                //}

                string conteudo = leitor.ReadToEnd();
                texto.Text = conteudo;

                leitor.Close();
                entrada.Close();
            }
        }

        private void GravaArquivo(string arquivo)
        {
            // Quando não queremos nos preocupar em fechar um recurso que foi aberto (um arquivo, por exemplo), podemos utilizar o using do c#:

            using (Stream saida = File.Open(arquivo, FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                escritor.Write(texto.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GravaArquivo(this.file);
        }
    }
}
