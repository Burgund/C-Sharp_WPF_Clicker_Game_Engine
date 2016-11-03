using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

/// <summary>
/// This is our main game object. Increasing numbers/levels of game object will increase player earnings
/// </summary>
namespace ClickerGameEngine
{
    class GameObject
    {
        //Name of game object, f.e.: "house" if you want city-clicker or "new vlog" if you want youtuber-clicker etc.
        public string Name { get; set; }

        //Level of game object (you can also understood it as amount of this kind game objects)
        public int Level { get; set; }
        //Production earnings, f.e. in city-clicker "Office Tower" should be more profitable than "Kiosk"
        public int Production { get;  set; }
        //increasing number/level of each game object should require an investment from player
        public int Price { get; set; }

        //100x100 pixels bitmap of this game object
        public Bitmap Bitmap { get; set; }
    }
}
