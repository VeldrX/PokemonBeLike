using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using PokemonLike.Model;

namespace PokemonLike.MVVM.ViewModel
{
    internal class PokemonInfoViewVM : BaseVM
    {
        private ExerciceMonsterContext _dbContext;
        private Monster _selectedMonster;

        public ObservableCollection<Spell> Spells { get; set; }

        public ICommand NavigatePokemonListCommand { get; }

        // Propriétés pour les détails du monstre
        public int Id => _selectedMonster.Id;
        public string Name => _selectedMonster.Name;
        public int Health => _selectedMonster.Health;

        // Constructeur qui initialise la VM avec le monstre passé en paramètre
        public PokemonInfoViewVM(Monster monster)
        {
            _dbContext = new ExerciceMonsterContext();

            // Charger le monstre et ses sorts associés via la relation Many-to-Many
            _selectedMonster = _dbContext.Monsters
                .Include(m => m.Spells)  // 
                .FirstOrDefault(m => m.Id == monster.Id);

            if (_selectedMonster == null)
            {
                throw new Exception("Monstre introuvable !");
            }

            // Remplir la collection ObservableCollection avec les sorts du monstre
            Spells = new ObservableCollection<Spell>(_selectedMonster.Spells);

            // Initialiser la commande de navigation
            NavigatePokemonListCommand = new RelayCommand(NavigateToPokemonList);
        }

        // Méthode pour naviguer vers la liste des Pokémon
        public void NavigateToPokemonList()
        {
            MainWindowVM.OnRequestChangeVM?.Invoke(new PokemonListeViewVM());
        }
    }
}
