using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_forca
{
    public partial class Form1 : Form
    {
        Class_palavras palavras = new Class_palavras();
        Class_verifica_letra letra;
        string palavra_forca;
        public Form1()
        {
            InitializeComponent();
        }
        private void ResetForm()
        {
            palavras.GerarNovoIndice();
            palavra_forca = palavras.getPalavra();
            letra = new Class_verifica_letra(palavra_forca);
            txtBox_palavra.Text = letra.getPalavra_asterisco();
            txtBox_dica.Text = palavras.getDica();
            txtBox_letra.Clear();
            lb_chances.Text = "6";
            lb_letras.Text = "";
            pictureBox_forca.Visible = true;
            pictureBox_cabeca.Visible = false;
            pictureBox_corpo.Visible = false;
            pictureBox_braco1.Visible = false;
            pictureBox_braco2.Visible = false;
            pictureBox_perna1.Visible = false;
            pictureBox_perna2.Visible = false;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string letra_input = txtBox_letra.Text.ToLower();

            letra.setLabel_letras(letra_input);
            lb_letras.Text = letra.getLabel_letras();

            bool letra_true = letra.letra_correta(letra_input);


            if (letra_true)
            {
                char[] palavraArray = txtBox_palavra.Text.ToCharArray();

                for (int i = 0; i < palavra_forca.Length; i++)
                {
                    if (palavra_forca[i] == letra_input[0])
                    {
                        palavraArray[i] = letra_input[0];
                    }
                }

                // Atualizar o texto do TextBox
                txtBox_palavra.Text = new string(palavraArray);

                if (palavra_forca == txtBox_palavra.Text)
                {
                    MessageBox.Show("Parabéns você acertou a palavra em cheio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ResetForm();
                }
            }
            else
            {
                int chances = int.Parse(lb_chances.Text);

                if (chances > 1)
                {
                    chances -= 1;
                    if (chances == 5)
                    {
                        pictureBox_forca.Visible = false;
                        pictureBox_cabeca.Visible = true;
                    }
                    else if (chances == 4)
                    {
                        pictureBox_cabeca.Visible = false;
                        pictureBox_corpo.Visible = true;
                    }
                    else if (chances == 3)
                    {
                        pictureBox_corpo.Visible = false;
                        pictureBox_braco1.Visible = true;
                    }
                    else if (chances == 2)
                    {
                        pictureBox_braco1.Visible = false;
                        pictureBox_braco2.Visible = true;
                    }
                    else if (chances == 1)
                    {
                        pictureBox_braco2.Visible = false;
                        pictureBox_perna1.Visible = true;
                    }


                    lb_chances.Text = chances.ToString();
                }
                else
                {
                    if (chances == 1)
                    {
                        pictureBox_perna1.Visible = false;
                        pictureBox_perna2.Visible = true;
                    }
                    lb_chances.Text = "0";


                    MessageBox.Show(string.Format("Suas Tentativas esgotaram! A palavra correta era {0}!", palavra_forca), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    ResetForm();
                }
            }
            txtBox_letra.Clear();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            pn_jogo.Visible = true;
            btn_start.Visible = false;
            pictureBox_forca.Visible = true;
            pictureBox_cabeca.Visible = false;
            pictureBox_corpo.Visible = false;
            pictureBox_braco1.Visible = false;
            pictureBox_braco2.Visible = false;
            pictureBox_perna1.Visible = false;
            pictureBox_perna2.Visible = false;




            palavra_forca = palavras.getPalavra();
            letra = new Class_verifica_letra(palavra_forca);

            txtBox_palavra.Text = letra.getPalavra_asterisco();
            txtBox_dica.Text = palavras.getDica();
        }

        private void btn_desistir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vamos iniciar uma nova partida, boa sorte!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ResetForm();
        }
    }
}
