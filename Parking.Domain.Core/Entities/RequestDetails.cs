﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parking.Domain.Core.Entities
{
    public class RequestDetails
    {
        [Key]
        public int RequestDetailsId { get; set; }

        public int RegisterId { get; set; }
        [ForeignKey("RegisterId")]
        public Registers Registers { get; set; }

        [Display(Name = "Duration")]
        public int DurationId { get; set; }
        [ForeignKey("DurationId")]
        public RequestDurationType RequestDurationType { get; set; }

        [NotMapped]
        public ICollection<RequestDurationType> DurationList { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        [Display(Name = "Preference One")]
        public int PreferenceOneTowerId { get; set; }

        [Display(Name = "Preference Two")]
        public int PreferenceTwoTowerId { get; set; }

        [Display(Name = "Preference Three")]
        public int PreferenceThreeTowerId { get; set; }

        [NotMapped]
        public ICollection<Tower> TowerList { get; set; }
    }
}