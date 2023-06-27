using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Domain.Entities.Virginia;

/// <summary>
///  Structure copied from the Virginia Department of Elections Campaign Finance Report CSV file.
/// "ScheduleGId","ReportId","ScheduleACount","ScheduleATotal","ScheduleBCount","ScheduleBTotal","UnItemizedCount","UnItemizedTotal","UnItemizedInKindCount","UnItemizedInKindTotal",
/// "AllContributionsCount","AllContributionsTotal","ScheduleCTotal","ScheduleBTotalAgain","UnItemizedInKindTotalAgain","ScheduleDTotal","TotalInKindAndExpenditures",
/// "BeginningLoanBalance","LoansReceivedTotal","LoansReceivedAndExistingTotal","LoansPaidTotal","NewLoanBalance","ScheduleId","ReportUID"
/// </summary>
public class ScheduleG
{
    public int ScheduleGId { get; set; }
    public int ReportId { get; set; }
    public int ScheduleACount { get; set; }
    public decimal ScheduleATotal { get; set; }
    public int ScheduleBCount { get; set; }
    public decimal ScheduleBTotal { get; set; }
    public int UnItemizedCount { get; set; }
    public decimal UnItemizedTotal { get; set; }
    public int UnItemizedInKindCount { get; set; }
    public decimal UnItemizedInKindTotal { get; set; }
    public int AllContributionsCount { get; set; }
    public decimal AllContributionsTotal { get; set; }
    public decimal ScheduleCTotal { get; set; }
    public decimal ScheduleBTotalAgain { get; set; }
    public decimal UnItemizedInKindTotalAgain { get; set; }
    public decimal ScheduleDTotal { get; set; }
    public decimal TotalInKindAndExpenditures { get; set; }
    public decimal BeginningLoanBalance { get; set; }
    public decimal LoansReceivedTotal { get; set; }
    public decimal LoansReceivedAndExistingTotal { get; set; }
    public decimal LoansPaidTotal { get; set; }
    public decimal NewLoanBalance { get; set; }
    public int ScheduleId { get; set; }
    public required Guid ReportUid { get; set; }
    public required Report Report { get; set; }
}
