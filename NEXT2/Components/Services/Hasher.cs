﻿using System.Security.Cryptography;
namespace NEXT2.Components.Services
    {
        public class Hasher
        {
            private const int saltSize = 16; //128
            private const int keySize = 32; //256
            private const int iterations = 50000;
            private static readonly HashAlgorithmName algorithm = HashAlgorithmName.SHA256; //256 bits
            private const char segmenter = ':';

            public static string Hash(string input)
            {
                byte[] salt = RandomNumberGenerator.GetBytes(saltSize);
                byte[] hash = Rfc2898DeriveBytes.Pbkdf2(input, salt, iterations, algorithm, keySize);
                return string.Join(segmenter, Convert.ToHexString(hash), Convert.ToHexString(salt), iterations, algorithm);
            }

            public static bool Verify(string input, string hashString)
            {
                string[] segments = hashString.Split(segmenter);
                byte[] hash = Convert.FromHexString(segments[0]);
                byte[] salt = Convert.FromHexString(segments[1]);
                int iterations = int.Parse(segments[2]);
                HashAlgorithmName algorithm = new HashAlgorithmName(segments[3]);
                byte[] inputHash = Rfc2898DeriveBytes.Pbkdf2(input, salt, iterations, algorithm, hash.Length);
                return CryptographicOperations.FixedTimeEquals(inputHash, hash);
            }
        }
    }
