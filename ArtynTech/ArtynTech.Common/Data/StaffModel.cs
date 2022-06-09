using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtynTech.Common.Data
{
    public class StaffModel
    {
        [Required]
        [Key]
        public int id { get; set; }
        public int idCompany { get; set; }
        public int idStaffRole { get; set; }
        public string? StaffTitle { get; set; }
        public string? StaffName { get; set; }
        public string? StaffFamily { get; set; }
        public string? StaffBirthdate { get; set; }
        public DateTime StaffHiringDate { get; set; }
        public string? StaffMajor { get; set; }
        public string? StaffWords { get; set; }
        public string? StaffDetail { get; set; }
        public string? StaffPic { get; set; }
        public string? StaffJobPosition { get; set; }
        public DateTime StaffStartDate { get; set; }
        public DateTime StaffEndDate { get; set; }
        [Required]
        public string StaffUsername { get; set; }
        [Required]
        public string StaffPassword { get; set; }
        [Required]
        public string StaffEmail { get; set; }
        public string? SatffTel { get; set; }
        public string? StaffMobile { get; set; }
        public bool allow { get; set; }
    }
    public class StaffAccessLevel
    {
        [Required]
        [Key]
        public int id { get; set; }
        public int idAccessService { get; set; }
        [Required]
        public int idStaff { get; set; }
        [Required]
        public string title { get; set; }
        public string? detail { get; set; }
        public bool allow { get; set; }
    }
    public class StaffCertificates
    {
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public int idStaff { get; set; }
        [Required]
        public string title { get; set; }
        public string? detail { get; set; }
        public bool allow { get; set; }
    }
    public class StaffHonors
    {
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public int idStaff { get; set; }
        [Required]
        public string title { get; set; }
        public string? detail { get; set; }
        public DateTime StaffHonorDate { get; set; }
        public bool allow { get; set; }
    }
    public class StaffPanel
    {
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public int idStaff { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ViewDate { get; set; }
        public string? title { get; set; }
        public string? detail { get; set; }
        public int priority { get; set; }
        public bool allow { get; set; }
    }
    public class StaffPanelAttachments
    {
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public int idStaffPanel { get; set; }
        public string? fileName { get; set; }
        public bool allow { get; set; }
    }
    public class StaffPortfolio
    {
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public int idStaff { get; set; }
        public string? title { get; set; }
        public string? detail { get; set; }
        public string? picAddr { get; set; }
        public DateTime achievementDate { get; set; }
        public bool allow { get; set; }
    }
    public class StaffRole
    {
        [Required]
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public string comments { get; set; }
        public DateTime createDate { get; set; }
        public bool allow { get; set; }
    }
    public class StaffRoleTree
    {
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public int idStaffRole { get; set; }
        [Required]
        public int idNextStaffRole { get; set; }
        public bool allow { get; set; }
    }
    public class StaffSocials
    {
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public int idStaff { get; set; }
        [Required]
        public int idSocial { get; set; }
        public string? socialLink { get; set; }
        public bool allow { get; set; }
    }
    public class StaffSubstitute
    {
        [Required]
        [Key]
        public int id { get; set; }
        [Required]
        public int idStaffRole { get; set; }
        [Required]
        public int idNextSubRole { get; set; }
        public DateTime startFrom { get; set; }
        public DateTime endTo { get; set; }
        public bool allow { get; set; }
    }
}
