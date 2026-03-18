using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.AbstractFactoryExample.ConcreteFactories
{
    internal class DanceAcademyB : IDanceAbstract
    {
        public IDanceHall ShowDanceHall()
        {
            throw new NotImplementedException();
        }

        public IHipHop ShowHipHop()
        {
            throw new NotImplementedException();
        }
    }
}
