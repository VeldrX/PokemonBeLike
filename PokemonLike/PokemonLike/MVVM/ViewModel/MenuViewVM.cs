using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using PokemonLike.Model;

namespace PokemonLike.MVVM.ViewModel
{
    internal class MenuViewVM : BaseVM
    {

        private Player _currentPlayer;

        public string PlayerName
        {
            get => _currentPlayer?.Name ?? "Joueur non connecté";
            set
            {
                if (_currentPlayer != null && _currentPlayer.Name != value)
                {
                    _currentPlayer.Name = value;  // Mise à jour du nom du joueur
                    OnPropertyChanged();          // Notifiez la vue que la propriété a changé
                }
            }
        }




        public ICommand NavigateSettingCommand { get; }
        public ICommand NavigateGameCommand { get; }
        public ICommand NavigateRegisterCommand { get; }
        public ICommand NavigateLoginCommand { get; }


        public MenuViewVM()
        {
            _currentPlayer = LoginViewVM.CurrentPlayer;
            NavigateSettingCommand = new RelayCommand(NavigateToSetting);
            NavigateGameCommand = new RelayCommand(NavigateToGame);
            NavigateRegisterCommand = new RelayCommand(NavigateToRegister);
            NavigateLoginCommand = new RelayCommand(NavigateToLogin);



        }

        public void NavigateToSetting()
        {

            MainWindowVM.OnRequestChangeVM?.Invoke(new SettingViewVM());
        }

        public void NavigateToGame()
        {

            MainWindowVM.OnRequestChangeVM?.Invoke(new GameViewVM());
        }

        public void NavigateToRegister()
        {

            MainWindowVM.OnRequestChangeVM?.Invoke(new RegisterViewVM());
        }
        public void NavigateToLogin()
        {

            MainWindowVM.OnRequestChangeVM?.Invoke(new LoginViewVM());
        }


        public override void OnShowVM()
        {
            //Display popup for information
            MessageBox.Show("Main view display");
        }


    }
}