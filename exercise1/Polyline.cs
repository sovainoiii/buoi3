using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Bai lam cua Pham Duc Minh
namespace exercise1
{
    internal class Polyline : Shape
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        public Polyline(int x, int y, int x1, int y1, int x2, int y2)
        {
            this.x = x;
            this.y = y;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public void Move(int dx, int dy)
        {
            base.Move(dx, dy);
            x1 += dx;
            y1 += dy;
            x2 += dx;
            y2 += dy;
        }
        public override string Show()
        {
            return $"point 1: ({x}, {y}), point 2: ({x1}, {y1}), point 3: ({x2}, {y2})";
        }
        public override string ToString()
        {
            return Show();
        }
    }
}
