using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Bai lam cua Pham Duc Minh
namespace exercise1
{
    abstract class Shape
    {
        protected int x;
        protected int y;
        public void Move(int x, int y) { this.x += x; this.y += y; }
        public abstract string Show();
    }
}
