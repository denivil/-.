using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Builder
{
    internal interface ISmileBuilder
    {
        void CreateHead();

        void CreateEyes();

        void CreateMouth();

        Smile GetSmileType();
    }
}
