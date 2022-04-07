using System;
using SimuladorDeBatalhaTheWitcher.Entities.Bruxos;
using SimuladorDeBatalhaTheWitcher.Entities.Monstros;

namespace SimuladorDeBatalhaTheWitcher.Entities.Combates
{
    public class Combate
    {
        Monstro Monstro;
        Bruxo Bruxo;

        public Combate(Monstro monstro, Bruxo bruxo)
        {
            this.Monstro = monstro;
            this.Bruxo = bruxo;

            while(monstro.Vida > 0 || bruxo.Vida > 0)
            {
                Console.WriteLine(bruxo.Ataque(monstro) + "\r\n");
                Console.WriteLine(monstro.Ataque(bruxo) + "\r\n");
            }

            if(monstro.Vida <= 0)
            {
                Console.WriteLine();
                Console.WriteLine($"{bruxo.Nome} matou o(a) {monstro.Nome} e recebeu ${monstro.ValorDoContrato} pelo contrato!");
            }
            else if(bruxo.Vida <= 0)
            {
                Console.WriteLine();
                Console.WriteLine($"{monstro.Nome} venceu a batalha!");
            }
        }


    }
}