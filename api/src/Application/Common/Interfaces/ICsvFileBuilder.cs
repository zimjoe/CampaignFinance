using Aeveco.CampaignFinance.Domain.Entities.Virginia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildReportFile(IEnumerable<Report> records);
}
