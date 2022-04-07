namespace SimuladorDeBatalhaTheWitcher.Entities.Monstros
{
    public class Aparicao : Monstro
    {
        private int Nivel { get; set; }

        public Aparicao(int nivel){
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

            this.Nome = "Aparição";
            this.Vida += this.Nivel;
            this.Magia += this.Nivel;
            this.ValorDoContrato = 100.00;
            this.ValorDoContrato += ((ValorDoContrato * 0.01) * this.Nivel);
            this.AtaqueFraco += this.Nivel / 12;
            this.AtaqueRapido += this.Nivel / 8;
            this.AtaqueForte += this.Nivel / 7;
        }
    }
}