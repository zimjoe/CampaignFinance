using Aeveco.CampaignFinance.Application.Common.Interfaces;
using Aeveco.CampaignFinance.Domain.Configuration;
using Aeveco.CampaignFinance.Infrastructure.Files;
using Aeveco.CampaignFinance.Infrastructure.Persistance;
using Azure.Extensions.AspNetCore.Configuration.Secrets;
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
using Azure.Security.KeyVault.Secrets;
using Azure.Identity;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureAppConfiguration(c =>
    {
        // get the keyvault from the configuration. On Azure this will be a setting, locally it will be in the local.settings.json file
#if DEBUG
        c.AddJsonFile("local.settings.json", optional: true, reloadOnChange: true);
#endif
        // this refreshses the keyvault every 60 seconds and updates the configuration
        c.AddAzureKeyVaultToConfiurationWithRefresh("KeyVaultUri", 60);
        
        c.AddEnvironmentVariables();
    })
    .ConfigureServices(s =>
    {
        s.AddConfigurationWithValidation<CosmoDBSettings, CosmoDBSettingsValidator>(CosmoDBSettings.ConfigName);
        s.AddHttpClient();
        s.AddDbContext<VirginiaContext>();
        s.AddTransient<ICvsFileReader, CsvFileReader>();
    })
    .Build();

host.Run();
