using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private static ESistema sistema;

        static Calculadora()
        {
            sistema = ESistema.Decimal;
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }

        public Calculadora(string nombreAlumno) : this()
        {
            this.nombreAlumno = nombreAlumno;
        }


        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }

        public List<string> Operaciones
        {
            get { return operaciones; }
        }

        public Numeracion PrimerOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }

        public Numeracion Resultado
        {
            get { return resultado; }
        }

        public Numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }

        public static ESistema Sistema
        {
            get { return sistema; }
            set { sistema = value; }
        }

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            /*sb.AppendLine($"El sistema de la calculadora es: {sistema}\n");
            sb.AppendLine($"El valor del primer operando es {primerOperando.Valor} y el del segundo {segundoOperando.Valor}");
            sb.AppendLine($"El operador es {operador}");*/
            sb.Append($"{primerOperando.Valor} + {segundoOperando.Valor} = {resultado.Valor} ");
            operaciones.Add(sb.ToString()); 

            sb.ToString();
        }

        public void Calcular()
        {
            Calcular('+');
        }

        public void Calcular(char operador)
        {
            double result;

            if (this.PrimerOperando == this.SegundoOperando)
            {
                double.TryParse(this.primerOperando.Valor, out double n1);
                double.TryParse(this.segundoOperando.Valor, out double n2);

                switch (operador)
                {
                    case '-':
                        result = n1 - n2;
                        break;
                    case '*':
                        result = n1 * n2;
                        break;
                    case '/':
                        result = n1 / n2;
                        break;
                    default:
                        result = n1 + n2;
                        break;
                }
            }
            else
            {
                result = double.MinValue;
            }

            MapeaResultado(result);
        }

        public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }

        private Numeracion MapeaResultado(double valor)
        {
            Numeracion aux = (SistemaDecimal)valor;

            if (sistema == ESistema.Decimal)
            {
                resultado = aux;
                return aux;
            }
            else
            {
                resultado = aux;
                return aux.CambiarSistemaDeNumeracion(Sistema);
            }
        }


    }
}
