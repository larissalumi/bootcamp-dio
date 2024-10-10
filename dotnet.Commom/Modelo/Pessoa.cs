using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Common.Modelo // Convenção: usar o mesmo nome da pasta
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; } = "[Erro: nome não identificado]";
        // { get; set; } significa que a variável não pode ser nula, logo, foi preciso adicionar um valor a ela antes de sair do construtor
        public int Idade { get; set; }
/// <summary>
/// faz a pessoa se apresentar, mostrando o seu nome e a idade
/// </summary>
        public void Apresentar()
        {
            Console.Write($"Nome: {Nome}\nIdade: {Idade} anos\n");
        }
    }
}