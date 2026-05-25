using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Spectre.Console;

namespace Blackout
{
    public class PrototypeView : IView
    {
       

        public int Dificuldade(int dif)
        {
            while (true)
            {
                try
                {
                    //Pergunta ao jogador qual a dificuldade do jogo
                    Console.WriteLine("Qual é o nivel de dificuldade do jogo ?");
                    Console.WriteLine("0 - Facil, 1 - Medio, 2 - Dificil");
                    dif = Convert.ToInt32(Console.ReadLine());
                    return dif;
                }
                catch
                {
                    
                }
            }
        }
        
        public void ListagemBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++) 
            { 
                for (int j = 0; j < board.GetLength(1); j++) 
                { 
                    Console.Write(board[i, j]); 
                } 
                Console.WriteLine();
            }  
        }

         public void ShowGrid(int[,] board)
        {
            Canvas grid = new Canvas(board.Length, board.Length);
            for (int x = 0; x < board.GetLength(0); x++) 
            {
                for (int y = 0; y < board.GetLength(1); y++) 
                {
                    if(board[x, y] == 0)
                    {
                        grid.SetPixel(x, y, Color.Aqua);
                    }
                    else
                    {
                        grid.SetPixel(x, y, Color.DeepPink4_2);
                    }
                }
            }

            

            AnsiConsole.Write(grid);
        }

        public (int, int) Coordenadas(int x, int y)
        {
            //Pede as cordenadas da peça
            Console.WriteLine("Coloca o X que desejas alterar");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coloca o Y que desejas alterar");
            y = Convert.ToInt32(Console.ReadLine());

            return (x, y);

        }
    }
}