using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using MaterialDesignDropdownMenu.ViewModels;
using MaterialDesignDropdownMenu.UserControls;
using MaterialDesignThemes.Wpf;

namespace MaterialDesignDropdownMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var menuRegister = new List<SubItem>
            {
                new SubItem("客户", new UserControlCustomers()),
                new SubItem("供应商", new UserControlProviders()),
                new SubItem("员工", new UserControlTimeline()),
                new SubItem("产品")
            };
            var item6 = new ItemMenu("登记", menuRegister, PackIconKind.Register);

            var menuSchedule = new List<SubItem>
            {
                new SubItem("服务"),
                new SubItem("会议")
            };
            var item1 = new ItemMenu("预约", menuSchedule, PackIconKind.Schedule);

            var menuReports = new List<SubItem>
            {
                new SubItem("客户"),
                new SubItem("供应商"),
                new SubItem("产品"),
                new SubItem("库存"),
                new SubItem("销售额")
            };
            var item2 = new ItemMenu("报告", menuReports, PackIconKind.FileReport);

            var menuExpenses = new List<SubItem>
            {
                new SubItem("固定资产"),
                new SubItem("流动资金")
            };
            var item3 = new ItemMenu("费用", menuExpenses, PackIconKind.ShoppingBasket);

            var menuFinancial = new List<SubItem>
            {
                new SubItem("现金流")
            };
            var item4 = new ItemMenu("财务", menuFinancial, PackIconKind.ScaleBalance);

            Menu.Children.Add(new UserControlMenuItem(item6, this));
            Menu.Children.Add(new UserControlMenuItem(item1, this));
            Menu.Children.Add(new UserControlMenuItem(item2, this));
            Menu.Children.Add(new UserControlMenuItem(item3, this));
            Menu.Children.Add(new UserControlMenuItem(item4, this));
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }
    }
}
