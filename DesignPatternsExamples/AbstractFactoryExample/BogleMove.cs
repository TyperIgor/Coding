using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.AbstractFactoryExample
{
    public class BogleMove : IDanceHall
    {
        public string ShowDanceHallMoves()
        {
            return "Bogle Move from DanceHall Style";
        }
    }
}
