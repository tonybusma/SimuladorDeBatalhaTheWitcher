namespace SimuladorDeBatalhaTheWitcher.Entities.Monstros
{
    public class Carnical : Monstro
    {
        private int Nivel { get; set; }

        public Carnical(int nivel){
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

            this.Nome = "Carniçal-atroz";
            this.Vida += this.Nivel * 2;
            this.Magia += this.Nivel;
            this.ValorDoContrato = 120.00;
            this.ValorDoContrato += ((ValorDoContrato * 0.02) * this.Nivel);
            this.AtaqueFraco += this.Nivel / 9;
            this.AtaqueRapido += this.Nivel / 8;
            this.AtaqueForte += this.Nivel / 7;
        }
    }
}