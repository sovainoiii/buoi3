using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// bai lam cua Pham Duc Minh
namespace exercise1
{
    internal class Circle : Shape
    {
        private int radius;
        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public new void Move(int dx, int dy)
        {
            base.Move(dx, dy);
        }
        public override string Show()
        {
            return $"center: ({x}, {y}), radius: {radius}";
        }
        public override string ToString()
        {
            return Show();
        }
    }
}
