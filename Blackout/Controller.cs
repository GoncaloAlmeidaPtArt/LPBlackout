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
            int dificuldade = 0;
            dificuldade = view.Dificuldade(dificuldade);

            int[,] lista;
            int ola = 0;

            while(ola == 0)
            {
                switch (dificuldade)
                {
                case 0:
                    board.Criador(3);
                    ola = 1;
                break;

                case 1:
                    board.Criador(5);
                    ola = 1;
                break;

                case 2:
                    board.Criador(8);
                    
                    ola = 1;
                break;
                default:
                break;
                }
            }

            lista = board.GetBoard();

    


            //
            //Estepedaço de codigo basicamente altera a posiçao que o jogador selecionou
            //Assim como todas as peças em torno dela
            //No final conta quantas peças estão ativas
            //Só quando todas elas tiverem ativas é que sai do while
            //
            int total = 0;

            if(dificuldade == 0)
            {
                total= 9;
            }
            else if(dificuldade == 1)
            {
                total= 25;
            }
            else if(dificuldade == 2)
            {
                total= 64;
            }
            int numerofinal = 0;
            while(numerofinal != total)
            {
                

                view.ShowGrid(lista);


                //Reseta a conagem de peças, para não somar as da jogada anterior
                numerofinal = 0;


                int coordenadax = 0;
                int coordenaday = 0;

                (coordenadax, coordenaday) = view.Coordenadas(coordenadax, coordenaday);
                

                board.AlteraValores(coordenadax, coordenaday, lista);
                
                
                //Conta quantas peças estão ativas
                //Serve para caso estejam todas, ele sair dps do while
                for (int i = 0; i < lista.GetLength(0); i++) 
                { 
                    for (int j = 0; j < lista.GetLength(1); j++) 
                    { 
                        numerofinal +=lista[i, j]; 
                    } 
                }  

            }  

            Console.WriteLine("Congractulations");
            
        }
    }
}