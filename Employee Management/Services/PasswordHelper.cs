using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Employee_Management.Services
{
    /// <summary>
    /// Cryptographic helper service managing password string security processing operations.
    /// Utilizes the BCrypt adaptive hashing algorithm to enforce data-at-rest protection.
    /// </summary>
    public class PasswordHelper
    {
        /// <summary>
        /// Converts a plaintext password string into a secure cryptographic hash pattern.
        /// </summary>
        /// <param name="password">The raw input security string needing transformation.</param>
        /// <returns>A secure cryptographic hash string containing the embedded salt signature.</returns>
        public static string HashPassword(string password)
        {
            // BCrypt automatically generates a safe random salt and bakes it into the output string.
            // Using workFactor 10 sets a balanced processing time vs brute-force resistance curve.
            return BCrypt.Net.BCrypt.HashPassword(password, workFactor: 10);
        }

        /// <summary>
        /// Verifies a plain-text password attempt against an existing database hash signature record.
        /// </summary>
        /// <param name="password">The plain-text authentication token provided during authentication loops.</param>
        /// <param name="hashedPassword">The cryptographically protected storage string retrieved from the database.</param>
        /// <returns>True if the evaluation yields a successful cryptographic match; otherwise, false.</returns>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Parses the embedded salt from the hash string internally to perform secure cross-verification
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}