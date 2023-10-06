using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {

        }

        internal override double ValorNumerico
        {
            get
            {                
                return (double)this.BinarioADecimal();
            }
        }

        private SistemaDecimal BinarioADecimal()
        {
            double retorno = 0;

            if(this.EsSistemaBinarioValido(valor))
            {
                char[] array = valor.ToCharArray();
                Array.Reverse(array);

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        // Se usa la potencia de 2, según la posición, porque se dio vuelta el array
                        retorno += (double)Math.Pow(2, i);
                    }
                }
            }
            else
            {
                retorno = double.MinValue;
            }

            return retorno;
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            Numeracion n;

            if (sistema == ESistema.Binario)
            {
                n = this;
            }
            else
            {
                n = this.BinarioADecimal();
            }
            return n;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return EsSistemaBinarioValido(valor);
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            bool retorno = true;

            foreach (var item in valor)
            {
                if (item != '0' && item != '1')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        public static implicit operator SistemaBinario(string valor)
        {
            SistemaBinario n1 = new SistemaBinario(valor);

            return n1;
        }
    }
}
