using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Windows.Threading;

namespace ClickerGameEngine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Timer variable to do events each 1 second
        private DispatcherTimer _timer;
        //Player wallet
        private long _money = 0;
        //Each secong earnings  
        private int _moneyPerSec = 0;
        //Each click earnings
        private int _moneyPerClick = 1;

        public MainWindow()
        {
            InitializeComponent();

            //Timer object to handle each second auto-click. Game main-loop
            _timer = new DispatcherTimer(DispatcherPriority.SystemIdle);
            //Add event method to our timer
            _timer.Tick += new EventHandler(OnUpdateTimerTick);
            //Set timer tact to 1sec
            _timer.Interval = TimeSpan.FromMilliseconds(1000);
            //Timer start
            _timer.Start();

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
            ((MainWindow)Application.Current.MainWindow).GameObjectImage1.Source = gameObject1.GetBitmap();

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
            ((MainWindow)Application.Current.MainWindow).GameObjectImage2.Source = gameObject2.GetBitmap();

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
            ((MainWindow)Application.Current.MainWindow).GameObjectImage3.Source = gameObject3.GetBitmap();

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
            ((MainWindow)Application.Current.MainWindow).GameObjectImage4.Source = gameObject4.GetBitmap();

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
            ((MainWindow)Application.Current.MainWindow).GameObjectImage5.Source = gameObject5.GetBitmap();

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
            ((MainWindow)Application.Current.MainWindow).GameObjectImage6.Source = gameObject6.GetBitmap();

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
            ((MainWindow)Application.Current.MainWindow).GameObjectImage7.Source = gameObject7.GetBitmap();

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
            ((MainWindow)Application.Current.MainWindow).GameObjectImage8.Source = gameObject8.GetBitmap();
        }

        //Timer event method
        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            //Player will earn each second
            _money += _moneyPerSec;

            //Each second UI will be update 
            moneyTextBox.Text = _money.ToString();
            moneyPerSecondTextBox.Text = _moneyPerSec.ToString();
            moneyPerClickTextBlock.Text = _moneyPerClick.ToString();
        }

        private void ClickAreaHandler (object sender, MouseEventArgs e)
        {
            //increase wallet
            _money += _moneyPerClick;

            //UI wallet update
            moneyTextBox.Text = _money.ToString();
        }
    }
}
