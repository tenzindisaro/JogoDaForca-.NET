using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_da_forca
{
    internal class Class_verifica_letra
    {
        private string palavra, letras_lb;
        private int posicao;
        public Class_verifica_letra(string palavra_forca)
        {
            palavra = palavra_forca;
            letras_lb = "";
            posicao = -1;

        }
        public void setLabel_letras(string label) { letras_lb += label; }
        public string getLabel_letras() { return letras_lb; }

        public string getPalavra_asterisco()
        {
            string asterisco_palavra = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                asterisco_palavra += "#";
            }
            return asterisco_palavra;
        }

        public bool letra_correta(string letra)
        {
            if (palavra.Contains(letra))
            {
                return true;
            }
            else { return false; }
        }
    }
}
