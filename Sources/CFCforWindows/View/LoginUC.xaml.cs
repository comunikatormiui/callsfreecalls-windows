using CFCforWindows.VM;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace CFCforWindows.View
{
    /// <summary>
    /// Interaction logic for LoginUC.xaml
    /// </summary>
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }

        private void LoginText_GotFocus(object sender, RoutedEventArgs e)
        {
            ((LoginVM)DataContext).LoginTextBoxGotFocus();
        }

        private void LoginText_LostFocus(object sender, RoutedEventArgs e)
        {
            ((LoginVM)DataContext).LoginTextBoxLostFocus();

        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            ((LoginVM)DataContext).PasswordTextBoxGotFocus();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            ((LoginVM)DataContext).PasswordTextBoxLostFocus();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ((LoginVM)DataContext).LoginClick();
        }
    }
}