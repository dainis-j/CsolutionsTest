using CsolutionsTest.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace CsolutionsTest.Data.Models
{
    public class AuditOperation
    {
        [Key]
        public int Id { get; set; }

        public AuditOperationType Type { get; set; }

        public DateTime Date;

        /// <summary>
        /// Gets or sets the operation payload, such as the modified object's ID.
        /// </summary>
        public string Payload { get; set; } = string.Empty;
    }
}
