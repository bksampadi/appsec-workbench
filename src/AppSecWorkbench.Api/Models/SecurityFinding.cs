namespace AppSecWorkbench.Api.Models;

public class SecurityFinding
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public required string Title { get; init; }

    public required string Category { get; init; }

    public required string Severity { get; init; }

    public string Status { get; init; } = "NeedsInvestigation";

    public DateTime CreatedAtUtc { get; init; }  = DateTime.UtcNow;
}
