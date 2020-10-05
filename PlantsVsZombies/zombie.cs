using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsVsZombies
{
    class zombie
    {
        public int size, x, y, health;

        public zombie(int _size, int _x, int _y, int _health)
        {
            size = _size;
            x = _x;
            y = _y;
            health = _health;
        }

        public void Move(int speed)
        {
            x -= speed;
        }

    }
}
