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

        }
        
    }
}
