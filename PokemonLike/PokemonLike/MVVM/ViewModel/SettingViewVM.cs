using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using PokemonLike.Model;

namespace PokemonLike.MVVM.ViewModel
{
    internal class SettingViewVM : BaseVM
    {
        private string _databaseConnection;

        public string DatabaseConnection
        {
            get => _databaseConnection;
            set => SetProperty(ref _databaseConnection, value);
        }


        private string currentConnectionDisplay;
        public string CurrentConnectionDisplay
        {
            get => currentConnectionDisplay;
            set => SetProperty(ref currentConnectionDisplay, value);
        }

        public ICommand NavigateMenuCommand { get; }
        public ICommand SaveCommand { get; }

        public SettingViewVM()
        {
            DatabaseConnection = ExerciceMonsterContext.ConnectionString;
            CurrentConnectionDisplay = DatabaseConnection;
            SaveCommand = new RelayCommand(SaveConnectionString);
            NavigateMenuCommand = new RelayCommand(NavigateToMenu);
        }

        private void SaveConnectionString()
        {
            if (!string.IsNullOrWhiteSpace(DatabaseConnection))
            {
                ExerciceMonsterContext.ConnectionString = DatabaseConnection;
                CurrentConnectionDisplay = DatabaseConnection;

                // Débogage
                Debug.WriteLine($"Nouvelle chaîne de connexion : {ExerciceMonsterContext.ConnectionString}");
                System.Windows.MessageBox.Show("Chaîne de connexion mise à jour avec succès !");
            }
            else
            {
                Debug.WriteLine("La chaîne de connexion est vide !");
                System.Windows.MessageBox.Show("Veuillez entrer une chaîne de connexion valide.");
            }

        }

        public void NavigateToMenu()
        {

            MainWindowVM.OnRequestChangeVM?.Invoke(new MenuViewVM());
        }

    }
}

