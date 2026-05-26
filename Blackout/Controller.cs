using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Blackout
{
    public class Controller
    {
        public void Run(PrototypeView view, Board board)
        {
            int dificulty = 0;
            dificulty = view.DificultyInput(dificulty);

            Cells[,] list;

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

            list = board.GetBoardOfCells();
           
    
            //
            //Estepedaço de codigo basicamente altera a posiçao que o jogador selecionou
            //Assim como todas as peças em torno dela
            //No final conta quantas peças estão ativas
            //Só quando todas elas tiverem ativas é que sai do while
            //
            while(true)
            {
                view.ShowCellsGrid(list);

                int coordinateX = 0;
                int coordinateY = 0;

                bool isVictory = true;

                (coordinateX, coordinateY) = view.PlayerCoordinatesInput(coordinateX, coordinateY);

                if(coordinateX == -1 || coordinateY == -1)
                {
                    view.ShowExitMensage();
                    break;
                }

                if(coordinateX == -2 || coordinateY == -2 || 
                coordinateX < 0 || coordinateX >= list.GetLength(0) ||
                coordinateY < 0 || coordinateY >= list.GetLength(1))
                {
                    view.ShowErrorInvalidCoordinateMensage();
                    continue;
                }

                else
                {
                    board.ChangeBoardCellsValue(coordinateX, coordinateY, list);

                    for (int i = 0; i < list.GetLength(0); i++) 
                    { 
                        for (int j = 0; j < list.GetLength(1); j++) 
                        { 
                            if(list[i,j].GetState() == false)
                            {
                                isVictory = !isVictory;
                                break;
                            }  
                        } 
                    }

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