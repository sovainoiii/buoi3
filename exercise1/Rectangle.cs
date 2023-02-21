using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Bai lam cua Pham Duc Minh
namespace exercise1
{
    internal class Rectangle : Shape
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public Rectangle(int x, int y, int x1, int y1, int x2, int y2)
        {
            this.x = x;
            this.y = y;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public new void Move(int dx, int dy)
        {
            base.Move(dx, dy);
            this.x1 += dx;
            this.y1 += dy;
            this.x2 += dx;
            this.y2 += dy;
        }
        public override string Show()
        {
            return $"point: ({x}, {y}), point A: ({x1}, {y1}), point B: ({x2}, {y2})";
        }
        public override string ToString()
        {
            return Show();
        }
    }
}
