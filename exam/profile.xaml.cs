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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        tryyEntities db=new tryyEntities();
        public profile(userr user)
        {
            InitializeComponent();
            name.Content=user.userr_name;
            pass.Content=user.userr_pass;
            age.Content=user.userr_age;
            gender.Content=user.userr_gender;
            phone.Content=user.userr_phone;
            city.Content=user.userr_city;
        }
    }
}
