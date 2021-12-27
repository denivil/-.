using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Builder
{
    internal class Director
    {
        public Smile Construct(ISmileBuilder builder)
        {
            builder.CreateHead();
            builder.CreateEyes();
            builder.CreateMouth();
            return builder.GetSmileType();
        }
    }
}
