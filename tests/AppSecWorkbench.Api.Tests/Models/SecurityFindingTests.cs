using AppSecWorkbench.Api.Models;

namespace AppSecWorkbench.Api.Tests.Models;

public class SecurityFindingTests
{
    [Fact]
    public void Newfinding_HasExpectedDefaults()
    {
        var finding = new SecurityFinding
        {
            Title = "Cross-tenant object access",
            Category = "Broken Access Control",
            Severity = FindingSeverity.High
        };

        Assert.NotEqual(Guid.Empty, finding.Id);
        Assert.Equal(FindingStatus.NeedsInvestigation, finding.Status);
        Assert.Equal(FindingSeverity.High, finding.Severity);
        Assert.True(finding.CreatedAtUtc <= DateTime.UtcNow);
    }
}