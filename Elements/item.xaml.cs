using System.Windows.Controls;

namespace Shop_Пешин.Elements
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        // Этот метод должен быть обязательно!
        public void SetData(string name, int price, string characteristic)
        {
            tb_Name.Content = name;
            tb_Price.Content = $"Цена: {price} руб.";
            tb_Characteristic.Content = characteristic;
        }
    }
}