using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ClickerGameEngine
{
    internal static class GameSetUp
    {
        public static GameObject[] BuildGameObjects()
        {
            var gameObjectArray = new GameObject[8];
            var gameObjectBuilder = new GameObjectBuilder();

            //Game Object 1
            var uriGameObject1 = new Uri("pack://application:,,,/Resources/GameObjectOne.bmp");
            var bitmapGameObject1 = new BitmapImage(uriGameObject1);
            var gameObject1 = gameObjectBuilder
                .SetName("Game Object 1")
                .SetLevel(0)
                .SetPrice(10)
                .SetProduction(1)
                .SetBitmap(bitmapGameObject1)
                .Build();
            gameObjectArray[0] = gameObject1;

            //Game Object 2
            var uriGameObject2 = new Uri("pack://application:,,,/Resources/GameObjectTwo.bmp");
            var bitmapGameObject2 = new BitmapImage(uriGameObject2);
            var gameObject2 = gameObjectBuilder
                .SetName("Game Object 2")
                .SetLevel(0)
                .SetPrice(40)
                .SetProduction(4)
                .SetBitmap(bitmapGameObject2)
                .Build();
            gameObjectArray[1] = gameObject2;

            //Game Object 3
            var uriGameObject3 = new Uri("pack://application:,,,/Resources/GameObjectThree.bmp");
            var bitmapGameObject3 = new BitmapImage(uriGameObject3);
            var gameObject3 = gameObjectBuilder
                .SetName("Game Object 3")
                .SetLevel(0)
                .SetPrice(200)
                .SetProduction(15)
                .SetBitmap(bitmapGameObject3)
                .Build();
            gameObjectArray[2] = gameObject3;

            //Game Object 4
            var uriGameObject4 = new Uri("pack://application:,,,/Resources/GameObjectFour.bmp");
            var bitmapGameObject4 = new BitmapImage(uriGameObject4);
            var gameObject4 = gameObjectBuilder
                .SetName("Game Object 4")
                .SetLevel(0)
                .SetPrice(1800)
                .SetProduction(80)
                .SetBitmap(bitmapGameObject4)
                .Build();
            gameObjectArray[3] = gameObject4;

            //Game Object 5
            var uriGameObject5 = new Uri("pack://application:,,,/Resources/GameObjectFive.bmp");
            var bitmapGameObject5 = new BitmapImage(uriGameObject5);
            var gameObject5 = gameObjectBuilder
                .SetName("Game Object 5")
                .SetLevel(0)
                .SetPrice(10000)
                .SetProduction(160)
                .SetBitmap(bitmapGameObject5)
                .Build();
            gameObjectArray[4] = gameObject5;

            //Game Object 6
            var uriGameObject6 = new Uri("pack://application:,,,/Resources/GameObjectSix.bmp");
            var bitmapGameObject6 = new BitmapImage(uriGameObject6);
            var gameObject6 = gameObjectBuilder
                .SetName("Game Object 6")
                .SetLevel(0)
                .SetPrice(100000)
                .SetProduction(350)
                .SetBitmap(bitmapGameObject6)
                .Build();
            gameObjectArray[5] = gameObject6;

            //Game Object 7 
            var uriGameObject7 = new Uri("pack://application:,,,/Resources/GameObjectSeven.bmp");
            var bitmapGameObject7 = new BitmapImage(uriGameObject7);
            var gameObject7 = gameObjectBuilder
                .SetName("Game Object 7")
                .SetLevel(0)
                .SetPrice(2000000)
                .SetProduction(1500)
                .SetBitmap(bitmapGameObject7)
                .Build();
            gameObjectArray[6] = gameObject7;

            //Game Object 8
            var uriGameObject8 = new Uri("pack://application:,,,/Resources/GameObjectEight.bmp");
            var bitmapGameObject8 = new BitmapImage(uriGameObject8);
            var gameObject8 = gameObjectBuilder
                .SetName("Game Object 8")
                .SetLevel(0)
                .SetPrice(30000000)
                .SetProduction(12000)
                .SetBitmap(bitmapGameObject8)
                .Build();
            gameObjectArray[7] = gameObject8;

            return gameObjectArray;
        }

        public static void SetUpUI(GameObject[] gameObjectArray)
        {
            //Set up bitmap to UI
            ((MainWindow) System.Windows.Application.Current.MainWindow).GameObjectImage1.Source =
                gameObjectArray[0].GetBitmap();
            ((MainWindow) System.Windows.Application.Current.MainWindow).GameObjectImage2.Source =
                gameObjectArray[1].GetBitmap();
            ((MainWindow) System.Windows.Application.Current.MainWindow).GameObjectImage3.Source =
                gameObjectArray[2].GetBitmap();
            ((MainWindow) System.Windows.Application.Current.MainWindow).GameObjectImage4.Source =
                gameObjectArray[3].GetBitmap();
            ((MainWindow) System.Windows.Application.Current.MainWindow).GameObjectImage5.Source =
                gameObjectArray[4].GetBitmap();
            ((MainWindow) System.Windows.Application.Current.MainWindow).GameObjectImage6.Source =
                gameObjectArray[5].GetBitmap();
            ((MainWindow) System.Windows.Application.Current.MainWindow).GameObjectImage7.Source =
                gameObjectArray[6].GetBitmap();
            ((MainWindow) System.Windows.Application.Current.MainWindow).GameObjectImage8.Source =
                gameObjectArray[7].GetBitmap();

            //Set up production to UI
            ((MainWindow) System.Windows.Application.Current.MainWindow).ProductionGameObject1.Text =
                gameObjectArray[0].GetProduction().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).ProductionGameObject2.Text =
                gameObjectArray[1].GetProduction().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).ProductionGameObject3.Text =
                gameObjectArray[2].GetProduction().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).ProductionGameObject4.Text =
                gameObjectArray[3].GetProduction().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).ProductionGameObject5.Text =
                gameObjectArray[4].GetProduction().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).ProductionGameObject6.Text =
                gameObjectArray[5].GetProduction().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).ProductionGameObject7.Text =
                gameObjectArray[6].GetProduction().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).ProductionGameObject8.Text =
                gameObjectArray[7].GetProduction().ToString();

            //Set up price to UI
            ((MainWindow) System.Windows.Application.Current.MainWindow).PriceGameObject1.Text =
                gameObjectArray[0].GetPrice().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).PriceGameObject2.Text =
                gameObjectArray[1].GetPrice().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).PriceGameObject3.Text =
                gameObjectArray[2].GetPrice().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).PriceGameObject4.Text =
                gameObjectArray[3].GetPrice().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).PriceGameObject5.Text =
                gameObjectArray[4].GetPrice().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).PriceGameObject6.Text =
                gameObjectArray[5].GetPrice().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).PriceGameObject7.Text =
                gameObjectArray[6].GetPrice().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).PriceGameObject8.Text =
                gameObjectArray[7].GetPrice().ToString();

            //Set up level to UI
            ((MainWindow) System.Windows.Application.Current.MainWindow).LevelGameObject1.Text =
                gameObjectArray[0].GetLevel().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).LevelGameObject2.Text =
                gameObjectArray[1].GetLevel().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).LevelGameObject3.Text =
                gameObjectArray[2].GetLevel().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).LevelGameObject4.Text =
                gameObjectArray[3].GetLevel().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).LevelGameObject5.Text =
                gameObjectArray[4].GetLevel().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).LevelGameObject6.Text =
                gameObjectArray[5].GetLevel().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).LevelGameObject7.Text =
                gameObjectArray[6].GetLevel().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).LevelGameObject8.Text =
                gameObjectArray[7].GetLevel().ToString();

            //Set up name to UI
            ((MainWindow) System.Windows.Application.Current.MainWindow).NameGameObject1.Text =
                gameObjectArray[0].GetName().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).NameGameObject2.Text =
                gameObjectArray[1].GetName().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).NameGameObject3.Text =
                gameObjectArray[2].GetName().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).NameGameObject4.Text =
                gameObjectArray[3].GetName().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).NameGameObject5.Text =
                gameObjectArray[4].GetName().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).NameGameObject6.Text =
                gameObjectArray[5].GetName().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).NameGameObject7.Text =
                gameObjectArray[6].GetName().ToString();
            ((MainWindow) System.Windows.Application.Current.MainWindow).NameGameObject8.Text =
                gameObjectArray[7].GetName().ToString();
        }
    }
}