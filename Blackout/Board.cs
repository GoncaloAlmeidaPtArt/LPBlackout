using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackout
{
    public class Board
    {
        
        public int[,] boardC;

        public void Criador(int tamanho)
        {
            int[,] board = new int[tamanho, tamanho];

            //Conta quantas peças estão ativas
            //Serve para caso estejam todas, ele sair dps do while
            for (int i = 0; i < board.GetLength(0); i++) 
            { 
                for (int j = 0; j < board.GetLength(1); j++) 
                { 
                    board[i, j] = 0; 
                } 
            }  

            boardC = board;
        }

        public int[,] GetBoard()
        {
            return boardC;
        }

        public void AlteraValores(int x, int y, int[,] lists1)
        {
            //
            //Estes trys todos basicamente vão verificar se a peça está ativa ou não
            //Tanto a peça selecionada com as em volta
            //Dependendo de como estiver, ele inverte o estado
            //Caso a peça não exista, ele simplesmente não faz nada (por isso os trys)
            //
            try
            {
                if(lists1[x,y] == 0)
                {
                    lists1[x,y] = 1;
                }
                else
                {
                    lists1[x,y] = 0;
                }
            }
            catch
            {
                
            }

            try
            {
                if(lists1[x+1,y] == 0)
                {
                    lists1[x+1,y] = 1;
                }
                else
                {
                    lists1[x+1,y] = 0;
                }
            }
            catch
            {
                
            }


            try
            {
                if(lists1[x-1,y] == 0)
                {
                    lists1[x-1,y] = 1;
                }
                else
                {
                    lists1[x-1,y] = 0;
                }
            }
            catch
            {
                
            }


            try
            {
                if(lists1[x,y+1] == 0)
                {
                    lists1[x,y+1] = 1;
                }
                else
                {
                    lists1[x,y+1] = 0;
                }
            }
            catch
            {
                
            }


            try
            {
                if(lists1[x,y-1] == 0)
                {
                    lists1[x,y-1] = 1;
                }
                else
                {
                    lists1[x,y-1] = 0;
                }
            }
            catch
            {
                
            }
            
        }
        
    }
}