using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackout
{
    public class Board
    {
        private Cells[,] boardCells;


        public void CreateBoardOfCells(int boardSize)
        {
            Cells[,] newCellsBoard = new Cells[boardSize, boardSize];
            int numerocliques;
            Random random = new Random();

            if(boardSize == 3)
            {
                numerocliques = 3;
            }
            else if(boardSize == 5)
            {
                numerocliques = 5;
            }
            else
            {
                numerocliques = 8;
            }

            //Conta quantas peças estão ativas
            //Serve para caso estejam todas, ele sair dps do while
            for (int i = 0; i < newCellsBoard.GetLength(0); i++) 
            { 
                for (int j = 0; j < newCellsBoard.GetLength(1); j++) 
                { 
                    newCellsBoard[i, j] = new Cells(); 
                } 
            }  

            for(int i = 0; i < numerocliques; i++)
            {
                int coluna = random.Next(newCellsBoard.GetLength(1));
                int linha = random.Next(newCellsBoard.GetLength(0));

                ChangeBoardCellsValue(coluna, linha, newCellsBoard);

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