using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlesztésiMinták.Entities
{
    class Present : Abstractions.Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color boxColor, Color ribbonColor)
        {
            BoxColor = new SolidBrush(boxColor);
            RibbonColor = new SolidBrush(ribbonColor);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, 20, 0, Width/5, Height);
            g.FillRectangle(RibbonColor, 0, 20, Width, Height/5);

        }
    }
}
