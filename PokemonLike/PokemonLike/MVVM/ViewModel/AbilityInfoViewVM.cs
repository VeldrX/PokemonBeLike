using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using PokemonLike.Model;

namespace PokemonLike.MVVM.ViewModel
{
    internal class AbilityInfoViewVM : BaseVM
    {
        private readonly ExerciceMonsterContext _dbContext;

        public ICommand NavigateAbilityListCommand { get; }

        public Spell _selectedSpell { get; }
        public int Id => _selectedSpell.Id;
        public string Name => _selectedSpell.Name;
        public int Damage => _selectedSpell.Damage;
        public string Description => _selectedSpell.Description;

        public List<Monster> AssociatedMonsters { get; set; } // Liste des Pokémon associés au sort

        public AbilityInfoViewVM(Spell spell)
        {
            _selectedSpell = spell;
            _dbContext = new ExerciceMonsterContext(); // Créez une instance du contexte

            // Récupérez les Pokémon associés au sort
            AssociatedMonsters = _dbContext.Monsters
                .Where(m => m.Spells.Any(s => s.Id == _selectedSpell.Id)) // Associe les Pokémon qui ont ce sort
                .ToList();

            NavigateAbilityListCommand = new RelayCommand(NavigateToAbilityList);
        }

        public void NavigateToAbilityList()
        {
            MainWindowVM.OnRequestChangeVM?.Invoke(new AbilityListeViewVM());
        }
    }
}
