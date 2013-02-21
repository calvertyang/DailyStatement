﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DailyStatement.Models
{
    public class DailyInfo
    {
        [Key]
        public int DailyInfoId { get; set; }

        [Required]
        public WorkCategory Category { get; set; }

        [ConcurrencyCheck, Required]
        public string ProjectNo { get; set; } // 案號如果未成案就給 N

        [Required, MaxLength(100)]
        public string Customer { get; set; }
   
        public DateTime CreateDate { get; set; }

        [Required]
        public Employee Employee { get; set; }

        public int WorkingHours { get; set; }

    }
}