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
        //Set up game objects 
        private GameObject[] _gameObjectArray = GameSetUp.BuildGameObjects();

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

            //Set up the UI
            GameSetUp.SetUpUI(_gameObjectArray);
        }

        //Timer event method
        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            //Player will earn each second
            _money += _moneyPerSec;

            //Each second UI will be update 
            moneyTextBox.Text = _money.ToString();
            moneyPerClickTextBlock.Text = _moneyPerClick.ToString();
        }

        //Each time player will increase level of any object we will have to update MPS value
        private void MoneyPerSecondUpdate()
        {
            _moneyPerSec = 0;

            for(int i = 0; i < _gameObjectArray.Length; i++)
            {
                _moneyPerSec += _gameObjectArray[i].GetProduction();
            }

            moneyPerSecondTextBox.Text = _moneyPerSec.ToString();
        }

        private void BuyNewObject(GameObject gameObject)
        {
            if(_money >= gameObject.GetPrice())
            {
                _money -= gameObject.GetPrice();
                gameObject.IncreaseLevel();
                MoneyPerSecondUpdate();
            }
            else
            {
                MessageBox.Show("You do not have enough money!");
            }

            GameSetUp.SetUpUI(_gameObjectArray);
        }

        private void ImageOneClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectArray[0]);
        }

        private void ImageTwoClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectArray[1]);
        }

        private void ImageThreeClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectArray[2]);
        }

        private void ImageFourClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectArray[3]);
        }

        private void ImageFiveClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectArray[4]);
        }

        private void ImageSixClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectArray[5]);
        }

        private void ImageSevenClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectArray[6]);
        }

        private void ImageEightClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectArray[7]);
        }

        private void ClickAreaHandler(object sender, MouseEventArgs e)
        {
            //increase wallet
            _money += _moneyPerClick;

            //UI wallet update
            moneyTextBox.Text = _money.ToString();
        }
    }
}
