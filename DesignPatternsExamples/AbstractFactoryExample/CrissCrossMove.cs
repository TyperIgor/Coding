using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.AbstractFactoryExample
{
    public class CrissCrossMove : IHipHop
    {
        public string ShowHipHopMoves()
        {
            return "Criss Cross Move from HipHop Style";
        }
    }
}
