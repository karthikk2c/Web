using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RamsWebApplication.Models
{
    public class Rams
    {
        public int Id { set; get; }
        public string Version { set; get; }

        [Display(Name = "Survey Date")]
        public DateTime DAteOfSurvey { set; get; }

        [Display(Name="Lead Surveyor")]
        public string LeadSurveyor{ set; get; }
        public string TeamSurveyors { set; get; }
        public string JobNumber { set; get; }
        public string ClintContactFullName { set; get; }
        public string ClintCompanyName { set; get; }
        public int ClintContactNumbar { set; get; }

        [Display(Name="Site Name")]
        public string SiteName { set; get; }
        public string SiteAddressLine1 { set; get; }
        public string SiteAddressLine2 { set; get; }
        public string SiteCity { set; get; }
        public string SitePostCode { set; get; }
        public string Hospital { set; get; }

        [Display(Name="Survey Type")]
        public string SurveyType { set; get; }
        public string Risk { set; get; }
        public string Status { set; get; }

        [Display(Name="Last Edited Date")]
        public DateTime LastEditedDateandTime { set; get; }

        
        public DateTime CreatedDateandTime { set; get; }
        public string CreatedBy { set; get; }
    }
}