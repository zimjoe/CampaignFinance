using Aeveco.CampaignFinance.Domain.Entities.Virginia;
using Aeveco.CampaignFinance.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Infrastructure.Files;
public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildReportFile(IEnumerable<Report> records) { 
        throw new NotImplementedException();
    }
}
