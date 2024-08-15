// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Isso é um comentário

int numeroInteiro = 1;
float numeroDecimal = 25.09887f;
double numeroDecimalPreciso = 25.0193919319489194;
string texto = "Isso é um texto";
char caracter = 'a';

//Collections
List<string> lista = new List<string>{"nome", "Telefone"};
Queue<string> queue = new Queue<string>();
Stack<string> stack = new Stack<string>();
Dictionary<string, int> dictionary = new Dictionary<string, int>();

if(texto == "Não é um texto") Console.WriteLine(texto);
else Console.WriteLine("que texto");

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

foreach(string str in lista)
{
    Console.WriteLine(str);
}