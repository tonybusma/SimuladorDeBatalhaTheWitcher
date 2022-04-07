namespace SimuladorDeBatalhaTheWitcher.Entities.Monstros
{
    public class Gargula : Monstro
    {
        private int Nivel { get; set; }

        public Gargula(int nivel){
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

            this.Nome = "Gárgula";
            this.Vida += this.Nivel * 2;
            this.Magia += this.Nivel;
            this.ValorDoContrato = 140.00;
            this.ValorDoContrato += ((ValorDoContrato * 0.02) * this.Nivel);
            this.AtaqueFraco += this.Nivel / 10;
            this.AtaqueRapido += this.Nivel / 7;
            this.AtaqueForte += this.Nivel / 6;
        }
    }
}