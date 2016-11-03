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
        private string _name;

        //Level of game object (you can also understood it as amount of this kind game objects)
        private int _level;
        //Production earnings, f.e. in city-clicker "Office Tower" should be more profitable than "Kiosk"
        private int _production;
        //increasing number/level of each game object should require an investment from player
        private int _price;

        //100x100 pixels bitmap of this game object
        private Bitmap _bitmap;

        public GameObject(string name, int level, int production, int price, Bitmap bitmap)
        {
            _name = name;
            _level = level;
            _production = production;
            _price = price;
            _bitmap = bitmap;
        }

        //This get methods allow us to get info about this Game Object to build User Interface
        public string GetName()
        {
            return _name;
        }

        public int GetLevel()
        {
            return _level;
        }

        public int GetProduction()
        {
            return _production;
        }

        public int GetPrice()
        {
            return _price;
        }

        public Bitmap GetBitmap()
        {
            return _bitmap;
        }

        //Increasing level, price and production. Each next object should be more expensive and provide better production
        public void IncreaseLevel()
        {
            _level++;
            _price = _price + ((_price * _level) / 10);
            if (_level < 5)
            {
                _production = _production + ((_production * _level) / 8);
            }
            else
            {
                _production = _production + ((_production * _level) / 12);
            }
        }
    }
}
