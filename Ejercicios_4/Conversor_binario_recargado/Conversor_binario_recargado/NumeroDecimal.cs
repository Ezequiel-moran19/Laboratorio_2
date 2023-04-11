using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_binario_recargado
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }
        public string DecimalABinario(double numero)
        {
            string binario = string.Empty;
            int resultadoDivision = (int)numero;
            int restoDivision;
            
            if (resultadoDivision >= 0)
            {
                do
                {
                    restoDivision = resultadoDivision % 2;
                    resultadoDivision /= 2;
                    binario = restoDivision.ToString() + binario;
                } while (resultadoDivision > 0);
            }

            return binario;
        }
        public double Numero { get => numero; set => numero = value; }

        public static explicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }
        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)numeroDecimal.DecimalABinario(numeroDecimal.Numero);
        }

        public static bool operator ==(NumeroDecimal d1, NumeroBinario b1)
        {
            return d1.numero == ((NumeroDecimal)b1).numero;
        }
        public static bool operator !=(NumeroDecimal d1, NumeroBinario b1)
        {
            return !(d1 == b1);
        }
        public static double operator +(NumeroDecimal d1, NumeroBinario b1)
        {
            return d1.numero + ((NumeroDecimal)b1).numero;
        }
        public static double operator -(NumeroDecimal d1, NumeroBinario b1)
        {
            return (d1 - b1);
        }

    }
}
