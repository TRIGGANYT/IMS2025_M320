namespace Arbeitsskript_2._2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Optional: Testcode hier
        }
    }

    public class AttributMix
    {
        internal int einnahme;
        public int ausgabe;
        public double zins = 2.00;
        private bool gemahnt;
        protected int anzahl;
        internal string name = "Meier";
        public int Guthaben => einnahme - ausgabe;
        public int Jahrgang { get; } = 2025;
    }
}
