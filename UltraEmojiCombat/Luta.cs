using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraEmojiCombat
{
    public class Luta
    {
        private bool aprovada;

        public Lutador Desafiado { get; set; }
        public Lutador Desafiante { get; set; }
        public int Rounds { get; set; }
        public bool Aprovada { get; set; }

        //metodos publicos
        public void marcarLuta(Lutador l1, Lutador l2)
        {
            if (l1.Categoria == l2.Categoria && l1 != l2)
            {
                aprovada = true;
                Desafiado = l1;
                Desafiante = l2;
            }
            else
            {
                aprovada = false;
                Desafiado = null;
                Desafiante = null;
            }
        }
        public void luta()
        {
            if (aprovada)
            {
                Console.WriteLine("============ A LUTA VAI COMEÇAR ===========");
                Console.WriteLine("\n### DESAFIADO ###");
                Desafiado.Apresentar();
                Console.WriteLine("\n### DESAFIANTE ###");
                Desafiante.Apresentar();

                Random aleatorio = new Random();
                int vencedor = aleatorio.Next(3); // 0 1 2

                Console.WriteLine("\n=========== RESULTADO DA LUTA ===========");

                switch (vencedor)
                {
                    case 0: // empate
                        Console.WriteLine("Empatou!");
                        Desafiado.EmpatarLuta();
                        Desafiante.EmpatarLuta();
                        break;
                    case 1: // desafiado vence
                        Console.WriteLine($"Vitória do {Desafiado.Nome}");
                        Desafiado.GanharLuta();
                        Desafiante.PerderLuta();
                        break;
                    case 2: // desafiante vence
                        Console.WriteLine($"Vitória do {Desafiante.Nome}");
                        Desafiante.GanharLuta();
                        Desafiado.PerderLuta();
                        break;
                }
                Console.WriteLine("================================\n");
            }
            else
            {
                Console.WriteLine("A luta não pode acontecer!");
            }
        }


    }
}
