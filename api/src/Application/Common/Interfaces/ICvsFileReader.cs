using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Application.Common.Interfaces
{
    public interface ICvsFileReader
    {
        IEnumerable<T> GetReports<T>(TextReader csvFile);
    }
}
