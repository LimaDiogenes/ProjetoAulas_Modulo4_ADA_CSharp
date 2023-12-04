using ProjetoAulas;

//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Transforma DEV");
//app.ExerciciosEndpoint();
//app.Run();

Exercicios.TaskScheduler tarefas = new();

Task<string> tarefa1 = Task.Run(() => "Fazendo alguma coisa 1");
Task<string> tarefa2 = Task.Run(() => "Fazendo outra coisa 2");
Task<string> tarefa3 = Task.Run(() => "Realizando uma tarefa 3");
Task<string> tarefa4 = Task.Run(() => "Trabalhando em algo 4");
Task<string> tarefa5 = Task.Run(() => "Executando uma operação 5");
Task<string> tarefa6 = Task.Run(() => "Concluindo uma atividade 6");
Task<string> tarefa7 = Task.Run(() => "Desenvolvendo uma funcionalidade 7");
Task<string> tarefa8 = Task.Run(() => "Testando uma aplicação 8");
Task<string> tarefa9 = Task.Run(() => "Preparando um relatório 9");
Task<string> tarefa10 = Task.Run(() => "Respondendo a emails 10");

tarefas.AddTask(tarefa1);
tarefas.AddTask(tarefa2);
tarefas.AddTask(tarefa3);
tarefas.AddTask(tarefa4);
tarefas.AddTask(tarefa5);
tarefas.AddTask(tarefa6);
tarefas.AddTask(tarefa7);
tarefas.AddTask(tarefa8);
tarefas.AddTask(tarefa9);
tarefas.AddTask(tarefa10);

tarefas.RunTasks(5);
Console.WriteLine("Aperte enter para continuar");
Console.ReadLine();
tarefas.RunTasks(3);
Console.WriteLine("Aperte enter para continuar");
Console.ReadLine();
tarefas.RunTasks(3);


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


