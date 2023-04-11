namespace Conversor_binario_recargado
{
    public class NumeroBinario
    {

        private string numero;
        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public double BinarioADecimal(string valor)
        {
            int resultado = 0;
            int cantCarateres = valor.Length;

            foreach (char caracter in valor)
            {
                cantCarateres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantCarateres);
                }
            }
            return resultado;
        }
        public string Numero { get => numero; }

        public static explicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator NumeroDecimal(NumeroBinario nB)
        {
            return (NumeroDecimal)nB.BinarioADecimal(nB.Numero);
        }
        public static bool operator ==(NumeroBinario b1, NumeroDecimal d1)
        {
            return b1.numero == ((NumeroBinario)d1).numero;
        }
        public static bool operator !=(NumeroBinario b1, NumeroDecimal d1)
        {
            return !(b1 == d1);
        }
        public static string operator +(NumeroBinario b1, NumeroDecimal d1)
        {
            return b1.numero + ((NumeroBinario)d1).numero;
        }
        public static string operator -(NumeroBinario b1, NumeroDecimal d1)
        {
            return (b1 - d1);
        }
    }   
}