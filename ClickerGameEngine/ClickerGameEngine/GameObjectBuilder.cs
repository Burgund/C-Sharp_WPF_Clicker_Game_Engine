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
            _name = name;
            return this;
        }

        public GameObjectBuilder SetLevel(int level)
        {
            _level = level;
            return this;
        }

        public GameObjectBuilder SetProduction(int production)
        {
            _production = production;
            return this;
        }

        public GameObjectBuilder SetPrice(int price)
        {
            _price = price;
            return this;
        }

        public GameObjectBuilder SetBitmap(BitmapImage bitmap)
        {
            _bitmap = bitmap;
            return this;
        }

        public GameObject Build()
        {
            return new GameObject(_name, _level, _production, _price, _bitmap);
        }
    }
}
