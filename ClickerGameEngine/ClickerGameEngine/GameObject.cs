using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClickerGameEngine
{
    class GameObject
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Production { get;  set; }
        public Bitmap bitmap { get; set; }

        public int ProductionGet()
        {
            int value = Production;

            for (int i = 0; i < Level; i++)
            {
                value += ((Production * Level) / 10);
            }

            return value;
        }
    }
}
