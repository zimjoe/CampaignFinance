using System;
using Aeveco.CampaignFinance.Application.Common.Interfaces;
using Aeveco.CampaignFinance.Infrastructure.Persistance;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace WebFunction
{
    public class Loader
    {
        private readonly ILogger _logger;

        private readonly ICvsFileReader _cvsFileReader;
        private readonly VirginiaContext _context;
        private readonly IHttpClientFactory _httpClientFactory;

        public Loader(ILoggerFactory loggerFactory, ICvsFileReader csvFileReader, IHttpClientFactory httpClientFactory, VirginiaContext virginiaContext)
        {
            _logger = loggerFactory.CreateLogger<Loader>();
            _cvsFileReader = csvFileReader;
            _context = virginiaContext;
            _httpClientFactory = httpClientFactory;
        }

        [Function("Loader")]
        public void Run([TimerTrigger("0 */5 * * * *")] MyInfo myTimer)
        {
            _logger.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            _logger.LogInformation($"Next timer schedule at: {myTimer.ScheduleStatus.Next}");
        }
    }

    public class MyInfo
    {
        public MyScheduleStatus ScheduleStatus { get; set; }

        public bool IsPastDue { get; set; }
    }

    public class MyScheduleStatus
    {
        public DateTime Last { get; set; }

        public DateTime Next { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
