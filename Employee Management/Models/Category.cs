using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    /// <summary>
    /// Represents a business unit or operational sector classification entity within the enterprise domain layer.
    /// Used primarily to map cross-functional category groupings dynamically over onto department selections.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the unique structural primary key identifier for the classification entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the explicit nomenclature name defining the organizational division.
        /// Defaults to an empty string to prevent structural null reference anomalies.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Gets or sets descriptive contextual metadata details outlining the scope of the designation.
        /// </summary>
        public string Description { get; set; } = "";
    }
}