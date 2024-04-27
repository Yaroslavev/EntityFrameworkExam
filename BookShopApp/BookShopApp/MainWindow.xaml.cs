using Microsoft.EntityFrameworkCore;
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
using BookShopApp.Entities;
using BookShopDB;

namespace BookShopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BookShopDbContext DbContext = new BookShopDbContext();
        ViewModel viewModel = new ViewModel();

        public MainWindow()
        {
            InitializeComponent();
            ViewModel.ShowBooks(Table, DbContext);
            DataContext = viewModel;
        }

        private void ShowAllBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ShowBooks(Table, DbContext);
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Edit(Table, DbContext);
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            DbContext.SaveChanges();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            switch (FindByCB.Text)
            {
                case "Name":
                    ViewModel.FindByName(Table, DbContext, FindTB.Text);
                    break;
                case "Author":
                    ViewModel.FindByAuthor(Table, DbContext, FindTB.Text);
                    break;
                case "Production":
                    ViewModel.FindByProduction(Table, DbContext, FindTB.Text);
                    break;
                case "Genre":
                    ViewModel.FindByGenre(Table, DbContext, FindTB.Text);
                    break;
                default:
                    break;
            }
        }
    }
}