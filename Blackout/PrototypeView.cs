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
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dif"></param>
        /// <returns></returns>
        public int DificultyInput(int dif)
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
        

        public void ShowCellsGrid(Cells[,] board)
        {
            Canvas grid = new Canvas(board.GetLength(0), board.GetLength(1));

            for (int x = 0; x < board.GetLength(0); x++) 
            {
                for (int y = 0; y < board.GetLength(1); y++) 
                {
                    if(board[y,x].GetState() == false)
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

        public void ShowVictoryMensage()
        {
            Console.WriteLine("Congractulations");
        }

        public void ShowErrorInvalidCoordinateMensage()
        {
            Console.WriteLine("Coordenada invalida");
        }

        public (int, int) PlayerCoordinatesInput(int x, int y)
        {
            Console.WriteLine("Coloca o Y que desejas alterar");
            string xInput = Console.ReadLine();
            if(xInput == "exit")
            {
                return (-1, -1);
            }


            Console.WriteLine("Coloca o X que desejas alterar");
            string yInput = Console.ReadLine();
            if(yInput == "exit")
            {
                return (-1, -1);
            }
          
            try
            {
                x = Convert.ToInt32(xInput);
                y = Convert.ToInt32(yInput);

                return (x, y);
            }
            catch
            {
                return (-2, -2);
            }
        }

        public void ShowExitMensage()
        {
            Console.WriteLine("Obrigado por jogar");
        }
    }
}