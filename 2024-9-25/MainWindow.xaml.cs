using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2024_9_25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, int> aircraft = new Dictionary<string, int> {
            {"F-16戰隼",120 },
            {"F-15鷹",480 },
            {"F-22",2000 },
            {"F-35A戰隼",520 },
            {"F-35B戰隼",620 },
            {"F-35C戰隼",560 },
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var targetTextBox = sender as TextBox;

            //MessageBox.Show(targetTextBox.Text);
            int amount;
            bool success = int.TryParse(targetTextBox.Text, out amount);

            if (!success) MessageBox.Show("請輸入數字", "輸入錯誤");
            else if (amount <= 0) MessageBox.Show("請輸入正整數", "輸入錯誤");
            else
            {
                var targetStackPanel = targetTextBox.Parent as StackPanel;
                var targetLabel = targetStackPanel.Children[0] as Label;
                var drinkName = targetLabel.Content.ToString();

                MessageBox.Show(drinkName + " " + amount + "杯，共" + aircraft[drinkName] * amount + "億元");
            }
        }
    }
}