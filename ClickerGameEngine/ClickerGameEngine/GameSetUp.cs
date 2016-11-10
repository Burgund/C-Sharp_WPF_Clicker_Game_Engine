using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ClickerGameEngine
{
    static class GameSetUp
    {
        //Set up game objects
        public static GameObject[] BuildGameObjects()
        {
            GameObject[] gameObjectArray = new GameObject[8];

            //Building game objects ->
            //We will need Builder to build our game objects
            GameObjectBuilder gameObjectBuilder = new GameObjectBuilder();

            //Game Object 1 --------------------------------------------------------------------------
            Uri uriGameObject1 = new Uri("pack://application:,,,/Resources/GameObjectOne.bmp");
            BitmapImage bitmapGameObject1 = new BitmapImage(uriGameObject1);
            GameObject gameObject1 = gameObjectBuilder
                .SetName("Game Object 1")
                .SetLevel(0)
                .SetPrice(10)
                .SetProduction(1)
                .SetBitmap(bitmapGameObject1)
                .Build();
            gameObjectArray[0] = gameObject1;

            //Game Object 2 --------------------------------------------------------------------------
            Uri uriGameObject2 = new Uri("pack://application:,,,/Resources/GameObjectTwo.bmp");
            BitmapImage bitmapGameObject2 = new BitmapImage(uriGameObject2);
            GameObject gameObject2 = gameObjectBuilder
                .SetName("Game Object 2")
                .SetLevel(0)
                .SetPrice(20)
                .SetProduction(4)
                .SetBitmap(bitmapGameObject2)
                .Build();
            gameObjectArray[1] = gameObject2;

            //Game Object 3 --------------------------------------------------------------------------
            Uri uriGameObject3 = new Uri("pack://application:,,,/Resources/GameObjectThree.bmp");
            BitmapImage bitmapGameObject3 = new BitmapImage(uriGameObject3);
            GameObject gameObject3 = gameObjectBuilder
                .SetName("Game Object 3")
                .SetLevel(0)
                .SetPrice(110)
                .SetProduction(15)
                .SetBitmap(bitmapGameObject3)
                .Build();
            gameObjectArray[2] = gameObject3;

            //Game Object 4 --------------------------------------------------------------------------
            Uri uriGameObject4 = new Uri("pack://application:,,,/Resources/GameObjectFour.bmp");
            BitmapImage bitmapGameObject4 = new BitmapImage(uriGameObject4);
            GameObject gameObject4 = gameObjectBuilder
                .SetName("Game Object 4")
                .SetLevel(0)
                .SetPrice(800)
                .SetProduction(80)
                .SetBitmap(bitmapGameObject4)
                .Build();
            gameObjectArray[3] = gameObject4;

            //Game Object 5 --------------------------------------------------------------------------
            Uri uriGameObject5 = new Uri("pack://application:,,,/Resources/GameObjectFive.bmp");
            BitmapImage bitmapGameObject5 = new BitmapImage(uriGameObject5);
            GameObject gameObject5 = gameObjectBuilder
                .SetName("Game Object 5")
                .SetLevel(0)
                .SetPrice(2400)
                .SetProduction(160)
                .SetBitmap(bitmapGameObject5)
                .Build();
            gameObjectArray[4] = gameObject5;

            //Game Object 6 --------------------------------------------------------------------------
            Uri uriGameObject6 = new Uri("pack://application:,,,/Resources/GameObjectSix.bmp");
            BitmapImage bitmapGameObject6 = new BitmapImage(uriGameObject6);
            GameObject gameObject6 = gameObjectBuilder
                .SetName("Game Object 6")
                .SetLevel(0)
                .SetPrice(10000)
                .SetProduction(350)
                .SetBitmap(bitmapGameObject6)
                .Build();
            gameObjectArray[5] = gameObject6;

            //Game Object 7 --------------------------------------------------------------------------
            Uri uriGameObject7 = new Uri("pack://application:,,,/Resources/GameObjectSeven.bmp");
            BitmapImage bitmapGameObject7 = new BitmapImage(uriGameObject7);
            GameObject gameObject7 = gameObjectBuilder
                .SetName("Game Object 7")
                .SetLevel(0)
                .SetPrice(200000)
                .SetProduction(1500)
                .SetBitmap(bitmapGameObject7)
                .Build();
            gameObjectArray[6] = gameObject7;

            //Game Object 8 --------------------------------------------------------------------------
            Uri uriGameObject8 = new Uri("pack://application:,,,/Resources/GameObjectEight.bmp");
            BitmapImage bitmapGameObject8 = new BitmapImage(uriGameObject8);
            GameObject gameObject8 = gameObjectBuilder
                .SetName("Game Object 8")
                .SetLevel(0)
                .SetPrice(3000000)
                .SetProduction(12000)
                .SetBitmap(bitmapGameObject8)
                .Build();
            gameObjectArray[7] = gameObject8;

            return gameObjectArray;
        }
    }
}
