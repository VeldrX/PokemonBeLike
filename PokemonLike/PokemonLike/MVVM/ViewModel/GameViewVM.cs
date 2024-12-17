using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using PokemonLike.Model;

namespace PokemonLike.MVVM.ViewModel
{
    internal class GameViewVM : BaseVM
    {
        private Player _currentPlayer;
        private Monster _monsterOfPlayer;
        private Monster _monsterOfEnnemy;
        private readonly ExerciceMonsterContext _dbContext;

        // Propriétés pour le monstre du joueur
        public Monster MonsterOfPlayer { get; set; }
        public int MonsterOfPlayerHP { get; set; }
        public int MonsterOfPlayerCurrentHP { get; set; }
        public int Score { get; set; }


        // Propriétés pour le monstre de l'ennemi
        public Monster MonsterOfEnnemy { get; set; }
        public int MonsterOfEnnemyHP { get; set; }
        public int MonsterOfEnnemyCurrentHP { get; set; }

        // Liste des compétences du monstre du joueur
        public ObservableCollection<Spell> MonsterOfPlayerSpells { get; set; }

        // Propriétés de commandes
        public ICommand NavigatePokemonListCommand { get; }
        public ICommand NavigateAbilityListCommand { get; }
        public ICommand NavigateMenuCommand { get; }

        public string PlayerName => _currentPlayer?.Name;

        public GameViewVM()
        {
            Score = 0;
            _dbContext = new ExerciceMonsterContext();
            _currentPlayer = LoginViewVM.CurrentPlayer;
            LoadPlayerAndMonsters();

            // Initialisation des commandes
            NavigatePokemonListCommand = new RelayCommand(NavigateToPokemonList);
            NavigateAbilityListCommand = new RelayCommand(NavigateToAbilityList);
            NavigateMenuCommand = new RelayCommand(NavigateToMenu);
        }

        // Charger le joueur et ses monstres associés, et aussi un monstre ennemi aléatoire
        private void LoadPlayerAndMonsters()
        {
            if (_currentPlayer != null)
            {
                // Charger le joueur avec ses monstres associés
                _currentPlayer = _dbContext.Players
                    .Include(p => p.Monsters)  // Inclure les monstres associés
                    .ThenInclude(m => m.Spells)  // Inclure les sorts des monstres
                    .FirstOrDefault(p => p.Id == _currentPlayer.Id);

                // Assurez-vous que le joueur a des monstres
                if (_currentPlayer != null && _currentPlayer.Monsters.Any())
                {
                    // Sélectionner le premier monstre du joueur
                    MonsterOfPlayer = _currentPlayer.Monsters.FirstOrDefault();
                    MonsterOfPlayerSpells = new ObservableCollection<Spell>(MonsterOfPlayer?.Spells ?? new List<Spell>());
                    MonsterOfPlayerHP = MonsterOfPlayer?.Health ?? 0;
                    MonsterOfPlayerCurrentHP = MonsterOfPlayerHP; // Initialiser avec la valeur de HP
                }

                // Choisir un monstre ennemi aléatoire parmi les monstres de la base de données
                Random rand = new Random();
                _monsterOfEnnemy = _dbContext.Monsters
                    .AsEnumerable()  // Charger tous les monstres en mémoire
                    .OrderBy(m => rand.Next())  // Mélanger les monstres en mémoire
                    .FirstOrDefault();  // Sélectionner un monstre aléatoire

                if (_monsterOfEnnemy != null)
                {
                    MonsterOfEnnemy = _monsterOfEnnemy;
                    MonsterOfEnnemyHP = _monsterOfEnnemy.Health;
                    MonsterOfEnnemyCurrentHP = MonsterOfEnnemyHP;  // Initialiser avec la valeur de HP
                }
            }
        }

        // Navigation vers les autres vues
        private void NavigateToPokemonList() => MainWindowVM.OnRequestChangeVM?.Invoke(new PokemonListeViewVM());
        private void NavigateToAbilityList() => MainWindowVM.OnRequestChangeVM?.Invoke(new AbilityListeViewVM());
        private void NavigateToMenu() => MainWindowVM.OnRequestChangeVM?.Invoke(new MenuViewVM());
    }
}
