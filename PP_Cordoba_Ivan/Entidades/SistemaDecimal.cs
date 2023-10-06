using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor)
        {

        }

        internal override double ValorNumerico
        {
            get
            {
                double.TryParse(this.valor, out double aux);
                return aux;
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            Numeracion n;

            if (sistema == ESistema.Decimal)
            {
                n = this;
            }
            else
            {
                n = this.DecimalABinario();
            }

            return n;
        }

        private SistemaBinario DecimalABinario()
        {
            string retorno;
            double aux = 0;

            if (EsNumeracionValida(this.valor))
            {
                double.TryParse(this.Valor, out aux);
            }

            if (aux > 0)
            {
                int numMax = 33554432;
                string numBinario = "";

                for (int i = 0; i < 26; i++)
                {
                    if (aux >= numMax)
                    {
                        numBinario += "1";
                        aux = aux - numMax;
                    }
                    else
                    {
                        numBinario += "0";
                    }
                    numMax = numMax / 2;
                }
                retorno = numBinario;
            }
            else
            {
                retorno = msgError;
            }

            return retorno;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return EsSistemaDecimalValido(valor);
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out double aux);
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            SistemaDecimal n1 = new SistemaDecimal(valor.ToString());
            return n1;
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            SistemaDecimal n1 = new SistemaDecimal(valor);
            return n1;
        }
    }
}
