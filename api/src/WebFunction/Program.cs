using Aeveco.CampaignFinance.Application.Common.Interfaces;
using Aeveco.CampaignFinance.Domain.Configuration;
using Aeveco.CampaignFinance.Infrastructure.Files;
using Aeveco.CampaignFinance.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using FluentValidation;
using Microsoft.Extensions.Options;
using Aeveco.CampaignFinance.Application.Validators;
using System.Configuration;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.Configuration;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureAppConfiguration(c =>
    {
#if DEBUG
        c.AddJsonFile("local.settings.json", optional: true, reloadOnChange: true);
#endif
        c.AddEnvironmentVariables();
    })
    .ConfigureServices(s =>
    {
        s.AddWithValidation<CosmoDBSettings, CosmoDBSettingsValidator>(CosmoDBSettings.ConfigName);
        
        s.AddHttpClient();
        s.AddDbContext<VirginiaContext>();
        s.AddTransient<ICvsFileReader, CsvFileReader>();
    })
    .Build();

host.Run();
