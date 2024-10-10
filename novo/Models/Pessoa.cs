using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace novo.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome; //armazena os valores - privado
        private int _idade;
        public string Nome 
        {
            get => _nome.ToUpper(); // return _nome = value


            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                    // o programa será encerrado
                }

                _nome = value;
            }
         }
        public int Idade 
        {
            get => _idade;
            set
            {
                if(value < 0){
                    throw new ArgumentException("Idade invalida!");
                }
                _idade = value;
            } 
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}\nIdade: {Idade}");
        }
    }
}