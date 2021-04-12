using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            
           decimal n1, n2, n3, n4, media;
           
           Console.Clear();
           Console.ForegroundColor = ConsoleColor.Yellow;
           Console.WriteLine("\n■■ M E D I A   D O   A L U N O ■■");
           Console.ResetColor();
           Console.ForegroundColor = ConsoleColor.Green;

           Console.Write("Digite sua primeira NOTA: ");
           n1 = Convert.ToDecimal(Console.ReadLine());
           if   (n1 < 0 || n1 > 10)
               
           {
               Console.WriteLine($"Digite somente notas entre 0 e 10.");
               Environment.Exit(-1);
           }
           Console.Write("Digite sua segunda NOTA: ");
           n2 = Convert.ToDecimal(Console.ReadLine());
           if   (n2 < 0 || n2 > 10)
               
           {
               Console.WriteLine($"Digite somente notas entre 0 e 10.");
               Environment.Exit(-1);
           }
           Console.Write("Digite sua terceira NOTA: ");
           n3 = Convert.ToDecimal(Console.ReadLine());
           if   (n3 < 0 || n3 > 10)
               
           {
               Console.WriteLine($"Digite somente notas entre 0 e 10.");
               Environment.Exit(-1);
           }
           Console.Write("Digite sua quarta NOTA: ");
           n4 = Convert.ToDecimal(Console.ReadLine());
           if   (n4 < 0 || n4 > 10)
               
           {
               Console.WriteLine($"Digite somente notas entre 0 e 10.");
               Environment.Exit(-1);
           }
           
           else
           {
              media = (n1 + n2 + n3 + n4) / 4;
              if (media > 6)
              {
                Console.WriteLine($"A sua média é {media}. Resultado: Aprovado"); 
              }
              if (media < 5 )
              {
                  Console.WriteLine($"A sua média é {media}. Resultado: Reprovado"); 
              }
              else if (media >=5 & media <= 6)
              {
                  Console.WriteLine($"\nA sua média é {media}. Resultado: Recuperação"); 
              }
           }
           
           Console.WriteLine("\nTodos direitos reservado a Fabiano®");
           Console.ResetColor();
        }
    }
}
