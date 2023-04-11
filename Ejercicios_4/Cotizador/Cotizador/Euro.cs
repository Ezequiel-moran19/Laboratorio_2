namespace Billetes

{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        static Euro()
        {
            Euro.cotzRespectoDolar = 1 / 1.18;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double contozacion) : this(cantidad)
        {
            Euro.cotzRespectoDolar = contozacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Dolar.GetCotizacion());
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad == e2.GetCantidad;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.GetCantidad == ((Euro)d).GetCantidad);
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return (e.GetCantidad == ((Euro)p).GetCantidad);
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - ((Euro)d).cantidad);
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad - ((Euro)p).cantidad);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + ((Euro)d).cantidad);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + ((Euro)p).cantidad);
        }
    }
}