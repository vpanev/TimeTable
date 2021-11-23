using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TimeTable
{
    [Table("PROJECT")]
    [Index(nameof(ProjectName), Name = "IDX_PROJECT_UQ", IsUnique = true)]
    public partial class Project
    {
        public Project()
        {
            ProjectMonths = new HashSet<ProjectMonth>();
        }

        [Key]
        [Column("PROJECT_ID")]
        public int ProjectId { get; set; }
        [Required]
        [Column("PROJECT_NAME")]
        [StringLength(50)]
        public string ProjectName { get; set; }
        [Column("PROJECT_BEGIN", TypeName = "date")]
        public DateTime ProjectBegin { get; set; }
        [Column("PROJECT_END", TypeName = "date")]
        public DateTime ProjectEnd { get; set; }
        [Column("PROJECT_DESCRIPTION")]
        [StringLength(400)]
        public string ProjectDescription { get; set; }
        [Required]
        [Column("PROJECT_STATUS")]
        [StringLength(1)]
        public string ProjectStatus { get; set; }
        [Column("PROJECT_MAXHOURS")]
        public int? ProjectMaxhours { get; set; }

        [InverseProperty(nameof(ProjectMonth.Project))]
        public virtual ICollection<ProjectMonth> ProjectMonths { get; set; }
    }
}
