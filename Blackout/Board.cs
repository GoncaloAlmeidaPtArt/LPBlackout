using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackout
{
    public class Board
    {
        
        public int[,] board;

        private PrototypeView view;

        public void CreateBoard(int boardSize)
        {
            int[,] newBoard = new int[boardSize, boardSize];

            //Conta quantas peças estão ativas
            //Serve para caso estejam todas, ele sair dps do while
            for (int i = 0; i < newBoard.GetLength(0); i++) 
            { 
                for (int j = 0; j < newBoard.GetLength(1); j++) 
                { 
                    newBoard[i, j] = 0; 
                } 
            }  

            board = newBoard;
        }

        public int[,] GetBoard()
        {
            return board;
        }

        public void ChangeCellsValue(int x, int y, int[,] board)
        {
            //
            //Estes trys todos basicamente vão verificar se a peça está ativa ou não
            //Tanto a peça selecionada com as em volta
            //Dependendo de como estiver, ele inverte o estado
            //Caso a peça não exista, ele simplesmente não faz nada (por isso os trys)
            //

            bool error = false;
            try
            {
                if(board[x,y] == 0)
                {
                    board[x,y] = 1;
                }
                else
                {
                    board[x,y] = 0;
                }
            }
            catch
            {
                view.ShowErrorInvalidCoordinateMensage();
                error = true;
            }

            if(error == false)
            {
                try
                {
                    if(board[x+1,y] == 0)
                    {
                        board[x+1,y] = 1;
                    }
                    else
                    {
                        board[x+1,y] = 0;
                    }
                }
                catch
                {
                    
                }
            }
            

            if(error == false)
            {

                try
                {
                    if(board[x-1,y] == 0)
                    {
                        board[x-1,y] = 1;
                    }
                    else
                    {
                        board[x-1,y] = 0;
                    }
                }
                catch
                {
                    
                }
            }

            if(error == false)
            {

                try
                {
                    if(board[x,y+1] == 0)
                    {
                        board[x,y+1] = 1;
                    }
                    else
                    {
                        board[x,y+1] = 0;
                    }
                }
                catch
                {
                    
                }
            }


            if(error == false)
            {

                try
                {
                    if(board[x,y-1] == 0)
                    {
                        board[x,y-1] = 1;
                    }
                    else
                    {
                        board[x,y-1] = 0;
                    }
                }
                catch
                {
                    
                }
            }
            
        }
        
    }
}