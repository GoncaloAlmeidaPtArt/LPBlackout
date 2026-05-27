using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackout
{
    public class Board
    {
        //Board contains a array of arrays of cells, witch represents the board.
        private Cells[,] boardCells;
<<<<<<< HEAD

        //Board contains an instance of view to show the board to the player.
        private PrototypeView view;
=======
>>>>>>> 15addd2fbc38ee256594c54b2f4f21b2c2c82493

        /// <summary>
        /// This method creates a board of cells with the size acording to the 
        /// dificulty selected by the player.
        /// </summary>
        /// <param name="boardSize">Representation of the board size according
        ///  to the selected difficulty.</param>
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

        /// <summary>
        /// This method returns an array of arrays of instances of cells, 
        /// without receive any parameter.
        /// </summary>
        /// <returns>The board of cells.</returns>
        public Cells[,] GetBoardOfCells()
        {
            return boardCells;
        }

        /// <summary>
        /// This method changes the state of the cell selected and the cells 
        /// around it, those being the adjacent cells (up, down, left, right) 
        /// if they exist.
        /// </summary>
        /// <param name="x">Coordinate x of the selected cell.</param>
        /// <param name="y">Coordinate y of the selected cell.</param>
        /// <param name="board">The array of arrays of cells.</param>
        public void ChangeBoardCellsValue(int x, int y, Cells[,] board)
        {
            //Try to change the state of the selected cell if they exist, 
            // otherwise do nothing.
            try
            {  
                //Change the state of the cell corresponding to the coordinates selected.
                board[x,y].ChangeState();
<<<<<<< HEAD
            }
=======
            }   
>>>>>>> 15addd2fbc38ee256594c54b2f4f21b2c2c82493
            catch
            {
                    
            }
<<<<<<< HEAD
           
            //Try to change the state of the cell at the right side of the 
            // selected cell if they exist, otherwise do nothing.
=======
>>>>>>> 15addd2fbc38ee256594c54b2f4f21b2c2c82493
            try
            {
                //Change the state of the cell corresponding to the coordinates selected.
                board[x+1,y].ChangeState();
            }
            catch
            {
                    
            }
<<<<<<< HEAD
            
            //Try to change the state of the cell at the left side of the 
            // selected cell if they exist, otherwise do nothing.
=======
>>>>>>> 15addd2fbc38ee256594c54b2f4f21b2c2c82493
            try
            {
                //Change the state of the cell corresponding to the coordinates selected.
                board[x-1,y].ChangeState();
            }   
            catch
            {
                    
            }
<<<<<<< HEAD

            //Try to change the state of the cell at the bottom side of the 
            // selected cell if they exist, otherwise do nothing.
=======
>>>>>>> 15addd2fbc38ee256594c54b2f4f21b2c2c82493
            try
            {
                //Change the state of the cell corresponding to the coordinates selected.
                board[x,y+1].ChangeState();
            }
            catch
            {
                    
            }
<<<<<<< HEAD

            //Try to change the state of the cell at the top side of the 
            // selected cell if they exist, otherwise do nothing.
=======
>>>>>>> 15addd2fbc38ee256594c54b2f4f21b2c2c82493
            try
            {
                //Change the state of the cell corresponding to the coordinates selected.
                board[x,y-1].ChangeState();
            }
            catch
            {
                    
            }
        }
    }
}