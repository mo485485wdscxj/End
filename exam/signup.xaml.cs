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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        tryyEntities db=new tryyEntities();
        public signup()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            signin s= new signin();
            this.NavigationService.Navigate(s);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            userr r= new userr();
            r.userr_name = username.Text;
            r.userr_pass = password.Password;
            r.userr_age=Convert.ToInt32(age.Text);
            r.userr_phone = phonenum.Text;
            if(r1.IsChecked==true)
            {
                r.userr_gender="male";

            }
            else if (r2.IsChecked == true)
            {
                r.userr_gender = "female";
            }

            r.userr_city=comboBox.Text;
            db.userr.Add(r);
            db.SaveChanges();
            MessageBox.Show("Added");
            signin n= new signin();
            this.NavigationService.Navigate(n);

        }
    }
}
