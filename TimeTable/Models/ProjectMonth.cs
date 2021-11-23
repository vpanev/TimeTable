using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TimeTable
{
    [Table("PROJECT_MONTHS")]
    [Index(nameof(ProjectId), nameof(ProjectYear), nameof(ProjectMonth1), Name = "IDX_PROJECT_MONTHS_UQ", IsUnique = true)]
    public partial class ProjectMonth
    {
        [Key]
        [Column("PROJECT_MONTH_ID")]
        public int ProjectMonthId { get; set; }
        [Column("PROJECT_ID")]
        public int ProjectId { get; set; }
        [Column("PROJECT_YEAR")]
        public int ProjectYear { get; set; }
        [Column("PROJECT_MONTH")]
        public int ProjectMonth1 { get; set; }
        [Required]
        [Column("PROJECT_MONTH_STATUS")]
        [StringLength(1)]
        public string ProjectMonthStatus { get; set; }

        [ForeignKey(nameof(ProjectId))]
        [InverseProperty("ProjectMonths")]
        public virtual Project Project { get; set; }
    }
}
