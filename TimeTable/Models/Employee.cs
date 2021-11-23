using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TimeTable
{
    [Table("EMPLOYEES")]
    [Index(nameof(EmployeeEgn), Name = "IDX_EMPLOYEE_UQ", IsUnique = true)]
    public partial class Employee
    {
        [Key]
        [Column("EMPLOYEE_ID")]
        public int EmployeeId { get; set; }
        [Required]
        [Column("EMPLOYEE_EGN")]
        [StringLength(10)]
        public string EmployeeEgn { get; set; }
        [Required]
        [Column("EMPLOYEE_NAME")]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [Required]
        [Column("EMPLOYEE_SURNAME")]
        [StringLength(50)]
        public string EmployeeSurname { get; set; }
        [Required]
        [Column("EMPLOYEE_LASTNAME")]
        [StringLength(50)]
        public string EmployeeLastname { get; set; }
        [Column("EMPLOYEE_POSITION")]
        [StringLength(50)]
        public string EmployeePosition { get; set; }
        [Column("EMPLOYEE_HIREDATE", TypeName = "date")]
        public DateTime? EmployeeHiredate { get; set; }
    }
}
