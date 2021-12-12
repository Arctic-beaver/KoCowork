using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
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

namespace CoCoworkView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Client client = new Client();
            var repo = new ClientRepository();

            client.FirstName = "Юрец";
            client.LastName = "Квадрокоптер";
            DateTime dt = new DateTime(2008, 04, 01);
            client.DateBirth = dt;
            client.Phone = "+79817648352";
            client.PaperAmount = 0;
            client.PaperEndDay = null;
            client.Email = "JarenieGvozdi@yandex.ru";

            repo.DeleteClientById(3);

            int num = 42;
        }
    }
}
