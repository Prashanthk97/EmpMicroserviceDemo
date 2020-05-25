using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmpMicroserviceDemo.Model
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [Column("FirstName")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Column("LastName")]
        [StringLength(30)]
        public string LastName { get; set; }

        [Column("Gender")]
        [StringLength(10)]
        public string Gender { get; set; }

        [Column("Designation")]
        [StringLength(30)]
        public string Designation { get; set; }

        [Column("Department")]
        [StringLength(30)]
        public string Department { get; set; }
    }
}


