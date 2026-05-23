using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spectre.Console;

namespace Blackout
{
    public class PrototypeView : IView
    {
        public void ShowGrid(int gridSize)
        {
            Canvas grid = new Canvas(gridSize,gridSize);
            for(int y = 0; y < grid.Height; y++)
            {
                for(int x = 0; x < grid.Width; x++)
                {
                    if((x % 2 == 0 && y % 2 == 0)||(x % 2 != 0 && y % 2 != 0 ))
                    {
                        grid.SetPixel(x, y, Color.Aqua);
                    }
                    else
                    {
                        grid.SetPixel(x, y, Color.DeepPink4_2);
                    }
                }
            }

            grid.MaxWidth = 20;

            AnsiConsole.Write(grid);
        }
    }
}