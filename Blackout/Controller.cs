using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Spectre.Console;

namespace Blackout
{
    public class Controller
    {
        /// <summary>
        /// A method that runs the entire game, from start to finish
        /// </summary>
        /// <param name="view"></param>
        /// <param name="board"></param>
        public void Run(PrototypeView view, Board board)
        {
            //Ask for it and you'll get a challenging game
            int dificulty = 0;
            dificulty = view.DificultyInput(dificulty);

            //Create a list that will serve as a board
            Cells[,] list;

            //Check which difficulty level the player selected
            //Depending on the difficulty level, call the method for creating a board
            //based on that same difficulty
            bool isChoiceMade = false;
            while(isChoiceMade == false)
            {
                switch (dificulty)
                {
                case 0:
                    board.CreateBoardOfCells(3);
                    isChoiceMade = true;
                break;

                case 1:
                    board.CreateBoardOfCells(5);
                    isChoiceMade = true;
                break;

                case 2:
                    board.CreateBoardOfCells(8);
                    isChoiceMade = true;
                break;
                default:
                break;
                }
            }

            //Receive the board that was created
            list = board.GetBoardOfCells();
           
    
            //While where the program's core runs
            //Ask for the coordinates, and depending on the coordinates
            //Leave the game, say they're invalid, or change the rules
            while(true)
            {
                //Show the board
                view.ShowCellsGrid(list);

                //Create a “win” variable to determine whether the player has won
                bool isVictory = true;

                //Create it and ask the player for the coordinates
                int coordinateX = 0;
                int coordinateY = 0;
                (coordinateX, coordinateY) = view.PlayerCoordinatesInput(coordinateX, coordinateY);
                
                

                //If the coordinates match those of the exit, you leave the game
                if(coordinateX == -1 || coordinateY == -1)
                {
                    view.ShowExitMensage();
                    break;
                }

                //If the coordinates are incorrect, it indicates that they are invalid
                if(coordinateX == -2 || coordinateY == -2 || 
                coordinateX < 0 || coordinateX >= list.GetLength(0) ||
                coordinateY < 0 || coordinateY >= list.GetLength(1))
                {
                    view.ShowErrorInvalidCoordinateMensage();
                    continue;
                }

                else
                {
                    //Swap the cells on the board with their opposites (based on their coordinates)
                    board.ChangeBoardCellsValue(coordinateX, coordinateY, list);

                    //A for loop nested inside another for loop that checks whether any cells are disconnected
                    for (int i = 0; i < list.GetLength(0); i++) 
                    { 
                        for (int j = 0; j < list.GetLength(1); j++) 
                        { 
                            if(list[i,j].GetState() == false)
                            {
                                //If a cell is disconnected, set Victory to false
                                isVictory = false;
                            }  
                        } 
                    }

                    //If there are no disconnected cells, it displays the board and indicates that you have won the game
                    if(isVictory == true)
                    {
                        view.ShowCellsGrid(list);
                        view.ShowVictoryMensage();
                        view.ShowExitMensage();
                        break;
                    } 
                }  
            }
            
            
        }
    }
}