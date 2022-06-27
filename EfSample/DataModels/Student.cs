using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfSample.DataModels
{
    public class Student
    {
        public int StudentId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string StudentName { get; set; }

        public int Age { get; set; }

        public List<Class> StudentClasses { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
       
    }
    
}
