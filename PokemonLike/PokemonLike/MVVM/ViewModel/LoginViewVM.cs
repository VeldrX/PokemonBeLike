using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using PokemonLike.Helpers;
using PokemonLike.Model;  // Ajouter l'espace de noms où votre DbContext est défini.

namespace PokemonLike.MVVM.ViewModel
{
    public class LoginViewVM : BaseVM
    {
        private string _username;
        private string _password;

        // Votre DbContext pour accéder aux données
        private readonly ExerciceMonsterContext _dbContext;

        // Propriétés pour lier les champs de texte
        public string Username
        {
            get => _username;
            set
            {
                SetProperty(ref _username, value);
                ((RelayCommand)LoginCommand).NotifyCanExecuteChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                SetProperty(ref _password, value);
                ((RelayCommand)LoginCommand).NotifyCanExecuteChanged();
            }
        }

        public ICommand LoginCommand { get; }
        public ICommand NavigateToMenuCommand { get; }


        // Constructeur
        public LoginViewVM()
        {
            _dbContext = new ExerciceMonsterContext(); // Initialisation du DbContext
            LoginCommand = new RelayCommand(Login, CanLogin);
            NavigateToMenuCommand = new RelayCommand(NavigateToMenu);

        }
        public void NavigateToMenu()
        {

            MainWindowVM.OnRequestChangeVM?.Invoke(new MenuViewVM());
        }

        // Méthode qui vérifie si l'utilisateur peut se connecter
        private bool CanLogin()
        {
            return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
        }

        // Méthode qui gère la connexion
        private void Login()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Tous les champs doivent être remplis.");
                return;
            }

            // Chercher l'utilisateur dans la base de données par son nom d'utilisateur
            var login = _dbContext.Logins.FirstOrDefault(l => l.Username == Username);

            if (login == null)
            {
                MessageBox.Show("Nom d'utilisateur non trouvé.");
                return;
            }

            // Hacher le mot de passe saisi
            string hashedPassword = PasswordHasher.HashPassword(Password);

            // Comparer le mot de passe haché avec celui stocké en base
            if (hashedPassword != login.PasswordHash)
            {
                MessageBox.Show("Mot de passe incorrect.");
                return;
            }

            // L'utilisateur est connecté avec succès
            MessageBox.Show("Connexion réussie !");

            // Si la connexion est réussie, nous pouvons créer un objet Player (s'il n'est pas déjà créé)
            var player = _dbContext.Players.FirstOrDefault(p => p.LoginId == login.Id);
            if (player != null)
            {
                // Connectez l'utilisateur avec son Player, par exemple, le stocker dans une variable de session
                CurrentPlayer = player;
            }
        }

        // Déclaration d'une propriété statique pour stocker le joueur connecté
        public static Player CurrentPlayer { get; private set; }
    }
}
