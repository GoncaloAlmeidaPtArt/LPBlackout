using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackout
{
    public class Cells
    {
        //Creating the variable that defines the cell's state
        private bool isActive;

        //Creates a cell with the default value set to false
        public Cells()
        {
            isActive = false;
        } 

        //Toggle to “On” if it is “Off,” and vice versa
        public void ChangeState()
        {
            isActive = !isActive;
        } 

        //Returns the cell's status
        public bool GetState()
        {
            if (isActive)
            {
                return true;
            }
            else
            {
                return false;
            }
        }  
    }
}