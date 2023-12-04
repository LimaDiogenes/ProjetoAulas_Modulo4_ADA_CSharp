

namespace ProjetoAulas

{
    public static class Exercicios
    {
        public static void ExerciciosEndpoint(this WebApplication app)
        {
            //string[] namesTest = new[]
            //{
            //    "Mario", "Luigi", "Peach", "Wario", "Bowser", "Yoshi", "Sonic", "Tails", "Knuckles", "Kratos", "Lara", "Ezio",
            //    "Niko", "Carl", "Trevor", "Michael", "Franklin", "Luffy", "Zoro", "Brook", "Usopp", "Sanji", "Chopper", "Franky", "Nami", "Robin",
            //    "John", "Arthur", "Leon", "Jill", "Eddie", "Christie", "Heihachi", "Yoshimitsu", "Crash", "Neo", "Coco", "Tiger", "Dingodile"
            //};

            Console.Clear();

            // Batata quente
            string[] tk = new[] { "Eddie", "Christie", "Heihachi", "Yoshimitsu" };
            string[] mb = new[] { "Mario", "Luigi", "Peach", "Wario", "Bowser", "Yoshi" };
            string[] op = new[] { "Luffy", "Zoro", "Brook", "Usopp", "Sanji", "Chopper", "Franky", "Nami", "Robin" };

            //int minTk = tk.Length;
            //int maxTk = tk.Length * 3;
            //var test1 = BatataQuente(tk, minTk, maxTk);

            //var test2 = EBatataQuente(mb, 3, 3);

            //var test3 = BatataQuente(op, 1, 7);

            //app.MapGet("/exercicioBatataQuente", () => { return test3; });

            app.MapGet("/exercicioPalindromo", () =>
            {
                return
                $"{IsPalindromo("ADA")}\n" +
                $"{IsPalindromo("Lovelace").ToString()}\n" +
                $"{IsPalindromo("ímpar").ToString()}\n" +
                $"{IsPalindromo("Omissíssimo")}\n" +
                $"{IsPalindromo("A grama é amarga")}\n" +
                $"{IsPalindromo("2002")}\n" +
                $"{IsPalindromo("A mala nada na lama")}\n";
            });            
        }


        //    ## Collections: Queue => Exercícios

        //1) Escreva uma função que simule o jogo de batata quente.Nesse jogo, jogadores passam a batata quente por um círculo até ela explodir.
        //O jogador que estiver com a batata quando explodir está fora do jogo. Utilize filas para resolver esse problema.

        //```csharp
        /// <summary>
        ///  Recebe os nomes dos jogadores atraves de uma array de strings
        /// </summary>
        /// <param name="players">Nome dos jogadores</param>
        /// <returns></returns>
        public static string BatataQuente(string[] players, int minPasses, int maxPasses)
        {
            Queue<string> names = new();

            foreach (string p in players) // adiciona todos os jogadores a fila de nomes
            {
                names.Enqueue(p);
            }

            Random random = new Random();
            string dots = ".";

            while (names.Count>1)
            {
                // int potato = random.Next(names.Count, names.Count * 3); versao +  mais longa, circula pelo menos 1 vez
                int potato = random.Next(minPasses, maxPasses); 

                for (int counter = 0; counter < potato; counter++)
                {
                    string actualPlayer = names.Peek();
                    names.Dequeue(); // remove do comeco da fila
                    names.Enqueue(actualPlayer); // recoloca no final da fila

                    dots += ".";
                    Console.WriteLine("Nova rodada:");
                    Console.WriteLine($"Batata quente está na mão de {actualPlayer}");
                    Console.WriteLine($"Esquentando{dots}");
                    Thread.Sleep(300);               
                }

                dots = ".";
                Console.WriteLine();
                Console.WriteLine("****************************");
                string eliminatedPlayer = names.Dequeue();
                Console.WriteLine("*** Batata explodiu! ***");                
                Console.WriteLine($"Jogador(a) eliminado(a): {eliminatedPlayer}");
                Console.WriteLine("****************************");
                Console.WriteLine();
                Thread.Sleep(1000);                

            }
            string winner = names.Dequeue();
            Console.WriteLine($"******************************\nVencedor(a): {winner}\n******************************");
            return $"Vencedor(a): {winner}";
        }



        //```

        //2) Escreva uma função que verifique se uma determinada string é um palíndromo.
        //Uma palavra é um palíndromo quando a leitura da direita para esquerda e da esquerda para direita aão iguais.
        //Utilize filas para resolver esse problema.

        //```csharp
        public static string IsPalindromo(string wordOrPhrase)
        {           
            var word = wordOrPhrase.Replace(" ", ""); // retira espacos em branco
            
            Queue<char> chars = new();
            Queue<char> left = new();
            Queue<char> right = new();

            foreach (char letter in word)
            {
                char w = letter.ToString().ToUpper()[0];
                chars.Enqueue(w);
            }

            int wordSize = chars.Count();
            int halfWord = (int)Math.Floor((double)wordSize / 2);

            for (int i = 0; i < halfWord; i++)
            {
                char c = chars.Dequeue();
                left.Enqueue(c);
            }

            if (wordSize % 2 != 0)
            {
                chars.Dequeue();   // remove a letra do meio caso contagem de letras da palavra seja impar
            }

            int remainingSize = chars.Count();
            Stack<char> rightStack = new();
            for (int k = 0; k < remainingSize; k++)
            {
                rightStack.Push(chars.Dequeue()); // retira da primeira posicao da fila, adicionando a pilha,
                                                  // para poder inverter a ordem, ex.: 1, 2, 3, 4 
            }

            foreach (char r in rightStack) // coloca os caracteres em ordem reversa, ex.: 4, 3, 2, 1
            {
                right.Enqueue(r);
            }

            controle();

            for (int j = 0; j < halfWord; j++)
            {
                char lChar = left.Dequeue();
                char rChar = right.Dequeue();
                if (lChar != rChar)
                {
                    string notPalindrome = $"\n{wordOrPhrase.ToUpper()} não é um palíndromo!\n";
                    Console.WriteLine(notPalindrome);
                    Console.WriteLine("________________________________________");
                    return notPalindrome;
                }
            }
            string isPalindrome = $"\n{wordOrPhrase.ToUpper()} é um palíndromo\n";
            Console.WriteLine(isPalindrome);
            Console.WriteLine("________________________________________");
            return isPalindrome;




            void controle()
            {
                Console.WriteLine();
                Console.Write("Lado esquerdo: ");
                foreach (var letter in left)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
                Console.Write("Lado direito: ");
                foreach (var letter in right)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
            }        
        }

        //```

        //3) Um escalonador de tarefas é um sistem que gerencia a execução de tarefas no computador.Utilize filas para implementar um escalonador de tarefas simples, que execute elas na ordem que forem submetidas.A função não precisa ter nenhum retorno. Obs: As tarefas executam por um período x de tempo.

        //```csharp



        //```
    }

}
