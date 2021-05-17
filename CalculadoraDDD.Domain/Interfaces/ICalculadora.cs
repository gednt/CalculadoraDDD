using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDDD.Domain.Interfaces
{
    interface ICalculadora
    {
        /// <summary>
        /// Sums two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        Double Somar(Double num1, Double num2);
        /// <summary>
        /// Subtracts two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        Double Subtrair(Double num1, Double num2);
        /// <summary>
        /// Multiplies two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        Double Multiplicar(Double num1, Double num2);
        /// <summary>
        /// Divides two numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        Double Dividir(Double num1, Double num2);
        /// <summary>
        /// Potencializes two numbers
        /// </summary>
        /// <param name="num"></param>
        /// <param name="pot"></param>
        Double Potencializar(Double num, Double pot);
        /// <summary>
        /// Finds the square root
        /// </summary>
        /// <param name="num"></param>
        /// <param name="Raiz"></param>
        Double RaizQuadrada(Double Raiz);
        /// <summary>
        /// Cleans every operation
        /// </summary>
        void LimparTodos();
        /// <summary>
        /// Cleans the last operation
        /// </summary>
        void LimparUltimo();
        /// <summary>
        /// Gets the result of all operations and displays on the screen
        /// </summary>
        /// <returns></returns>
        double GetResult();
        /// <summary>
        /// Gets the history of all operations
        /// </summary>
        void GetHistorico();
        /// <summary>
        /// Starts the main method of the calculator
        /// </summary>
       
    }
    
}
