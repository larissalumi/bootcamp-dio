using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace novo.Models
{
    public class ExemploException
    {
        // stack trace
        public void Metodo1() 
        {
            try 
            {
                Metodo2();
            }catch (Exception ex)
            {
                Console.WriteLine("Excessão tratada: " + ex.Message);
            }
        }
        public void Metodo2() 
        {
            Metodo3();
        }
        public void Metodo3() 
        {
            Metodo4();
        }
        public void Metodo4() 
        {
            throw new Exception("Ocorre uma exceção.");
        }
    }
}