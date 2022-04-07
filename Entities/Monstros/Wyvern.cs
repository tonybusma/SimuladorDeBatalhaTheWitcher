namespace SimuladorDeBatalhaTheWitcher.Entities.Monstros
{
    public class Wyvern : Monstro
    {
        private int Nivel { get; set; }

        public Wyvern(int nivel){
            if(nivel > 25)
            {
                this.Nivel = 25;
            }
            else if(nivel < 1)
            {
                this.Nivel = 1;
            }
            else
            {
                this.Nivel = nivel;
            }

            this.Nome = "Wyvern Real";
            this.Vida += this.Nivel * 3;
            this.Magia += this.Nivel * 2;
            this.ValorDoContrato = 170.00;
            this.ValorDoContrato += ((ValorDoContrato * 0.03) * this.Nivel);
            this.AtaqueFraco += this.Nivel / 8;
            this.AtaqueRapido += this.Nivel / 6;
            this.AtaqueForte += this.Nivel / 5;
        }
    }
}