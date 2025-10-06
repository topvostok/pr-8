using System.Windows;
using System.Xml.Linq;

namespace Shop_Пешин
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();
        }

        private void LoadItems()
        {
            var items = Classes.RepoItems.AllItems();

            foreach (var item in items)
            {
                if (item is Classes.Children childrenItem)
                {
                    var userControl = new Elements.Item();
                    userControl.SetData(childrenItem.Name, childrenItem.Price, $"Возраст: {childrenItem.Age}+");
                    parent.Children.Add(userControl);
                }
                else if (item is Classes.Sport sportItem)
                {
                    var userControl = new Elements.Item();
                    userControl.SetData(sportItem.Name, sportItem.Price, $"Размер: {sportItem.Size}");
                    parent.Children.Add(userControl);
                }
            }
        }
    }
}