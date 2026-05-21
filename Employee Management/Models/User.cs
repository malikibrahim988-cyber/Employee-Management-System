using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    /// <summary>
    /// Represents the core authentication and identity account entity within the enterprise domain layer.
    /// Maps relational credential fields and dynamic onboarding profile settings straight into 
    /// strongly-typed system structures.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique structural primary key auto-increment identifier for the account.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the unique alphanumeric login credential handle.
        /// Defaults to an empty string to safeguard against unhandled null assignment errors.
        /// </summary>
        public string Username { get; set; } = "";

        /// <summary>
        /// Gets or sets the cryptographically hashed secret string pattern for identity verification.
        /// </summary>
        public string PasswordHash { get; set; } = "";

        /// <summary>
        /// Gets or sets the verified legal nomenclature name assigned during the profile setup loop.
        /// </summary>
        public string FullName { get; set; } = "";

        /// <summary>
        /// Gets or sets the associated operational business unit segment chosen during profile setup.
        /// </summary>
        public string Department { get; set; } = "";
    }
}
