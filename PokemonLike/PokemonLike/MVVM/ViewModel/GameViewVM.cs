using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using PokemonLike.Model;

namespace PokemonLike.MVVM.ViewModel
{
    internal class GameViewVM : BaseVM
    {

        private string _battleLog;
        public string BattleLog
        {
            get => _battleLog;
            set
            {
                if (_battleLog != value)
                {
                    _battleLog = value;
                    OnPropertyChanged(nameof(BattleLog));
                }
            }
        }

        // Commande pour utiliser une compétence
        public ICommand UseSkillCommand { get; }



        private Player _currentPlayer;
        //private Monster _monsterOfPlayer;
        private readonly ExerciceMonsterContext _dbContext;

        private int _monsterOfEnnemyCurrentHP;

        // Propriétés pour le monstre du joueur
        public Monster MonsterOfPlayer { get; set; }
        public int MonsterOfPlayerHP { get; set; }
        public int MonsterOfPlayerCurrentHP { get; set; }
        public int Score { get; set; }


        // Propriétés pour le monstre de l'ennemi


        private Monster _monsterOfEnnemy;
        public Monster MonsterOfEnnemy
        {
            get => _monsterOfEnnemy;
            set
            {
                if (_monsterOfEnnemy != value)
                {
                    _monsterOfEnnemy = value;
                    OnPropertyChanged(nameof(MonsterOfEnnemy));  // Notifier la vue
                }
            }
        }

        private int _monsterOfEnnemyHP;
        public int MonsterOfEnnemyHP
        {
            get => _monsterOfEnnemyHP;
            set
            {
                if (_monsterOfEnnemyHP != value)
                {
                    _monsterOfEnnemyHP = value;
                    OnPropertyChanged(nameof(MonsterOfEnnemyHP));  // Notifier la vue de la modification
                }
            }
        }

        public int MonsterOfEnnemyCurrentHP
        {
            get => _monsterOfEnnemyCurrentHP;
            set
            {
                if (_monsterOfEnnemyCurrentHP != value)
                {
                    _monsterOfEnnemyCurrentHP = value;
                    OnPropertyChanged(nameof(MonsterOfEnnemyCurrentHP));  // Notifier la vue de la modification
                }
            }
        }

        // Liste des compétences du monstre du joueur
        public ObservableCollection<Spell> MonsterOfPlayerSpells { get; set; }

        // Propriétés de commandes
        public ICommand NavigatePokemonListCommand { get; }
        public ICommand NavigateAbilityListCommand { get; }
        public ICommand NavigateMenuCommand { get; }
        public ICommand RestartBattleCommand { get; }


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
            RestartBattleCommand = new RelayCommand(RestartBattle);  // Commande de relance du combat
            UseSkillCommand = new RelayCommand<Spell>(UseSkill);


        }

        private void UseSkill(Spell skill)
        {
            if (skill != null)
            {
                BattleLog = $"{PlayerName} a utilisé {skill.Name}";
                // Forcer une notification même si la valeur n'a pas changé
                OnPropertyChanged(nameof(BattleLog));
            }
        }



        private void RestartBattle()
        {


            // Régénérer un monstre ennemi aléatoire
            Random rand = new Random();
            _monsterOfEnnemy = _dbContext.Monsters
                .AsEnumerable()  // Charger tous les monstres en mémoire
                .OrderBy(m => rand.Next())  // Mélanger les monstres en mémoire
                .FirstOrDefault();  // Sélectionner un monstre aléatoire

            if (_monsterOfEnnemy != null)
            {
                // Mettre à jour les propriétés et notifier l'interface utilisateur
                MonsterOfEnnemy = _monsterOfEnnemy;
                MonsterOfEnnemyHP = _monsterOfEnnemy.Health;
                MonsterOfEnnemyCurrentHP = MonsterOfEnnemyHP;
            }

            // Réinitialiser les HP du joueur et de son monstre
            MonsterOfPlayerCurrentHP = MonsterOfPlayerHP;  // Réinitialiser les HP du joueur
            MainWindowVM.OnRequestChangeVM?.Invoke(new GameViewVM());

        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
