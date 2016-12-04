﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace ClickerGameEngine
{
    internal class GameObjectBuilder
    {
        private string _name;
        private int _level;
        private int _production;
        private int _price;
        private BitmapImage _bitmap;

        public GameObjectBuilder SetName(string name)
        {
            this._name = name;
            return this;
        }

        public GameObjectBuilder SetLevel(int level)
        {
            this._level = level;
            return this;
        }

        public GameObjectBuilder SetProduction(int production)
        {
            this._production = production;
            return this;
        }

        public GameObjectBuilder SetPrice(int price)
        {
            this._price = price;
            return this;
        }

        public GameObjectBuilder SetBitmap(BitmapImage bitmap)
        {
            this._bitmap = bitmap;
            return this;
        }

        public GameObject Build()
        {
            return new GameObject(_name, _level, _production, _price, _bitmap);
        }
    }
}
