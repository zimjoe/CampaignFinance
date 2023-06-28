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
#if DEBUG
        c.AddJsonFile("local.settings.json", optional: true, reloadOnChange: true);
#endif
        // get the keyvault from the configuration. On Azure this will be a setting, locally it will be in the local.settings.json file
        var builtConfig = c.Build();
        var keyVaultUri = builtConfig?["KeyVaultUri"];
        if (!string.IsNullOrWhiteSpace(keyVaultUri))
        {
            var secretClient = new SecretClient(new Uri(keyVaultUri), new DefaultAzureCredential());
            AzureKeyVaultConfigurationOptions options = new(){
                Manager = new KeyVaultSecretManager(),
                ReloadInterval = TimeSpan.FromSeconds(30)
            };
            c.AddAzureKeyVault(secretClient, options);
        }
        c.AddEnvironmentVariables();
    })
    .ConfigureServices(s =>
    {
        s.AddConfigurationWithValidation<CosmoDBSettings, CosmoDBSettingsValidator>(CosmoDBSettings.ConfigName);
        //s.AddSingleton<IConfiguration>(Configuration);
        s.AddHttpClient();
        s.AddDbContext<VirginiaContext>();
        s.AddTransient<ICvsFileReader, CsvFileReader>();
    })
    .Build();

host.Run();
