namespace SimuladorDeBatalhaTheWitcher.Entities.Monstros
{
    public class Demonio : Monstro
    {
        private int Nivel { get; set; }

        public Demonio(int nivel){
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

            this.Nome = "Demônio";
            this.Vida += this.Nivel * 4;
            this.Magia += this.Nivel * 2;
            this.ValorDoContrato = 200.00;
            this.ValorDoContrato += ((ValorDoContrato * 0.04) * this.Nivel);
            this.AtaqueFraco += this.Nivel / 7;
            this.AtaqueRapido += this.Nivel / 5;
            this.AtaqueForte += this.Nivel / 4;
        }
    }
}