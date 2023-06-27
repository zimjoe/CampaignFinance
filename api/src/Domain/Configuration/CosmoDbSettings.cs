using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Domain.Configuration
{
    public class CosmoDBSettings
    {
        public const string ConfigName = "CosmoDB";
        public required string AccountEndPoint { get; set; }
        public required string AccountKey { get; set; }
        public required string DatabaseName { get; set; }
        public string? ContainerName { get; set; }
    }
}
