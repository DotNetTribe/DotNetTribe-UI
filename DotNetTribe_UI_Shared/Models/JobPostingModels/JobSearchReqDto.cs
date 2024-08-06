public class JobSearchReqDto
{
	public string? query { get; set; }
	public int page { get; set; } = 1;
	public int num_pages { get; set; } = 20;
	public date_posted? date_Posted { get; set; }
	public bool? remote_jobs_only { get; set; }
	public employment_types? employment_Types { get; set; }
	public job_requirements? job_requirements { get; set; }
	public string? job_titles { get; set; }
	public string? company_types { get; set; }
	public string? employer { get; set; }
	public bool? actively_hiring { get; set; }
	public int? radius { get; set; }
	public string? country { get; set; }
	public string? language { get; set; }
	public string? exclude_job_publishers { get; set; }
}

public enum date_posted
{
	All = 1,
	Today,
	Threedays,
	Week,
	Month
}

public enum employment_types
{
	FullTime = 1,
	Contractor,
	PartTime,
	Intern
}
public enum job_requirements
{
	under_3_years_experience = 1,
	more_than_3_years_experience,
	no_experience,
	no_degree
}