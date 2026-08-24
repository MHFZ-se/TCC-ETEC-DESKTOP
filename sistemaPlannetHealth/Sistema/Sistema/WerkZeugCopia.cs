using System;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto.Generators;

namespace Sistema
{
    internal  class WerkzeugCopia
    {
        private const int N = 32768;
        private const int R = 8;
        private const int P = 1;
        private const int DKLEN = 64;

        public static string Generate(string senha)
        //realiza o hash da senha
        //neste trecho foi usada ia para realizar uma copia da biblioteca werkzeug
        {
            // Werkzeug usa 16 caracteres de salt
            string salt = GerarSalt(16);

            byte[] senhaBytes = Encoding.UTF8.GetBytes(senha);
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);

            byte[] hashBytes = SCrypt.Generate(
                senhaBytes,
                saltBytes,
                N,
                R,
                P,
                DKLEN
            );

            string hash = BitConverter.ToString(hashBytes)
                .Replace("-", "")
                .ToLowerInvariant();

            return $"scrypt:{N}:{R}:{P}${salt}${hash}";
        }

        private static string GerarSalt(int tamanho)
        {
            const string caracteres =
                "abcdefghijklmnopqrstuvwxyz" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "0123456789-_";

            byte[] bytes = new byte[tamanho];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }

            StringBuilder salt = new StringBuilder(tamanho);

            foreach (byte b in bytes)
            {
                salt.Append(caracteres[b % caracteres.Length]);
            }

            return salt.ToString();
        }

        public bool validarSenha(string senha, string senhaBanco)
        {
            if (senha == senhaBanco)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}