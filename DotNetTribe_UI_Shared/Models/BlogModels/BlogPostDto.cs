public record BlogPostDto
{
	public Guid Id { get; init; }
	public string? Title { get; init; }
	public string? Description { get; init; }
	public string? Content { get; init; }
	public Category Category { get; init; }
	public string? PostImage { get; init; }
	public Guid? AuthorId { get; init; }
	public string? AuthorName { get; init; }
	public DateTime? DateCreated { get; init; }
	public DateTime? DateUpdated { get; init; }
	public List<CommentDto>? Comments { get; init; }
	public List<TagDto>? Tags { get; init; }

}

public record CommentDto
{
	public Guid Id { get; init; }
	public string? Content { get; init; }
	public Guid? BlogPostId { get; init; }
	public Guid AuthorId { get; init; }

}

public record TagDto(Guid Id, string Name);

public enum Category
{
	Technology = 1,
	Programming,
	SoftwareDevelopment,
	MicrosoftDotNet,
	WebDevelopment,
	MobileDevelopment,
	Database,
	Design,
	Testing,
	ProjectManagement,
	Architecture,
	CloudComputing,
	Security,
	Career,
	Community
}
