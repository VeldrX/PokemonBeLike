# Monster Battle - Jeu de Combat de Monstres

## Description
Ceci est un jeu de combat de monstres développé en C# avec WPF (Windows Presentation Foundation) pour un projet scolaire. Le joueur affronte des monstres ennemis générés aléatoirement en utilisant les capacités de son propre monstre. Le jeu propose un système de Pokedex et d'une liste des Compétences disponibles , les 2 ont une possibilité de voir plus en détail le Pokemon ou la Compétence. Le jeu dois contenir un systeme de combat pas encore fonctionnel.

---

## Fonctionnalités
- **Gestion Compte** : Possibilité de créé un compte et de s'y connecté pour gardé le pokémon choisis.
- **Affrontement de monstres(Non-fonctionnel , le monstre est seulement généré aléatoirement)** : Combattez un monstre généré aléatoirement. 
- **Liste des Pokémons** : Visualisez tout les monstres disponible avec possibilité de les selectionné pour le combat et de voir plus en détail les informations.
- **Liste des Abilités** : Visualisez toute les abilités disponible avec possibilité de voir plus en détail les informations.

---

## Prérequis
- **Environnement de développement** : Visual Studio 2022 ou version ultérieure
- **Framework** : .NET 6 ou supérieur
- **Base de données** : SQLite (ou autre base de données prise en charge par Entity Framework Core)

---

## Installation
1. Clonez le dépôt :
   ```bash
   git clone https://github.com/VeldrX/PokemonBeLike.git
   ```
2. Ouvrez le projet dans Visual Studio.
3. Restaurez les packages NuGet requis si besoin.
4. Lancez l'application.

---


---

## Utilisation
1. **Lancer le jeu** : Exécutez l'application.
2. **Aller dans les Settings** : Dans Setting vous avez la possibilité de lier votre base de donné en donnant l'adresse du server sql (exemple :  "Server=MV_PERSONAL_LAP\SQLEXPRESS;Database=ExerciceMonster;Trusted_Connection=True;TrustServerCertificate=True;";).
3. **Crée un compte** : Sur register vous avez la possibilité de crée un compte.
4. **Se connecter** : Sur Login vous pouvez vous connecté a votre compte.
5. **Jouer** : Le bouton Play vous envoie directement sur la page principale du jeu le combat (peu fonctionnel)
6. **Pokedex** : Vous avez la possibilité d'accedé au Pokédex qui répertorie tous les pokémons du jeu , de plus vous avez 2 possibilités : 
    - Soit selectionné le pokémon pour l'utiliser en combat
    - Soit aller voir ses information
7. **AbilityDex** : Vous avez la possibilité d'accedé a l'AbilityDex qui répertorie toute les compétences du jeu , de plus vous avez la possibilité d'aller voir ses informations.
8. **Relancer** : Dans la page de combat il y a la possibilité de générer un nouvel ennemie.


---

## Technologies Utilisées
- **Langage** : C#
- **Framework** : WPF (.NET 6)
- **ORM** : Entity Framework Core
- **Base de données** : SQL

---

## Contributions
Les contributions sont les bienvenues ! Veuillez suivre ces étapes :
1. Forkez le dépôt.
2. Créez une branche de fonctionnalité : `git checkout -b feature/nom-de-la-fonctionnalité`
3. Commitez vos modifications : `git commit -m "Ajout de la fonctionnalité X"`
4. Poussez vers le dépôt distant : `git push origin feature/nom-de-la-fonctionnalité`
5. Créez une Pull Request.

---

## Auteurs
- **Nom** : VassyMathis
- **Contact** : mathisvassypro@gmail.com

---

---


---

**Amusez-vous à affronter des monstres dans Monster Battle !**
