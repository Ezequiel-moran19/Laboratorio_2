using System.Runtime.CompilerServices;

namespace Invento_argentino
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private short tinta;
        private ConsoleColor color;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public short GetTinta() 
        {
            return this.tinta;
        } 
        public ConsoleColor GetColor() 
        {
            return this.color; 
        }
        private void SetTinta(short tinta) 
        {
            int cantidadTinta = this.tinta + tinta;
            if (cantidadTinta >= 0 && cantidadTinta <= cantidadTintaMaxima) 
            {
                this.tinta = tinta;
            }
        }
        public string Pintar(short gasto,string dibujo) 
        {
            int tintaUsada = Math.Min(gasto, tinta);
            SetTinta((short)-tintaUsada);
            Console.ForegroundColor = color;
            return new string('*', tintaUsada);
        }

        public void Recargar() 
        {
            SetTinta((short)(cantidadTintaMaxima - this.tinta));
        }
    }
}