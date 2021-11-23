using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TimeTable
{
    [Table("PROJECT_HOURS")]
    public partial class ProjectHour
    {
        [Key]
        [Column("PROJECT_ID")]
        public int ProjectId { get; set; }
        [Key]
        [Column("EMPLOYEE_ID")]
        public int EmployeeId { get; set; }
        [Key]
        [Column("PROJECT_TASKDATE", TypeName = "date")]
        public DateTime ProjectTaskdate { get; set; }
        [Column("PROJECT_MONTH_ID")]
        public int? ProjectMonthId { get; set; }
        [Required]
        [Column("PROJECT_TASK")]
        [StringLength(50)]
        public string ProjectTask { get; set; }
        [Column("PROJECT_HOURS")]
        public int ProjectHours { get; set; }
    }
}
