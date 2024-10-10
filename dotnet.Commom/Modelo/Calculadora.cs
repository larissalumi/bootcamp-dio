using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Common.Modelo
{
    public class Calculadora
    {
        /// <summary>
        /// realiza a soma de dois inteiros
        /// </summary>
        /// <param name="x">primeiro número inteiro para somar</param>
        /// <param name="y">segundo número inteiro para somar</param>
        public void Soma(int x, int y) 
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        /// <summary>
        /// realiza a subtração de dois inteiros
        /// </summary>
        /// <param name="x">primeiro número inteiro para subtrair</param>
        /// <param name="y">segundo número inteiro para subtrair</param>
        public void  Subtracao(int x, int y)
        {
            Console.WriteLine($"{x} - {y} =  {x - y}");
        }

        /// <summary>
        /// realiza a multiplicação de dois inteiros
        /// </summary>
        /// <param name="x">primeiro número inteiro para multiplicar</param>
        /// <param name="y">segundo número inteiro para multiplicar</param>
        public void Multiplicacao(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
        /// <summary>
        /// realiza a divisão de dois inteiros
        /// </summary>
        /// <param name="x">primeiro número inteiro: numerador, o número que será dividido</param>
        /// <param name="y">segundo número inteiro: denominador</param>
        public void Divisao(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double sen = Math.Sin(radiano);
            Console.WriteLine($"sen {angulo} = {Math.Round(sen, 4)}");
        }

        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cos = Math.Cos(radiano);
            Console.WriteLine($"cos {angulo} = {Math.Round(cos, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tan = Math.Tan(radiano);
            Console.WriteLine($"tan {angulo} = {Math.Round(tan, 4)}");
        }

        public void Incremento(int x)
        {
            x++;
            Console.WriteLine(x);
        }

        public void Decremento(int x)
        {
            x--;
            Console.WriteLine(x);
        }
    }
}