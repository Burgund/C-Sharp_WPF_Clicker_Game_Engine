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

            //Set up game objects
            GameObject[] gameObjectArray = new GameObject[8];
            gameObjectArray = GameSetUp.BuildGameObjects();

            //Set up game objects bitmaps to UI
            GameObjectImage1.Source = gameObjectArray[0].GetBitmap();
            GameObjectImage2.Source = gameObjectArray[1].GetBitmap();
            GameObjectImage3.Source = gameObjectArray[2].GetBitmap();
            GameObjectImage4.Source = gameObjectArray[3].GetBitmap();
            GameObjectImage5.Source = gameObjectArray[4].GetBitmap();
            GameObjectImage6.Source = gameObjectArray[5].GetBitmap();
            GameObjectImage7.Source = gameObjectArray[6].GetBitmap();
            GameObjectImage8.Source = gameObjectArray[7].GetBitmap();

            //Set up game objects production to UI
            ProductionGameObject1.Text = gameObjectArray[0].GetProduction().ToString();
            ProductionGameObject2.Text = gameObjectArray[1].GetProduction().ToString();
            ProductionGameObject3.Text = gameObjectArray[2].GetProduction().ToString();
            ProductionGameObject4.Text = gameObjectArray[3].GetProduction().ToString();
            ProductionGameObject5.Text = gameObjectArray[4].GetProduction().ToString();
            ProductionGameObject6.Text = gameObjectArray[5].GetProduction().ToString();
            ProductionGameObject7.Text = gameObjectArray[6].GetProduction().ToString();
            ProductionGameObject8.Text = gameObjectArray[7].GetProduction().ToString();
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
