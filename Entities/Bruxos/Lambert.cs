namespace SimuladorDeBatalhaTheWitcher.Entities.Bruxos
{
    public class Lambert : Bruxo
    {
        public Lambert(int nivel)
        {
            this.Nome = "Lambert";
            this.Nivel = nivel;
            this.Vida += this.Nivel * 2;
            this.Magia += this.Nivel;
            this.AtaqueEspada += this.Nivel / 7;
            this.AtaqueSinal += this.Nivel / 10;
            this.GolpePotente += this.Nivel / 5;
        }
    }
}