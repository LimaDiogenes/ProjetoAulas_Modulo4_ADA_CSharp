using ProjetoAulas;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Transforma DEV");
app.ExerciciosEndpoint();
app.Run();



////1) Crie um array de strings com 5 elementos e preencha-o com os nomes de 5 capitais brasileiras.
////Em seguida, imprima o nome de cada capital na tela.

//string[] capitais = new string[5] { "Curitiba", "Joao Pessoa", "Sao Paulo", "Belo Horizonte", "Recife"};
//foreach (var a in capitais)
//{
//    Console.WriteLine("Capital: " + a);
//}

////2) Crie um array bidimensional de inteiros com 3 linhas e 4 colunas.
////Inicialize todos os elementos do array com o valor 9. Em seguida, imprima o valor de cada elemento do array na tela.

//int[,] nove = new int[3, 4];
//for(int i = 0; i < nove.GetLength(0); i++)
//{
//    for (int j = 0;  j < nove.GetLength(1); j++)
//    {
//        nove[i, j] = 9;
//        Console.WriteLine(nove[i, j]);
//    }
//}


