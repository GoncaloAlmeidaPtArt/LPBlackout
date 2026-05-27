using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Blackout
{
    public class Program
    {
        /// <summary>
        /// Criação e chamada do Controller, View e Board
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {

            //Creating the controller,view and Board
            Controller controller = new Controller();
            PrototypeView view = new PrototypeView();
            Board board = new Board();

            //Call the controller with the view and the board embedded
            controller.Run(view, board);

        }
        
    }
}
