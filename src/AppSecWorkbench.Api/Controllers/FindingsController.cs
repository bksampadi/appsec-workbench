using AppSecWorkbench.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppSecWorkbench.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FindingsController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<SecurityFinding>> GetFindings()
    {
        var findings = new[]
        {
            new SecurityFinding
            {
                Title = "Possible cross-tenant object access",
                Category = "Borken Access Control",
                Severity = FindingSeverity.High
            }
        };

        return Ok(findings);
    }
}