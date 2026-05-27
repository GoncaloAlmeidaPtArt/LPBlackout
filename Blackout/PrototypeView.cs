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
        /// Method for determining the game's difficulty
        /// Ask the user to select a difficulty level, collect the response, and send it to an integer in the class that called it
        /// </summary>
        /// <param name="dif"></param>
        /// <returns></returns>
        public int DificultyInput(int dif)
        {
            while (true)
            {
                try
                {
                    //Ask the player what the game's difficulty level is
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
        

        /// <summary>
        /// Method for displaying the current state of the board to the user
        /// </summary>
        /// <param name="board">tabuleiro a ser mostrado</param>
        public void ShowCellsGrid(Cells[,] board)
        {

            //Add a space between the user's response and the board
            Console.WriteLine();
            Console.WriteLine();

            //Creates two integers with the dimensions of the array it receives
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            //Creates an array with the sizes of the integers it receives
            Canvas canvas = new Canvas(cols, rows);

            //Place the numbers on top of the board
            string header = "";
            for(int col = 0; col < board.GetLength(0); col++)
            {
                header += col + " ";
            }
            Console.WriteLine(header);

            //Assigns a color to each item based on its condition
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    if (board[y, x].GetState() == false)
                        canvas.SetPixel(x, y, Color.Aqua);
                    else
                        canvas.SetPixel(x, y, Color.DeepPink4_2);
                }
            }

            // Creates a string containing the numbers corresponding to the number of lines
            string rowNumbers = "";
            for (int x = 0; x < rows; x++)
            {
                rowNumbers += x + "\n";
            }

            //Create a table that includes both the image of the board and the row numbers
            var grid = new Spectre.Console.Grid();
            grid.AddColumn();
            grid.AddColumn();
            grid.AddRow(canvas, new Markup(rowNumbers));

            //Increase the size of the board
            canvas.MaxWidth = 10;
            //Show the board
            AnsiConsole.Write(grid);
        }

        /// <summary>
        /// A method for letting the player know they've won the game
        /// </summary>
        public void ShowVictoryMensage()
        {
            Console.WriteLine("Congractulations");
        }

        /// <summary>
        /// Method for informing the player that the entered coordinate does not exist
        /// </summary>
        public void ShowErrorInvalidCoordinateMensage()
        {
            Console.WriteLine("Coordenada invalida");
        }

        /// <summary>
        /// Prompts the user for coordinates and sends them to the method that called it
        /// as two different ints (namely X and Y)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public (int, int) PlayerCoordinatesInput(int x, int y)
        {
            //Ask the user for the line number
            Console.WriteLine("Coloca a linha que desejas alterar");

            //If “exit” is entered, it returns the exit value
            string xInput = Console.ReadLine();
            if(xInput == "exit")
            {
                return (-1, -1);
            }

            //Ask the user for the column position
            Console.WriteLine("Coloca a coluna que desejas alterar");
            string yInput = Console.ReadLine();
            
            //If “exit” is entered, it returns the exit value
            if(yInput == "exit")
            {
                return (-1, -1);
            }
          
            //Try converting the received data to ints
            //If it fails, it means the coordinate is invalid, so it returns a response
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

        /// <summary>
        /// Displays a farewell message to the user after they select “Exit”
        /// </summary>
        public void ShowExitMensage()
        {
            Console.WriteLine("Obrigado por jogar");
        }
    }
}