using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsVsZombies
{
    class Pea
    {
        public int x, y, size;

        public Pea(int _size, int _x, int _y)
        {
            size = _size;
            x = _x;
            y = _y;
        }

        public void Shoot(int speed)
        {
            x += speed;
        }
    }
}
