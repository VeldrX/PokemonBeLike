using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using PokemonLike.Model;

namespace PokemonLike.MVVM.ViewModel
{
    public class RegisterViewVM : BaseVM
    {
        private string _username;
        private string _password;
        private string _confirmPassword;

        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set => SetProperty(ref _confirmPassword, value);
        }

        public ICommand RegisterCommand { get; }

        public RegisterViewVM()
        {
            RegisterCommand = new RelayCommand(Register);
            NavigateToMenuCommand = new RelayCommand(NavigateToMenu);

        }

        private void Register()
        {
            if (string.IsNullOrWhiteSpace(Username) ||
                string.IsNullOrWhiteSpace(Password) ||
                string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                MessageBox.Show("Tous les champs doivent être remplis.");
                return;
            }

            if (Password != ConfirmPassword)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
                return;
            }

            try
            {
                using (var context = new ExerciceMonsterContext())
                {
                    // Hashage du mot de passe avec SHA256
                    string passwordHash = HashPassword(Password);

                    // Création de l'objet Login
                    var newLogin = new Login
                    {
                        Username = Username,
                        PasswordHash = passwordHash
                    };

                    // Ajout du Login à la base de données
                    context.Logins.Add(newLogin);
                    context.SaveChanges(); // Enregistrement du Login dans la base

                    // Création d'un Player avec le Username comme Name et le LoginId
                    var newPlayer = new Player
                    {
                        Name = Username,
                        LoginId = newLogin.Id // Associe le Player au Login créé
                    };

                    // Ajout du Player à la base de données
                    context.Players.Add(newPlayer);
                    context.SaveChanges(); // Enregistrement du Player dans la base

                    MessageBox.Show("Inscription réussie !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite: {ex.Message}");
            }
        }

        // Fonction pour hasher le mot de passe avec SHA256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public ICommand NavigateToMenuCommand { get; }
        private void NavigateToMenu()
        {
            MainWindowVM.OnRequestChangeVM?.Invoke(new MenuViewVM());

        }
    }
}
