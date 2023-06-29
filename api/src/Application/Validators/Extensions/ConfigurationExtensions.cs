using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Application.Validators
{
    public static class ConfigurationExtensions
    {
        public static string GetStringValue(this IConfigurationRoot? configuration, string valueName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException("configuration");
            }
            var configValue = configuration?[valueName];
            if (!string.IsNullOrWhiteSpace(configValue))
            {
                return configValue;
            }
            throw new ValidationException("KeyVaultUri not found in configuration", new List<ValidationFailure>() { new ValidationFailure(valueName, "This field is empty") });
        }
        /// <summary>
        /// Adds the named Key Vault to the configuration.
        /// THis will refresh the configuration every 30 seconds
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="KeyVaultName"></param>
        public static void AddAzureKeyVaultToConfiurationWithRefresh(this IConfigurationBuilder configuration, string KeyVaultName)
        {
            AddAzureKeyVaultToConfiurationWithRefresh(configuration, KeyVaultName, 30);
           
        }

        /// <summary>
        /// Adds the named Key Vault to the configuration.
        /// THis will refresh the configuration based on the refreshInSeconds parameter
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="KeyVaultName"></param>
        /// <param name="refreshInSeconds"></param>
        public static void AddAzureKeyVaultToConfiurationWithRefresh(this IConfigurationBuilder configuration, string KeyVaultName, int refreshInSeconds)
        {
            // get the keyvault from the configuration. On Azure this will be a setting, locally it will be in the local.settings.json file
            var builtConfig = configuration.Build();

            var keyVaultUri = builtConfig.GetStringValue(KeyVaultName);

            var secretClient = new SecretClient(new Uri(keyVaultUri), new DefaultAzureCredential());
            AzureKeyVaultConfigurationOptions options = new()
            {
                Manager = new KeyVaultSecretManager(),
                ReloadInterval = TimeSpan.FromSeconds(refreshInSeconds)
            };

            configuration.AddAzureKeyVault(secretClient, options);
        }
        /// <summary>
        /// Adds the named Key Vault to the configuration.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="KeyVaultName"></param>
        public static void AddAzureKeyVaultToConfiuration(this IConfigurationBuilder configuration, string KeyVaultName)
        {
            // get the keyvault from the configuration. On Azure this will be a setting, locally it will be in the local.settings.json file
            var builtConfig = configuration.Build();

            var keyVaultUri = builtConfig.GetStringValue(KeyVaultName);

            var secretClient = new SecretClient(new Uri(keyVaultUri), new DefaultAzureCredential());
            AzureKeyVaultConfigurationOptions options = new()
            {
                Manager = new KeyVaultSecretManager()
            };

            configuration.AddAzureKeyVault(secretClient, options);
        }
    }
}
