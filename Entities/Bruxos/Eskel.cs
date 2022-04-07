namespace SimuladorDeBatalhaTheWitcher.Entities.Bruxos
{
    public class Eskel : Bruxo
    {
        public Eskel(int nivel)
        {
            this.Nome = "Eskel";
            this.Nivel = nivel;
            this.Vida += this.Nivel * 2;
            this.Magia += this.Nivel;
            this.AtaqueEspada += this.Nivel / 6;
            this.AtaqueSinal += this.Nivel / 10;
            this.GolpePotente += this.Nivel / 6;
        }
    }
}