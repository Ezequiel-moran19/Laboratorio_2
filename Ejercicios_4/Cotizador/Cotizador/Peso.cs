using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        static Peso()
        {
            Peso.cotzRespectoDolar = 102;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double contozacion) : this(cantidad)
        {
            Peso.cotzRespectoDolar = contozacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Peso.cotzRespectoDolar;
        }
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad() / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
           
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad == p2.GetCantidad;
        }
        public static bool operator !=(Peso d1, Peso d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return (p.GetCantidad == ((Peso)e).GetCantidad);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return (p == (Peso)d);
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static Peso operator -(Peso d, Euro e)
        {
            return new Peso((d.cantidad - ((Peso)e).cantidad));
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso((p.cantidad - ((Peso)d).cantidad));
        }
        public static Peso operator +(Peso d, Euro e)
        {
            return new Peso((d.cantidad + ((Peso)e).cantidad));
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso((p.cantidad + ((Peso)d).cantidad));
        }
    }
}
