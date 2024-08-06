public class ResourceDto
{
	public Guid Id { get; init; }
	public string? Title { get; init; }
	public string? Description { get; init; }
	public string Url { get; set; } = string.Empty;
	public string? ImageUrl { get; init; }
	public DateTime CreatedAt { get; init; }
	public DateTime UpdatedAt { get; init; }

	public Guid? UserId { get; init; }
	public ResourceType Type { get; init; }
	public DifficultyLevel DifficultyLevel { get; init; }
	public DateTime DatePosted { get; init; }
}


public enum ResourceType
{
	Link,
	Document,
	Video,
}

public enum DifficultyLevel
{
	Beginner,
	Intermediate,
	Advanced
}