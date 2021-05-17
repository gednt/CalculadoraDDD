using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraDDD.Domain.Classes;
namespace CalculadoraDDD.Application.Controllers
{
   public class CalculadoraController
    {
        /// <summary>
        /// Initiates the main Process of the Application
        /// </summary>
        public void Calcular()
        {
            Calculadora calculadora = new Calculadora();
            Console.Write("Calculadora DMF Software, Interface Test\n\nTodo resultado será somado ao anterior\nDigite a operação desejada (ex: 2+2) e confira o resultado\nPara ajuda, digite '?'\n*******\n");
            int option = 0;
            while (option != 99)
            {
                String operacao = Console.ReadLine();
                String array = operacao.Trim();
                for (int cont = 0; cont < array.Length; cont++)
                {
                    if (Char.IsNumber(array[cont]) == false)
                    {
                        switch (array[cont])
                        {
                            case '+':
                                String[] numeros = operacao.Split('+');
                                Console.WriteLine("{0}+{1}={2}", numeros[0], numeros[1],
                                    calculadora.Somar(Double.Parse(numeros[0]), Double.Parse(numeros[1])));
                                break;
                            case '-':
                                numeros = operacao.Split('-');
                                Console.WriteLine("{0}-{1}={2}", numeros[0], numeros[1],
                                    calculadora.Subtrair(Double.Parse(numeros[0]), Double.Parse(numeros[1])));
                                break;
                            case '*':
                                numeros = operacao.Split('*');
                                Console.WriteLine("{0}*{1}={2}", numeros[0], numeros[1],
                                    calculadora.Multiplicar(Double.Parse(numeros[0]), Double.Parse(numeros[1])));
                                break;
                            case 'x':
                                numeros = operacao.Split('x');
                                Console.WriteLine("{0} X {1} = {2}", numeros[0], numeros[1],
                                    calculadora.Multiplicar(Double.Parse(numeros[0]), Double.Parse(numeros[1])));
                                break;

                            case '/':
                                numeros = operacao.Split('/');
                                Console.WriteLine("{0}/{1}={2}", numeros[0], numeros[1],
                                    calculadora.Dividir(Double.Parse(numeros[0]), Double.Parse(numeros[1])));
                                break;

                            case 'p':
                                numeros = operacao.Split('p');
                                Console.WriteLine("{0} Potencia {1} = {2}", numeros[0], numeros[1],
                                    calculadora.Potencializar(Double.Parse(numeros[0]), Double.Parse(numeros[1])));
                                break;
                            case '^':
                                numeros = operacao.Split('^');
                                Console.WriteLine("{0} Potencia {1} = {2}", numeros[0], numeros[1],
                                    calculadora.Potencializar(Double.Parse(numeros[0]), Double.Parse(numeros[1])));
                                break;
                            case 'q':
                                numeros = operacao.Split('q');
                                Console.WriteLine("Raiz quadrada de {0} = {0}", numeros[0],
                                    calculadora.RaizQuadrada(Double.Parse(numeros[0])));
                                break;
                            case 'r':
                                numeros = operacao.Split('r');
                                Console.WriteLine("Raiz quadrada de {0} = {0}", numeros[0],
                                    calculadora.RaizQuadrada(Double.Parse(numeros[0])));
                                break;
                            case 'c':
                                calculadora.LimparTodos();
                                break;
                            case 'u':
                                calculadora.LimparUltimo();
                                break;
                            case 'h':
                                calculadora.GetHistorico();
                                break;
                            case '?':
                                Console.Clear();
                                String msg = "Para efetuar uma operação, digite no formato em extenso (Ex: 2+2) e aperte enter\n\nOutros comandos\n" +
                                    "c - Limpar todas as operações anteriores\n" +
                                    "u - Limpar última operação anterior\n" +
                                    "h - Ver todas as operações anteriores\n";
                                Console.WriteLine(msg + "\n*******************\nPressione qualquer tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                                Console.Write("Calculadora DMF Software, Interface Test\n\nTodo resultado será somado ao anterior\nDigite a operação desejada (ex: 2+2) e confira o resultado\nPara ajuda, digite '?'\n*******\n");
                                break;
                        }
                        Console.WriteLine(calculadora.GetResult());
                    }
                }
            }
        }
    }
}
