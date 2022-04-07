using System;
using SimuladorDeBatalhaTheWitcher.Entities.Bruxos;

namespace SimuladorDeBatalhaTheWitcher.Entities.Monstros
{
    public class Monstro
    {
        public string Nome { get; set; }
        public int Vida { get; set; } = 100;
        protected int Magia { get; set; } = 100;
        protected int AtaqueFraco { get; set; } = 5;
        protected int AtaqueRapido { get; set; } = 10;
        protected int AtaqueForte { get; set; } = 15;
        protected int EsquivaDoOponente { get; set; } = 0;
        public Double ValorDoContrato { get; set; }

        public Monstro()
        {
            
        }

        public string Ataque(Bruxo bruxo)
        {
            int[] lista = {AtaqueFraco, AtaqueRapido, AtaqueForte, EsquivaDoOponente};
            Random random = new Random();
            int danoAplicado = lista[random.Next(0,4)];

            string golpe;
            if(danoAplicado == AtaqueFraco){
                golpe = "ataque fraco";
            }
            else if(danoAplicado == AtaqueRapido){
                golpe = "ataque veloz";
            }
            else if(danoAplicado == AtaqueForte){
                golpe = "ataque forte";
            }
            else{
                golpe = "ataque, mas o bruxo se esquivou,";
            }

            bruxo.Vida -= danoAplicado;
            return $"{this.Nome} aplicou um {golpe} e causou {danoAplicado} de dano.";
        }
    }
}