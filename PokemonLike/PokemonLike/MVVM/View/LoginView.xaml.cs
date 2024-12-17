using System.Windows;
using System.Windows.Controls;
using PokemonLike.MVVM.ViewModel;

namespace PokemonLike.MVVM.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = (PasswordBox)sender;
            var viewModel = (LoginViewVM)this.DataContext;

            // Mettre à jour la propriété Password du ViewModel
            viewModel.Password = passwordBox.Password;
        }

    }
}
