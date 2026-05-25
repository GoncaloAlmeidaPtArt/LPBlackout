using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Blackout
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Controller controller = new Controller();
            PrototypeView view = new PrototypeView();
            Board board = new Board();

            controller.Run(view, board);

            //
            //Estepedaço de codigo basicamente altera a posiçao que o jogador selecionou
            //Assim como todas as peças em torno dela
            //No final conta quantas peças estão ativas
            //Só quando todas elas tiverem ativas é que sai do while
            //
            /*
            int numerofinal = 0;
            while(numerofinal != 16)
            {
                

                Mostrar(lists1);


                //Reseta a conagem de peças, para não somar as da jogada anterior
                numerofinal = 0;


                //Pede as cordenadas da peça
                int x = 0;
                int y = 0;
                (x, y) = Coordenadas(x, y);
                

                AlteraValores(x, y, lists1);
                
                
                //Conta quantas peças estão ativas
                //Serve para caso estejam todas, ele sair dps do while
                for (int i = 0; i < lists1.GetLength(0); i++) 
                { 
                    for (int j = 0; j < lists1.GetLength(1); j++) 
                    { 
                        numerofinal +=lists1[i, j]; 
                    } 
                }  

            }

            //So vem para aqui quando ganha
            //Mostra que ganhou
            Console.WriteLine("Parabens");
            
        }

        public static void Mostrar(int[,] lists1)
        {
            
        }

        public static (int, int) Coordenadas(int x, int y)
        {
            //Pede as cordenadas da peça
            Console.WriteLine("Coloca o X que desejas alterar");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Coloca o Y que desejas alterar");
            y = Convert.ToInt32(Console.ReadLine());

            return (x, y);
        }

        public static void AlteraValores(int x, int y, int[,] lists1)
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
            */
        }
        
    }
}
