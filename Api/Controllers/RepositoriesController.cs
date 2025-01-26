using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class RepositoriesController : ControllerBase
{
    private readonly IHttpClientFactory _clientFactory;
    private const string GitHubApiUrl = "https://api.github.com";

    public RepositoriesController(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    [HttpGet]
    public async Task<IActionResult> GetOldestCSharpRepositories()
    {
        var client = _clientFactory.CreateClient();
        client.DefaultRequestHeaders.Add("User-Agent", "TakeNet-API");

        var response = await client.GetAsync($"{GitHubApiUrl}/orgs/takenet/repos?per_page=100");
        
        if (!response.IsSuccessStatusCode)
        {
            return StatusCode((int)response.StatusCode, "Failed to fetch repositories from GitHub");
        }

        var content = await response.Content.ReadAsStringAsync();
        var repositories = JsonSerializer.Deserialize<List<Repository>>(content);

        var oldestCSharpRepos = repositories
            .Where(r => r.Language == "C#")
            .OrderBy(r => r.CreatedAt)
            .Take(5)
            .ToList();

        return Ok(oldestCSharpRepos);
    }
}