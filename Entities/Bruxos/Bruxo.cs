using System;
using SimuladorDeBatalhaTheWitcher.Entities.Monstros;

namespace SimuladorDeBatalhaTheWitcher.Entities.Bruxos
{
    public class Bruxo
    {
        public string Nome { get; set; }
        public int Vida { get; set; } = 100;
        private int _nivel;
        protected int Magia { get; set; } = 100;
        protected int AtaqueEspada { get; set; } = 5;
        protected int AtaqueSinal { get; set; } = 8;
        protected int GolpePotente { get; set; } = 15; 
        
        public Bruxo(){

        }

        public int Nivel {
            get { return _nivel;}
            set {                 
                    if(value > 25)
                    {
                        this._nivel = 25;
                    }
                    else if(value < 1)
                    {
                        this._nivel = 1;
                    }
                    else
                    {
                        this._nivel = value;
                    }
                }

        }

        public virtual string Ataque(Monstro monstro)
        {

            int[] lista = {AtaqueEspada, AtaqueSinal, GolpePotente};
            Random random = new Random();
            int danoAplicado = lista[random.Next(0,3)];

            string golpe;
            if(danoAplicado == AtaqueEspada){
                golpe = "ataque com a espada";
            }
            else if(danoAplicado == AtaqueSinal){
                golpe = "ataque com sinal Igni";
                this.Magia -= 5;
            }
            else{
                golpe = "ataque potente";
            }

            monstro.Vida -= danoAplicado;

            return $"{this.Nome} aplicou um {golpe} e causou {danoAplicado} de dano.";
        }
    }
}