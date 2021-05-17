using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDDD.Domain.Classes
{
   public class Calculadora : CalculadoraDDD.Domain.Interfaces.ICalculadora
    {
        List<String> HistoricoCalculo = new List<string>();
        List<Double> HistoricoSomaCalculo = new List<double>();
        public Double Somar(Double num1, Double num2)
        {
            HistoricoCalculo.Add(String.Format("{0}+{1}", num1.ToString(), num2.ToString()));
            if (HistoricoSomaCalculo.Count > 0)
            {
                HistoricoSomaCalculo.Add(HistoricoSomaCalculo[HistoricoSomaCalculo.Count - 1] + num1 + num2);
            }
            else
            {
                HistoricoSomaCalculo.Add(num1 + num2);
            }
          
            return num1 + num2;
        }
        public Double Subtrair(Double num1, Double num2)
        {
            HistoricoCalculo.Add(String.Format("{0}-{1}", num1.ToString(), num2.ToString()));
            if (HistoricoSomaCalculo.Count > 0)
            {
                HistoricoSomaCalculo.Add(HistoricoSomaCalculo[HistoricoSomaCalculo.Count - 1] + (num1 - num2));
            }
            else
            {
                HistoricoSomaCalculo.Add(num1 - num2);
            }
            return num1 - num2;
        }
        public Double Dividir(Double num1, Double num2)
        {
            HistoricoCalculo.Add(String.Format("{0}/{1}", num1.ToString(), num2.ToString()));
            if (HistoricoSomaCalculo.Count > 0)
            {
                HistoricoSomaCalculo.Add(HistoricoSomaCalculo[HistoricoSomaCalculo.Count - 1] + (num1 / num2));
            }
            else
            {
                HistoricoSomaCalculo.Add(num1 / num2);
            }
            return num1 / num2;
        }
        public Double Multiplicar(Double num1, Double num2)
        {
            HistoricoCalculo.Add(String.Format("{0}x{1}", num1.ToString(), num2.ToString()));
            if (HistoricoSomaCalculo.Count > 0)
            {
                HistoricoSomaCalculo.Add(HistoricoSomaCalculo[HistoricoSomaCalculo.Count - 1] + (num1 * num2));
            }
            else
            {
                HistoricoSomaCalculo.Add(num1 * num2);
            }
            return num1 * num2;
        }
        public Double Potencializar(Double num1, Double pot)
        {
            HistoricoCalculo.Add(String.Format("{0}p{1}", num1.ToString(),pot));
            if (HistoricoSomaCalculo.Count > 0)
            {
                HistoricoSomaCalculo.Add(HistoricoSomaCalculo[HistoricoSomaCalculo.Count - 1] + (Math.Pow(num1, pot)));
            }
            else
            {
                HistoricoSomaCalculo.Add(Math.Pow(num1, pot));
            }
            return Math.Pow(num1,pot);
        }
        public Double RaizQuadrada(Double RaizQuadrada)
        {
            HistoricoCalculo.Add(String.Format("{0}q", RaizQuadrada));
            if (HistoricoSomaCalculo.Count > 0)
            {
                HistoricoSomaCalculo.Add(HistoricoSomaCalculo[HistoricoSomaCalculo.Count - 1] + (Math.Sqrt(RaizQuadrada)));
            }
            else
            {
                HistoricoSomaCalculo.Add(Math.Sqrt(RaizQuadrada));
            }
            return Math.Sqrt(RaizQuadrada);
        }
        public void LimparTodos()
        {
            HistoricoCalculo = new List<string>();
            HistoricoSomaCalculo = new List<double>();
        }
        public void LimparUltimo()
        {
            if (HistoricoSomaCalculo.Count > 0)
            {
                HistoricoSomaCalculo.RemoveAt(HistoricoSomaCalculo.Count - 1);
                HistoricoCalculo.RemoveAt(HistoricoCalculo.Count - 1);
                Console.Clear();
                Console.WriteLine("Últimas contas:");
                for (int cont = 0; cont < HistoricoSomaCalculo.Count; cont++)
                {
                    Console.WriteLine("{0}={1}", HistoricoCalculo[cont], HistoricoSomaCalculo[cont]);
                }
            }
          
        }

        public Double GetResult()
        {
            if (HistoricoSomaCalculo.Count > 0)
            {
                return HistoricoSomaCalculo[HistoricoSomaCalculo.Count - 1];
            }
            else
            {
                return 0;
            }
            
        }

        public void GetHistorico()
        {
            Console.Clear();
            Console.WriteLine("Últimas contas:");
            for (int cont = 0; cont < HistoricoSomaCalculo.Count; cont++)
            {
                Console.WriteLine("{0}={1}", HistoricoCalculo[cont], HistoricoSomaCalculo[cont]);
            }

        }

     

    }
}
