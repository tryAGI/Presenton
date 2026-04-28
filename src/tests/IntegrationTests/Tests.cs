namespace Presenton.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PresentonClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PRESENTON_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PRESENTON_API_KEY environment variable is not found.");

        var client = new PresentonClient(apiKey);
        
        return client;
    }
}
