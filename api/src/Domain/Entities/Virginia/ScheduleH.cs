using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Domain.Entities.Virginia;

/// <summary>
///  Structure copied from the Virginia Department of Elections Campaign Finance Report CSV file.
/// "ScheduleHId","ReportId","BeginningBalance","ContributionsReceived","ScheduleCTotal","LoansReceivedTotal","ContributionsAndReceiptsReceived","TotalExpendableFunds",
/// "TotalInKindAndExpenditures","LoansPaidTotal","ScheduleITotal","TotalPaymentsMade","ExpendableFundsBalance","TotalUnPaidDebts","BalanceAtStartOfElectionCycle","PreviousReceipts",
/// "CurrentReceipts","TotalReceiptsThisElectionCycle","TotalFundsAvailable","PreviousDisbursements","CurrentDisbursements","TotalDisbursements","EndingBalance","ScheduleId","ReportUID"
/// </summary>
public class ScheduleH
{
    public int ScheduleHId { get; set; }
    public int ReportId { get; set; }
    public decimal BeginningBalance { get; set; }
    public decimal ContributionsReceived { get; set; }
    public decimal ScheduleCTotal { get; set; }
    public decimal LoansReceivedTotal { get; set; }
    public decimal ContributionsAndReceiptsReceived { get; set; }
    public decimal TotalExpendableFunds { get; set; }
    public decimal TotalInKindAndExpenditures { get; set; }
    public decimal LoansPaidTotal { get; set; }
    public decimal ScheduleITotal { get; set; }
    public decimal TotalPaymentsMade { get; set; }
    public decimal ExpendableFundsBalance { get; set; }
    public decimal TotalUnPaidDebts { get; set; }
    public decimal BalanceAtStartOfElectionCycle { get; set; }
    public decimal PreviousReceipts { get; set; }
    public decimal CurrentReceipts { get; set; }
    public decimal TotalReceiptsThisElectionCycle { get; set; }
    public decimal TotalFundsAvailable { get; set; }
    public decimal PreviousDisbursements { get; set; }
    public decimal CurrentDisbursements { get; set; }
    public decimal TotalDisbursements { get; set; }
    public decimal EndingBalance { get; set; }
    public int ScheduleId { get; set; }
    public required Guid ReportUid { get; set; }
    public required Report Report { get; set; }
}
