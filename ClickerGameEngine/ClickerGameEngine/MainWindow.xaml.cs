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

namespace ClickerGameEngine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //We will need Builder to build our game objects
            GameObjectBuilder gameObjectBuilder = new GameObjectBuilder();

            //Game Object 1 --------------------------------------------------------------------------
            Uri uriGameObject1 = new Uri("pack://application:,,,/Resources/GameObjectOne.bmp");
            BitmapImage bitmapGameObject1 = new BitmapImage(uriGameObject1);
            GameObject gameObject1 = gameObjectBuilder
                .SetName("Game Object 1")
                .SetLevel(1)
                .SetPrice(1)
                .SetProduction(1)
                .SetBitmap(bitmapGameObject1)
                .Build();
            ((MainWindow)Application.Current.MainWindow).GameObjectImage1.Source = gameObject1.GetBitmap();
        }
    }
}
