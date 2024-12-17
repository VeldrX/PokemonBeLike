using System.Security.Cryptography;
using System.Text;

namespace PokemonLike.Helpers
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convertir le mot de passe en tableau de bytes
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                // Calculer le hash
                byte[] hash = sha256.ComputeHash(bytes);

                // Convertir le hash en une chaîne lisible
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hash)
                {
                    hashString.Append(b.ToString("x2")); // Hexadécimal
                }

                return hashString.ToString();
            }
        }
    }
}

