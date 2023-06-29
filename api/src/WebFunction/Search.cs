using System.Net;
using Aeveco.CampaignFinance.Domain.Configuration;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WebFunction;

public class Search
{
    private readonly ILogger _logger;
    private readonly CosmoDBSettings _cosmoDBSettings;

    public Search(ILoggerFactory loggerFactory, IOptionsSnapshot<CosmoDBSettings> cosmoDBSettings)
    {
        _logger = loggerFactory.CreateLogger<Search>();
        _cosmoDBSettings = cosmoDBSettings.Value;
    }

    [Function("Search")]
    public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
        response.WriteString(_cosmoDBSettings.ChangingValue??"No Value");
        response.WriteString(" - ");
        response.WriteString(DateTime.Now.ToLongTimeString());
        return response;
    }
}
