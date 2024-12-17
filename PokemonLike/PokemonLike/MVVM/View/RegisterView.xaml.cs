using System.Windows;
using System.Windows.Controls;
using PokemonLike.MVVM.ViewModel;

namespace PokemonLike.MVVM.View
{
    /// <summary>
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class RegisterView : UserControl
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as RegisterViewVM;
            if (vm != null)
            {
                vm.Password = PasswordBox.Password;
                vm.ConfirmPassword = ConfirmPasswordBox.Password;
                vm.RegisterCommand.Execute(null);
            }
        }
    }
}
