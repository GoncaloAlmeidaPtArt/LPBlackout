using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackout
{
    public class Cells
    {
        private bool isActive;
        public Cells()
        {
            isActive = false;
        } 

        public void ChangeState()
        {
            isActive = !isActive;
        } 

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