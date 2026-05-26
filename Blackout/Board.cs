using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackout
{
    public class Board
    {
        private Cells[,] boardCells;
        public int[,] board;

        private PrototypeView view;


        public void CreateBoardOfCells(int boardSize)
        {
            Cells[,] newCellsBoard = new Cells[boardSize, boardSize];

            //Conta quantas peças estão ativas
            //Serve para caso estejam todas, ele sair dps do while
            for (int i = 0; i < newCellsBoard.GetLength(0); i++) 
            { 
                for (int j = 0; j < newCellsBoard.GetLength(1); j++) 
                { 
                    newCellsBoard[i, j] = new Cells(); 
                } 
            }  

            boardCells = newCellsBoard;
        }


        public Cells[,] GetBoardOfCells()
        {
            return boardCells;
        }

        public void ChangeBoardCellsValue(int x, int y, Cells[,] board)
        {
            //
            //Estes trys todos basicamente vão verificar se a peça está ativa ou não
            //Tanto a peça selecionada com as em volta
            //Dependendo de como estiver, ele inverte o estado
            //Caso a peça não exista, ele simplesmente não faz nada (por isso os trys)
            //
            try
            {
                board[x,y].ChangeState();
            }
            
            catch
            {
                    
            }
           
            try
            {
                board[x+1,y].ChangeState();
            }
            catch
            {
                    
            }
            
            try
            {
                board[x-1,y].ChangeState();
            }
                
            catch
            {
                    
            }

            try
            {
                board[x,y+1].ChangeState();
            }
            catch
            {
                    
            }

            try
            {
                board[x,y-1].ChangeState();
            }
            catch
            {
                    
            }
            
            
        }
        
    }
}