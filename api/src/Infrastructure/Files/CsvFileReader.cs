using Aeveco.CampaignFinance.Application.Common.Interfaces;
using Aeveco.CampaignFinance.Domain.Entities.Virginia;
using CsvHelper;
using Microsoft.Azure.Cosmos.Serialization.HybridRow.RecordIO;
using Microsoft.Azure.Cosmos.Serialization.HybridRow.Schemas;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Infrastructure.Files
{
    public class CsvFileReader: ICvsFileReader
    {
        /// <summary>
        /// Everything should automap
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="csvFile"></param>
        /// <returns></returns>
        public IEnumerable<T> GetReports<T>(TextReader csvFile) {
            
            using (var csv = new CsvReader(csvFile, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<T>();
            }
        }
    }
}
