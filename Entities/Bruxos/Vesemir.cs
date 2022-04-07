namespace SimuladorDeBatalhaTheWitcher.Entities.Bruxos
{
    public class Vesemir : Bruxo
    {
        public Vesemir(int nivel)
        {
            this.Nome = "Vesemir";
            this.Nivel = nivel;
            this.Vida += this.Nivel * 2;
            this.Magia += this.Nivel;
            this.AtaqueEspada += this.Nivel / 6;
            this.AtaqueSinal += this.Nivel / 8;
            this.GolpePotente += this.Nivel / 6;
        }
    }
}