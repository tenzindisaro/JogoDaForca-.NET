using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_da_forca
{
    internal class Class_palavras
    {
        private string[] palavras;
        private string[] dicas;
        private Random random = new Random();
        int indice;
        public Class_palavras()
        {
            palavras = new string[]
            {
                "abacaxi", "elefante", "computador", "montanha", "bicicleta",
                "chocolate", "aviao", "sorvete", "oceano", "cachorro",
                "piano", "floresta", "foguete", "televisao", "girafa",
                "ceu", "praia", "livro", "eletricidade", "futebol"
            };

            dicas = new string[]
            {
                "Uma fruta tropical amarela e doce.",
                "Um animal grande com tromba.",
                "Uma máquina que processa dados.",
                "Uma elevação natural da Terra.",
                "Um veículo de duas rodas.",
                "Um doce feito de cacau e açúcar.",
                "Meio de transporte que voa no ar.",
                "Uma sobremesa gelada e cremosa.",
                "Uma vasta extensão de água salgada.",
                "Um animal de estimação leal.",
                "Um instrumento musical de teclas.",
                "Uma grande área coberta por árvores.",
                "Um veículo espacial que vai para o espaço.",
                "Um aparelho para assistir programas.",
                "Um animal de pescoço longo.",
                "A atmosfera acima da Terra.",
                "Uma área de areia ao lado do mar.",
                "Um objeto com páginas para leitura.",
                "A forma de energia com corrente elétrica.",
                "Um esporte com uma bola e dois times."
            };

            GerarNovoIndice();
        }

        public void GerarNovoIndice()
        {
            indice = random.Next(palavras.Length);
        }
        public string getPalavra()
        {
            return palavras[indice];
        }

        public string getDica()
        {
            return dicas[indice];
        }
    }
}
