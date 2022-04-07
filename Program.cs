using System;
using SimuladorDeBatalhaTheWitcher.Entities.Bruxos;
using SimuladorDeBatalhaTheWitcher.Entities.Monstros;
using SimuladorDeBatalhaTheWitcher.Entities.Combates;

namespace SimuladorDeBatalhaTheWitcher
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("     *BEM-VINDO(A) AO SIMULADOR DE BATALHA THE WITCHER*\r\n");
            Console.Write("      Este pequeno jogo é baseado no mundo de The Witcher, de Andrzej Sapkowski, onde você assumirá o papel de um bruxo e irá combater as mais perversas criaturas, mediante pagamento (é claro!). Para iniciar o jogo, você deverá escolher um personagem e um nível (entre 1 e 25). Em seguida, você deverá escolher uma das três regiões do mundo para onde seu bruxo seguirá.");
            Console.Write(" Por último, você deverá escolher um contrato para cumprir. Cada contrato terá uma criatura, a qual você deverá dar um nível, e um preço a ser pago caso conclua, que irá variar de acordo com o nível do monstro.");
            Console.Write(" Tanto os bruxos quanto os monstros tem seu poder e vida aumentados a cada nível. Cada um tem três tipos de golpes diferentes, com diferentes danos.");
            Console.Write(" Durante o combate, cada oponente usa um ataque aleatório de cada vez, saindo vitorioso aquele que conseguir zerar os pontos de vida do adversário.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ESTÁ CHEGANDO A HORA DA ESPADA E DO MACHADO! ESTÁ CHEGANDO O TEMPO DA LOUCURA E DO DESPREZO! \r\n");
            Console.WriteLine("pressione uma tecla pra continuar\r\n");
            Console.ReadKey();

            int num;
            do
            {
            Console.WriteLine("Escolha o seu bruxo (digite apenas o número e pressione 'enter'): ");
            Console.WriteLine("1 - Geralt de Rivia");
            Console.WriteLine("2 - Ciri");
            Console.WriteLine("3 - Lambert");
            Console.WriteLine("4 - Eskel");
            Console.WriteLine("5 - Vesemir\r\n");
            num = int.Parse(Console.ReadLine());
                if(num < 1 || num > 5)
                {
                    Console.WriteLine("Número incorreto\r\n");
                }
            } while( num < 1 || num > 5);

            Console.WriteLine("Digite o nível do seu bruxo (de 1 a 25): ");
            int nivel = int.Parse(Console.ReadLine());

            Bruxo bruxo = new Bruxo();
            
            switch(num)
            {
                case 1:
                bruxo = new Geralt(nivel);
                break;
                case 2:
                bruxo = new Ciri(nivel);
                break;
                case 3:
                bruxo = new Lambert(nivel);
                break;
                case 4:
                bruxo = new Eskel(nivel);
                break;
                case 5:
                bruxo = new Vesemir(nivel);
                break;
            }

            System.Console.WriteLine(bruxo.Nivel);

            


            //Lambert bruxo = new Lambert(12);
            //Carnical carnical = new Carnical(10);
            
            //Combate combate = new Combate(carnical, bruxo);

        }
    }
}
