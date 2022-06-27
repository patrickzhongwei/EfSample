using EfSample.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfSample.DataModels
{
    [Index(nameof(ClassName), IsUnique = true)]
    [Index(nameof(ClassLanguage), IsUnique = false)]
    //[Index(nameof(ClassName), nameof(ClassLanguage), IsUnique = false)]
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [MaxLength(255)]
        [ConcurrencyCheck]      
        public string ClassName { get; set; }

        [Required]
        public int MaxClassSize { get; set; }

        public Language ClassLanguage { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Fee { get; set; }

    }
}