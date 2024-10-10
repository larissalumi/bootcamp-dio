using System.Data.Common;
using System.Globalization;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using novo.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

/* Pessoa p1 = new Pessoa();
p1.Nome = "Larissa";
p1.Sobrenome = "Lumi";
p1.Idade = 18;

p1.Apresentar(); */

/* // Curso
Pessoa p1 = new Pessoa(nome: "Larissa", sobrenome: "Lumi");

Pessoa p2 = new Pessoa(nome:"Marcia", sobrenome: "Terumi");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos(); */

/* // Manipulando valores
decimal valorMonetario = 82.40M;

Console.WriteLine($"{valorMonetario:C}"); // saída em reais, pois é a região do meu sistema

DateTime data1 = DateTime.Now;
Console.WriteLine(data1.ToString("dd/MM/yy HH:mm"));

string dataString = "2024-09-30 21:43";

bool sucesso = DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime data);

if(sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"Essa não é uma data válida.");
} */

/* // Exceções
// Leitura de um Arquivo
try 
{
    string[] linhas = File.ReadAllLines("Arquivo/aleitura.txt");

    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Erro {ex.Message}, favor verificar se o nome do arquivo está correto.");
}   // Exception Específica
catch(Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}    // Exception Genérica
*/

/* // Coleções
// Fila
Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

Console.WriteLine("Elementos na fila após Enqueue:");
foreach (int item in fila)
    {
        Console.WriteLine(item);
    }

int removidoQ = fila.Dequeue();
Console.WriteLine($"\nElemento removido: {removidoQ}");

Console.WriteLine("\nElementos na fila após Dequeue:");
foreach (int item in fila)
    {
        Console.WriteLine(item);
    }


int proximo = fila.Peek();
Console.WriteLine($"\nPróximo elemento na fila (Peek): {proximo}");

// Pilha
Stack<int> pilha = new Stack<int>();

pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);

Console.WriteLine("Elementos na pilha após Push:");
foreach (int item in pilha)
{
    Console.WriteLine(item);
}

int removidoS = pilha.Pop();
Console.WriteLine($"\nElemento removido (Pop): {removidoS}");


Console.WriteLine("\nElementos na pilha após Pop:");
foreach (int item in pilha)
{
    Console.WriteLine(item);
}

int topo = pilha.Peek();
Console.WriteLine($"\nElemento no topo da pilha (Peek): {topo}");

// Dictionary
Dictionary<string, int> pessoas = new Dictionary<string, int>();

// Adicionando elementos ao dicionário
pessoas.Add("Ana", 30); // o primeiro elemento é a chave e o segundo é um valor
pessoas.Add("João", 25);
pessoas.Add("Maria", 28);

Console.WriteLine("Pessoas no dicionário:");
foreach (var pessoa in pessoas)
{
    Console.WriteLine($"Nome: {pessoa.Key}, Idade: {pessoa.Value}");
}

pessoas.Remove("Ana");
Console.WriteLine("\nDicionário após remover Ana:");
foreach (var pessoa in pessoas)
{
    Console.WriteLine($"Nome: {pessoa.Key}, Idade: {pessoa.Value}");
}

pessoas["Maria"] = 35;

// Tentando verificar uma chave que não existe
if (pessoas.ContainsKey("Carlos"))
{
    Console.WriteLine($"Carlos está no dicionário e tem {pessoas["Carlos"]} anos.");
}
else
{
    Console.WriteLine("Carlos não está no dicionário.");
}

// Acessando o valor de uma chave específica usando TryGetValue
if (pessoas.TryGetValue("João", out int idadeJoao))
{
    Console.WriteLine($"\nIdade do João: {idadeJoao}");
}
else
{
    Console.WriteLine("\nJoão não encontrado.");
}
*/

/* // Tuplas, Operador Ternário e Desconstrução
// Tupla

(int id, string nome, string sobrenome, double altura) pessoa = (1, "Ana", "Silva", 1.75);
//ValueTuple<int, string, string, double> alternativa = (1, "Ana", "Silva", 1.75);
//var outroExemplo = Tuple.Create(1, "Ana", "Silva", 1.75);

Console.WriteLine($"ID: {pessoa.id}");
Console.WriteLine($"Nome: {pessoa.nome}");
Console.WriteLine($"Sobrenome: {pessoa.sobrenome}");
Console.WriteLine($"Altura: {pessoa.altura}m");

// No Método

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("arquivo/leitura.txt");

if(sucesso)
{
    Console.WriteLine("Quantidade de Linhas: " + quantidadeLinhas);
    foreach(string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
} 

// Desconstrutor
Pessoa p1 = new Pessoa("Maria", "Clara");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");

// IF Ternário

int numero = 15;
bool ehPar = false;

ehPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));
*/

// Nuget, Serializar e Atributos no C#
/* // Serialização
DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual); //para executar, tirar o desconto
Venda v2 = new Venda(2, "Licença de software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivo/vendas.json", serializado); //

Console.WriteLine(serializado); */

/* // Deserialização: Processo Inverso:
// percebe que é no formato json, em uma lista (colchetes)
// cria uma classe
// cria uma Lista

string conteudoArquivo = File.ReadAllText("Arquivo/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}\nProduto: {venda.Produto}\nPreço: {venda.Preco}\nData: {venda.DataVenda:dd/MM/yyyy HH:mm}\n" +
                      $"{(venda.Desconto.HasValue ? $"Desconto: {venda.Desconto}\n" : "")}");
} */

/* // Tipos Especiais
// Nullable -> vazio: uso se ? após o tipo

// Anonimo
var tipoAnonimo = new { Nome = "Larissa", Sobrenome = "Lumi", Altura = 1.56 };

Console.WriteLine("Nome:" + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome:" + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura:" + tipoAnonimo.Altura);


string conteudoArquivo = File.ReadAllText("Arquivo/vendas.json");
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

foreach(var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}

// Dinâmico: maior flexibilidade, mas com menos segurança de tipos

dynamic variavelDinamica = 4;
Console.WriteLine($"Tipo: {variavelDinamica.GetType()}\nValor: {variavelDinamica}");

variavelDinamica = "Texto";
Console.WriteLine($"Tipo: {variavelDinamica.GetType()}\nValor: {variavelDinamica}");

variavelDinamica = true;
Console.WriteLine($"Tipo: {variavelDinamica.GetType()}\nValor: {variavelDinamica}");

// Classes genericas

MeuArray<int> arrayInteiro = new MeuArray<int>();
arrayInteiro.AdicionarElementoArray(30);
Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AdicionarElementoArray("Agora exigiu uma string ao invés de int");
Console.WriteLine(arrayString[0]);

// Métodos de extensão
int numero = 15;
bool par = false;

par = numero.EhPar();

Console.WriteLine($"O número {numero} é {(par ? "par" : "impar")}"); */

//

