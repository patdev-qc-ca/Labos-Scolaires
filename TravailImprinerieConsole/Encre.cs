namespace TravailImprinerieConsole
{
    internal class Encre
    {
        public decimal lvlEncre { get => this.lvlEncre; set => this.lvlEncre = value; }
        private int quota = 30;

        public Encre(int lvlEncre, int quota)
        {
            this.lvlEncre = lvlEncre;
            this.quota = quota;
        }

        public Encre(int Pages)
        {
            this.lvlEncre -= Math.Ceiling(decimal.Ceiling(Pages / this.quota));
        }
    }
}