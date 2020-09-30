using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsVsZombies
{
    class zombie
    {
        int size, x, y;

        public zombie(int _size, int _x, int _y)
        {
            size = _size;
            x = _x;
            y = _y;
        }

        public void Move(int speed)
        {
            x -= speed;
        }

    }
}
