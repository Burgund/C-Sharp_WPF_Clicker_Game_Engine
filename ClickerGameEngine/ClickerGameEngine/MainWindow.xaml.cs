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
        private long _playerWallet = 0;
        private int _moneyPerSecond = 0;
        private int _moneyPerClick = 1;
        private readonly GameObject[] _gameObjectAggregator = GameSetUp.BuildGameObjects();

        public MainWindow()
        {
            InitializeComponent();

            //Using DispatcherTimer as a game loop
            DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.SystemIdle);
            timer.Tick += new EventHandler(OnUpdateTimerTick);
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Start();

            //Set up the UI
            GameSetUp.SetUpUI(_gameObjectAggregator);
        }

        //Timer event method
        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            //Player will earn each second
            _playerWallet += _moneyPerSecond;

            //Each second UI will be update 
            moneyTextBox.Text = _playerWallet.ToString();
            moneyPerClickTextBlock.Text = _moneyPerClick.ToString();
        }

        //Each time player will increase level of any object we will have to update MPS value
        private void MoneyPerSecondUpdate()
        {
            _moneyPerSecond = 0;

            for(int i = 0; i < _gameObjectAggregator.Length; i++)
            {
                _moneyPerSecond += _gameObjectAggregator[i].GetProduction();
            }

            moneyPerSecondTextBox.Text = _moneyPerSecond.ToString();
        }

        private void ImageOneClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectAggregator[0]);
        }

        private void ImageTwoClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectAggregator[1]);
        }

        private void ImageThreeClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectAggregator[2]);
        }

        private void ImageFourClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectAggregator[3]);
        }

        private void ImageFiveClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectAggregator[4]);
        }

        private void ImageSixClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectAggregator[5]);
        }

        private void ImageSevenClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectAggregator[6]);
        }

        private void ImageEightClicked(object sender, MouseEventArgs e)
        {
            BuyNewObject(_gameObjectAggregator[7]);
        }

        private void BuyNewObject(GameObject gameObject)
        {
            if (_playerWallet >= gameObject.GetPrice())
            {
                _playerWallet -= gameObject.GetPrice();
                gameObject.IncreaseLevel();
                MoneyPerSecondUpdate();
                _moneyPerClick += (gameObject.GetProduction() / 8);
            }
            else
            {
                MessageBox.Show("You do not have enough money!");
            }

            GameSetUp.SetUpUI(_gameObjectAggregator);
        }

        private void ClickAreaHandler(object sender, MouseEventArgs e)
        {
            //increase wallet
            _playerWallet += _moneyPerClick;

            //UI wallet update
            moneyTextBox.Text = _playerWallet.ToString();
        }
    }
}
