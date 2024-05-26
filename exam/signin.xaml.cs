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

namespace exam
{
    /// <summary>
    /// Interaction logic for signin.xaml
    /// </summary>
    public partial class signin : Page
    {
        tryyEntities db=new tryyEntities();
        public signin()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr m=new userr();
            m = db.userr.FirstOrDefault(x => x.userr_name == u1.Text);
            if(m.userr_pass==p1.Password)
            {
                profile p=new profile(m);
                this.NavigationService.Navigate(p);
            }

        }
    }
}
