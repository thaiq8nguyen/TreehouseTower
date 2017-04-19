using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseTower
{
    class TreehouseTowerException: System.Exception
    {
        public TreehouseTowerException()
        {

        }
        public TreehouseTowerException(string message): base(message)
        {

        }
    }

    class OutOfBoundsException: TreehouseTowerException
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message): base(message)
        {

        }
    }
}
