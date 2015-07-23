﻿using System;
using System.IO;
using System.Text;

namespace managedcrypter
{
    public static class Utils
    {
        private static Random Rand = new Random();
        private static char[] Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();

        public static string GenerateRandomString(int len)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
                sb.Append(Chars[Rand.Next(0, Chars.Length)]);
            return sb.ToString();
        }

        public static string GenerateRandomString(int min, int max)
        {
            int len = Rand.Next(min, max);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
                sb.Append(Chars[Rand.Next(0, Chars.Length)]);
            return sb.ToString();
        }

        public static void ReplaceStringInFile(string filePath, string strToReplace, string strReplaceWith)
        {
            File.WriteAllText(filePath, File.ReadAllText(filePath).Replace(strToReplace, strReplaceWith));
        }

    }
}
