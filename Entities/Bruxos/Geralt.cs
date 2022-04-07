namespace SimuladorDeBatalhaTheWitcher.Entities.Bruxos
{
    public class Geralt : Bruxo
    {
        public Geralt(int nivel)
        {
            this.Nome = "Geralt";
            this.Nivel = nivel;
            this.Vida += this.Nivel * 2;
            this.Magia += this.Nivel;
            this.AtaqueEspada += this.Nivel / 5;
            this.AtaqueSinal += this.Nivel / 10;
            this.GolpePotente += this.Nivel / 4;
        }

        
    }
}