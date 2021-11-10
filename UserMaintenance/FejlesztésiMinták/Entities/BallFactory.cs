using FejlesztésiMinták.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlesztésiMinták.Entities
{
    public class BallFactory : IToyFactory
    {
        public Abstractions.Toy CreateNew()
        {
            return new Ball();
        }

        
    }
}
