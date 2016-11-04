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

            //Test

            GameObjectBuilder testBuilder = new GameObjectBuilder();
            Uri uri1 = new Uri("pack://application:,,,/Resources/GameObjectOne.bmp");
            BitmapImage bitmapObject1 = new BitmapImage(uri1);
            GameObject testObject = testBuilder
                .SetName("Office Tower")
                .SetLevel(1)
                .SetPrice(10000)
                .SetProduction(1000)
                .SetBitmap(bitmapObject1)
                .Build();
            ((MainWindow)System.Windows.Application.Current.MainWindow).GameObjectImage1.Source = testObject.GetBitmap();
        }
    }
}
