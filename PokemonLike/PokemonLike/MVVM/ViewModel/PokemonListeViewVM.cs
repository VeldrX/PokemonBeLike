using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using PokemonLike.Model;

namespace PokemonLike.MVVM.ViewModel
{
    internal class PokemonListeViewVM : BaseVM
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




        private readonly ExerciceMonsterContext _dbContext;
        public ObservableCollection<Monster> Monsters { get; set; }

        public ICommand NavigateToPokemonInfoCommand { get; }
        public ICommand NavigateToGameCommand { get; }
        public ICommand SelectPokemonCommand { get; }

        public PokemonListeViewVM()
        {
            _dbContext = new ExerciceMonsterContext();
            _currentPlayer = LoginViewVM.CurrentPlayer;
            LoadMonsters();

            NavigateToPokemonInfoCommand = new RelayCommand<Monster>(NavigateToPokemonInfo);
            NavigateToGameCommand = new RelayCommand(NavigateToGameView);
            SelectPokemonCommand = new RelayCommand<Monster>(SelectPokemon);
        }

        private void LoadMonsters()
        {
            Monsters = new ObservableCollection<Monster>(_dbContext.Monsters);
        }

        private void NavigateToPokemonInfo(Monster selectedMonster)
        {
            if (selectedMonster != null)
            {
                MainWindowVM.OnRequestChangeVM?.Invoke(new PokemonInfoViewVM(selectedMonster));
            }
        }

        private void NavigateToGameView()
        {
            MainWindowVM.OnRequestChangeVM?.Invoke(new GameViewVM());
        }

        private void SelectPokemon(Monster selectedMonster)
        {
            if (_currentPlayer == null || selectedMonster == null)
            {
                MessageBox.Show("Aucun joueur ou Pokémon sélectionné.");
                return;
            }

            // Recharge le joueur avec ses monstres associés
            _currentPlayer = _dbContext.Players
                .Include(p => p.Monsters)
                .FirstOrDefault(p => p.Id == _currentPlayer.Id);

            if (_currentPlayer == null)
            {
                MessageBox.Show("Erreur : Joueur introuvable.");
                return;
            }

            // Vérifie si le Pokémon est déjà sélectionné
            if (_currentPlayer.Monsters.Any(m => m.Id == selectedMonster.Id))
            {
                MessageBox.Show($"Le Pokémon {selectedMonster.Name} est déjà sélectionné.");
                return;
            }

            // Supprimer les anciens Pokémon
            _currentPlayer.Monsters.Clear();
            _dbContext.SaveChanges();

            // Ajouter le nouveau Pokémon
            _currentPlayer.Monsters.Add(selectedMonster);
            _dbContext.SaveChanges();

            MessageBox.Show($"Le Pokémon {selectedMonster.Name} a été sélectionné pour le joueur {_currentPlayer.Name}.");
        }













    }
}
