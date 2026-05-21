using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    /// <summary>
    /// Represents the primary personnel data model entity within the enterprise domain layer.
    /// Maps relational database row attributes straight into strongly-typed objects 
    /// for application-wide data binding and validation routines.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the unique tracking primary key identifier for the employee record.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the full legal nomenclature name of the personnel entity.
        /// Initialized to an empty string to safeguard against null-pointer operations.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Gets or sets the gross monthly compensation metric for calculation and grid displays.
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Gets or sets the associated operational business unit or category segment designation.
        /// Initialized to an empty string to safeguard against null-pointer operations.
        /// </summary>
        public string Department { get; set; } = "";

        /// <summary>
        /// Gets or sets the functional job title or assigned operational system permission tier.
        /// Initialized to an empty string to safeguard against null-pointer operations.
        /// </summary>
        public string Role { get; set; } = "";
    }
}