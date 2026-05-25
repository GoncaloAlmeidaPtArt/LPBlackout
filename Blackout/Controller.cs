using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackout
{
    public class Controller
    {
        public void Run(PrototypeView view, Board board)
        {
            int dificulty = 0;
            dificulty = view.DificultyInput(dificulty);

            int[,] list;

            bool isChoiceMade = false;

            int totalOfActiveCells = 0;

            while(isChoiceMade == false)
            {
                switch (dificulty)
                {
                case 0:
                    board.CreateBoard(3);
                    isChoiceMade = true;
                    totalOfActiveCells = 9;
                break;

                case 1:
                    board.CreateBoard(5);
                    isChoiceMade = true;
                    totalOfActiveCells = 25;
                break;

                case 2:
                    board.CreateBoard(8);
                    isChoiceMade = true;
                    totalOfActiveCells = 64;
                break;
                default:
                break;
                }
            }

            list = board.GetBoard();

            int numberOfActiveCells = 0;
    
            //
            //Estepedaço de codigo basicamente altera a posiçao que o jogador selecionou
            //Assim como todas as peças em torno dela
            //No final conta quantas peças estão ativas
            //Só quando todas elas tiverem ativas é que sai do while
            //
            while(numberOfActiveCells != totalOfActiveCells)
            {
                

                view.ShowGrid(list);

                //Reseta a conagem de peças, para não somar as da jogada anterior
                numberOfActiveCells = 0;

                int coordinateX = 0;

                int coordinateY = 0;

                (coordinateX, coordinateY) = view.CoordinatesInput(coordinateX, coordinateY);
                

                board.ChangeCellsValue(coordinateX, coordinateY, list);
                
                
                //Conta quantas peças estão ativas
                //Serve para caso estejam todas, ele sair dps do while
                for (int i = 0; i < list.GetLength(0); i++) 
                { 
                    for (int j = 0; j < list.GetLength(1); j++) 
                    { 
                        numberOfActiveCells +=list[i, j]; 
                    } 
                }  

            }  

            view.ShowGrid(list);
            view.ShowVictoryMensage();
            
        }
    }
}