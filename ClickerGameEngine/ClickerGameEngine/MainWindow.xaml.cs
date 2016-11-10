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
        private GameObject[] _gameObjectArray = new GameObject[8];

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
            _gameObjectArray = GameSetUp.BuildGameObjects();

            //Set up game object bitmap to UI
            GameObjectImage1.Source = _gameObjectArray[0].GetBitmap();
            GameObjectImage2.Source = _gameObjectArray[1].GetBitmap();
            GameObjectImage3.Source = _gameObjectArray[2].GetBitmap();
            GameObjectImage4.Source = _gameObjectArray[3].GetBitmap();
            GameObjectImage5.Source = _gameObjectArray[4].GetBitmap();
            GameObjectImage6.Source = _gameObjectArray[5].GetBitmap();
            GameObjectImage7.Source = _gameObjectArray[6].GetBitmap();
            GameObjectImage8.Source = _gameObjectArray[7].GetBitmap();

            //Set up game object production to UI
            ProductionGameObject1.Text = _gameObjectArray[0].GetProduction().ToString();
            ProductionGameObject2.Text = _gameObjectArray[1].GetProduction().ToString();
            ProductionGameObject3.Text = _gameObjectArray[2].GetProduction().ToString();
            ProductionGameObject4.Text = _gameObjectArray[3].GetProduction().ToString();
            ProductionGameObject5.Text = _gameObjectArray[4].GetProduction().ToString();
            ProductionGameObject6.Text = _gameObjectArray[5].GetProduction().ToString();
            ProductionGameObject7.Text = _gameObjectArray[6].GetProduction().ToString();
            ProductionGameObject8.Text = _gameObjectArray[7].GetProduction().ToString();

            //Set up game object price to UI
            PriceGameObject1.Text = _gameObjectArray[0].GetPrice().ToString();
            PriceGameObject2.Text = _gameObjectArray[1].GetPrice().ToString();
            PriceGameObject3.Text = _gameObjectArray[2].GetPrice().ToString();
            PriceGameObject4.Text = _gameObjectArray[3].GetPrice().ToString();
            PriceGameObject5.Text = _gameObjectArray[4].GetPrice().ToString();
            PriceGameObject6.Text = _gameObjectArray[5].GetPrice().ToString();
            PriceGameObject7.Text = _gameObjectArray[6].GetPrice().ToString();
            PriceGameObject8.Text = _gameObjectArray[7].GetPrice().ToString();

            //Set up game object level
            LevelGameObject1.Text = _gameObjectArray[0].GetLevel().ToString();
            LevelGameObject2.Text = _gameObjectArray[1].GetLevel().ToString();
            LevelGameObject3.Text = _gameObjectArray[2].GetLevel().ToString();
            LevelGameObject4.Text = _gameObjectArray[3].GetLevel().ToString();
            LevelGameObject5.Text = _gameObjectArray[4].GetLevel().ToString();
            LevelGameObject6.Text = _gameObjectArray[5].GetLevel().ToString();
            LevelGameObject7.Text = _gameObjectArray[6].GetLevel().ToString();
            LevelGameObject8.Text = _gameObjectArray[7].GetLevel().ToString();

            //Set up game object name
            NameGameObject1.Text = _gameObjectArray[0].GetName().ToString();
            NameGameObject2.Text = _gameObjectArray[1].GetName().ToString();
            NameGameObject3.Text = _gameObjectArray[2].GetName().ToString();
            NameGameObject4.Text = _gameObjectArray[3].GetName().ToString();
            NameGameObject5.Text = _gameObjectArray[4].GetName().ToString();
            NameGameObject6.Text = _gameObjectArray[5].GetName().ToString();
            NameGameObject7.Text = _gameObjectArray[6].GetName().ToString();
            NameGameObject8.Text = _gameObjectArray[7].GetName().ToString();
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

        private void ClickAreaHandler(object sender, MouseEventArgs e)
        {
            //increase wallet
            _money += _moneyPerClick;

            //UI wallet update
            moneyTextBox.Text = _money.ToString();
        }

        private void MoneyPerSecondUpdate()
        {
            _moneyPerSec = 0;

            for(int i = 0; i < _gameObjectArray.Length; i++)
            {
                _moneyPerSec += _gameObjectArray[i].GetProduction();
            }

            moneyPerSecondTextBox.Text = _moneyPerSec.ToString();
        }
    }
}
