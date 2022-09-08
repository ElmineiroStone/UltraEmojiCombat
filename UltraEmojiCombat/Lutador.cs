using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraEmojiCombat
{
    public class Lutador
    {
        private float peso;
        private string categoria;

        //metodos publicos
        public void Apresentar()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"CHEGOU A HORA! Apresentamos o lutador {Nome}");
            Console.WriteLine($"Diretamente de {Nacionalidade}");
            Console.WriteLine($"com {Idade} anos e {Altura}");
            Console.WriteLine($"pesando {Peso} Kg");
            Console.WriteLine($"{Vitorias} vitórias");
            Console.WriteLine($"{Derrotas} derrotas e");
            Console.WriteLine($"{Empates} empates!");
        }

        public void Status()
        {
            Console.WriteLine($"{Nome} é um peso {Categoria}");
            Console.WriteLine($"Ganhou {Vitorias} vezes");
            Console.WriteLine($"Perdeu {Derrotas} vezes");
            Console.WriteLine($"Empatou {Empates} vezes");
        }

        public void GanharLuta()
        {
            Vitorias++;
        }
        public void PerderLuta()
        {
            Derrotas++;
        }
        public void EmpatarLuta()
        {
            Empates++;
        }
        
        
        //metodos especiais
        public Lutador(string no, string na, int id, float alt, float pe, int vit,
            int de, int emp)
        {
            Nome = no;
            Nacionalidade = na;
            Idade = id;
            Altura = alt;
            Peso = pe;
            Vitorias = vit;
            Derrotas = de;
            Empates = emp;
        }

        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public int Idade { get; set; }
        public float Peso
        {
            get => peso;
            set
            {
                peso = value;
                Categoria = categoria;
            }
        }
        
        public float Altura { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public int Empates { get; set; }
        public string Categoria { 
            get 
            { 
                return categoria;
            }
            set
            {
                if (peso < 52.2)
                {
                    categoria = "Inválido";
                }
                else if (peso <= 70.3)
                {
                    categoria = "Leve";
                }
                else if (peso <= 83.9)
                {
                    categoria = "Médio";
                }
                else if (peso <= 120.2)
                {
                    categoria = "Pesado";
                }
                else
                {
                    categoria = "Inválido";
                }
            }
        }
        
    }
}
