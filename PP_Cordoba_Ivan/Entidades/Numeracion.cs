using System.Runtime.CompilerServices;

namespace Entidades
{
    public enum ESistema
    {
        Binario,
        Decimal
    }

    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;

        static Numeracion()
        {
            msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            InicializaValor(valor);
        }

        public string Valor
        {
            get { return valor; }
        }

        internal abstract double ValorNumerico
        {
            get;
        }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            return string.IsNullOrWhiteSpace(valor);
        }       

        private void InicializaValor(string valor)
        {
            if(EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                valor = msgError;
            }
        }

        public static explicit operator double(Numeracion numeracion)
        {           
            return (double)numeracion;
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1 is not null && n2 is not null && (n1.GetType() == n2.GetType());
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

    }
}