
namespace DotNetTribe_UI_Shared.Models.JobPostingModels
{
    public class JobSearchRespModel
    {
        public string? JobId { get; set; }
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public List<string>? JobBenefits { get; set; }
        public string? JobCity { get; set; }
        public string? JobState { get; set; }
        public string? JobCountry { get; set; }
        public DateTime? JobOfferExpirationDatetimeUtc { get; set; }
        public int? JobOfferExpirationTimestamp { get; set; }
        public object? JobMinSalary { get; set; }
        public object? JobMaxSalary { get; set; }
        public object? JobSalaryCurrency { get; set; }
        public string? JobApplyLink { get; set; }
        public bool JobIsRemote { get; set; }
        public string? JobEmploymentType { get; set; }
        public double? JobPostedAtTimestamp { get; set; }
        public DateTime? JobPostedAtDateTime { get; set; }
        public string? EmployerName { get; set; }
        public string? EmployerCompanyType { get; set; }
        public string? EmployerLogo { get; set; }
        public string? EmployerWebsite { get; set; }
    }
}