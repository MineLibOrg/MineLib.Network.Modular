﻿using System.Globalization;

namespace MineLib.Core
{
    /// <summary>
    /// Helper class to implement Java-style handling with some types.
    /// Thanks to SirCmpwn!
    /// </summary>
    public static class JavaHelper
    {
        /// <summary>
        /// Produces a Java-style SHA-1 hex digest of the given data.
        /// </summary>
        public static string JavaHexDigest(byte[] data)
        {
            var sha1 = new SHA1();
            sha1.HashCore(data, 0 , data.Length);
            var hash = sha1.HashFinal();

            var negative = (hash[0] & 0x80) == 0x80;
            if (negative) // check for negative hashes
                hash = TwosCompliment(hash);
            // Create the string and trim away the zeroes
            var digest = GetHexString(hash).TrimStart('0');
            if (negative)
                digest = "-" + digest;
            return digest;
        }
        
        /// <summary>
        /// Converts the given n-bit little-endian unsigned number into
        /// lowercase hexadecimal form.
        /// </summary>
        private static string GetHexString(byte[] data)
        {
            var result = "";
            foreach (byte hex in data)
                result += hex.ToString("x2", CultureInfo.InvariantCulture);
            return result;
        }

        /// <summary>
        /// Given an array that represents an n-bit little-endian signed number,
        /// the two's compliment (negation) is produced.
        /// </summary>
        private static byte[] TwosCompliment(byte[] data)
        {
            var carry = true;
            for (var i = data.Length - 1; i >= 0; i--)
            {
                data[i] = (byte) ~data[i];
                if (carry)
                {
                    carry = data[i] == 0xFF;
                    data[i]++;
                }
            }
            return data;
        }
    }
}