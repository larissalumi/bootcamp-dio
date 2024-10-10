using System.ComponentModel;
using System.Security.AccessControl;
using dotnet.Common.Modelo;

/* //   Display Exemplo
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Larissa";
pessoa1.Idade = 18;
pessoa1.Apresentar();
 */

/* //   Operadores de Atribuição

int a = int.Parse("5"); // "5" é uma string, não int, por isso precisamos converter
Console.WriteLine(a);

int b = Convert.ToInt32(null);
Console.WriteLine(b);
*/

/* //   Operadores Aritméticos
Calculadora calc = new Calculadora ();

calc.Soma(3, 1);
calc.Subtracao(30, 10);
calc.Multiplicacao(30, 10);
calc.Divisao(30, 10);
calc.Potencia(2, 8);
calc.Seno(30);
calc.Cosseno(60);
calc.Tangente(30);
calc.Incremento(10);
calc.Decremento(10); */

/* //   Estruturas de repetição

int numero = 4;

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

// while e do while também são iguais à linguagem C
*/

/* //   Estrutura de um programa C#
    // Evitar duplicar o código ao máximo!! -> projeto auxiliar

    //  Agora é possível referenciar o projeto de outra pasta usando o sln
    //  Demonstração:

    Pessoa pessoa1 = new Pessoa();

    pessoa1.Nome = "Larissa";
    pessoa1.Idade = 18;
    pessoa1.Apresentar();

    // Converter para outra versão:
    //     dotnet new console --framework net 5.0
    //     dotnet new console --framework net 6.0 
    //     dotnet new console      // versão mais recente  

    //     (necessário ter a versão instalada)
    //     versão 5 ou anteriores -> aparece o método Main 
*/

/* //   Array
int[] array1 = new int[3];
int[] array2 = [1, 2, 3, 5];
string[] meses = ["Jan", "Fev"];

Console.WriteLine(array2[0]);
Console.WriteLine(meses[1]);

array1[0] = 1;
array1[1] = 3;
array1[2] = 5;

Console.WriteLine(array1[2]);

Console.WriteLine("Elementos do array 1:");
        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine($"Posição {i+1}: {array1[i]}");
        }

Console.WriteLine("Elementos do array 1 com FOREACH:");
        foreach (int numero in array1)
        {
            Console.WriteLine(numero);
            // para fazer do mesmo jeito que o FOR, seria necessário criar um contador
        }

*/

/* //   Lista
List<string> materiaisPapelaria =
[
    "lapis",
    "caneta",
    "papel",
    "borracha",
    "apontador",
];

Console.WriteLine("Materiais disponiveis na papelaria:");
foreach (string material in materiaisPapelaria)
{
    Console.WriteLine(material);
}

Console.WriteLine(materiaisPapelaria.Count);

materiaisPapelaria.Add("lapiseira");
materiaisPapelaria.Remove("apontador");
materiaisPapelaria.Add("grafite");

Console.WriteLine(materiaisPapelaria.Count);

Console.WriteLine("Atualização de materiais disponiveis na papelaria:");
foreach (string material in materiaisPapelaria)
{
    Console.WriteLine(material);
}

//perceba que em momento algum foi necessário se preocupar com o tamanho da lista

 */
