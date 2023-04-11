namespace Sumador_biblio
{
    public class Sumador
    {
        private int cantiddadSumas;

        public Sumador(int cantiddadSumas)
        {
            this.cantiddadSumas = cantiddadSumas;
        }
        public Sumador() : this(0)
        {

        }
        public long Sumar(long a, long b)
        {
            this.cantiddadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantiddadSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador s1)
        {
            return s1.cantiddadSumas;
        }
        
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantiddadSumas + s2.cantiddadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1.cantiddadSumas == s2.cantiddadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}