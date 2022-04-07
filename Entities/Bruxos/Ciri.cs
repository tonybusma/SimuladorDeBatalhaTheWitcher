using System;
using SimuladorDeBatalhaTheWitcher.Entities.Monstros;

namespace SimuladorDeBatalhaTheWitcher.Entities.Bruxos
{
    public class Ciri : Bruxo
    {
        public Ciri(int nivel){
            this.Nome = "Ciri";
            this.Nivel = nivel;
            this.Vida += this.Nivel * 2;
            this.Magia += this.Nivel * 3;
            this.AtaqueEspada += this.Nivel / 6;
            this.AtaqueSinal += this.Nivel / 5;
            this.GolpePotente += this.Nivel / 5;
        }

        public override string Ataque(Monstro monstro)
        {
            int[] lista = {AtaqueEspada, AtaqueSinal, GolpePotente};
            Random random = new Random();
            int danoAplicado = lista[random.Next(0,3)];

            string golpe;
            if(danoAplicado == AtaqueEspada){
                golpe = "ataque rápido";
            }
            else if(danoAplicado == AtaqueSinal){
                golpe = "ataque com magia";
                this.Magia -= 5;
            }
            else{
                golpe = "conjunto de golpes";
            }

            monstro.Vida -= danoAplicado;
            return $"{this.Nome} aplicou um {golpe} e causou {danoAplicado} de dano.";
        }
    }
}