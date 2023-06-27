using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Domain.Entities.Virginia;

/// <summary>
///  Structure copied from the Virginia Department of Elections Campaign Finance Report CSV file.
/// "ReportId","TransactionDate","Amount","ScheduleEId","LenderCommitteeContactId","LenderFirstName","LenderMiddleName","LenderLastOrCompanyName","LenderPrefix","LenderSuffix",
/// "LenderAddressLine1","LenderAddressLine2","LenderCity","LenderState","LenderZipCode","LenderIsIndividual","CoBorrowerCommitteeContactId","CoBorrowerFirstName","CoBorrowerMiddleName",
/// "CoBorrowerLastOrCompanyName","CoBorrowerPrefix","CoBorrowerSuffix","CoBorrowerAddressLine1","CoBorrowerAddressLine2","CoBorrowerCity","CoBorrowerState","CoBorrowerZipCode",
/// "CoBorrowerIsIndividual","TransactionType","LoanBalance","ScheduleId","ReportUID"
/// </summary>
public class ScheduleE
{
    public int ReportId { get; set; }
    public DateTime? TransactionDate { get; set; }
    public decimal? Amount { get; set; }
    public int ScheduleEId { get; set; }
    public int LenderCommitteeContactId { get; set; }
    public string? LenderFirstName { get; set; }
    public string? LenderMiddleName { get; set; }
    public string? LenderLastOrCompanyName { get; set; }
    public string? LenderPrefix { get; set; }
    public string? LenderSuffix { get; set; }
    public string? LenderAddressLine1 { get; set; }
    public string? LenderAddressLine2 { get; set; }
    public string? LenderCity { get; set; }
    public string? LenderState { get; set; }
    public string? LenderZipCode { get; set; }
    public bool LenderIsIndividual { get; set; }
    public int CoBorrowerCommitteeContactId { get; set; }
    public string? CoBorrowerFirstName { get; set; }
    public string? CoBorrowerMiddleName { get; set; }
    public string? CoBorrowerLastOrCompanyName { get; set; }
    public string? CoBorrowerPrefix { get; set; }
    public string? CoBorrowerSuffix { get; set; }
    public string? CoBorrowerAddressLine1 { get; set; }
    public string? CoBorrowerAddressLine2 { get; set; }
    public string? CoBorrowerCity { get; set; }
    public string? CoBorrowerState { get; set; }
    public string? CoBorrowerZipCode { get; set; }
    public bool CoBorrowerIsIndividual { get; set; }
    public string? TransactionType { get; set; }
    public decimal? LoanBalance { get; set; }
    public int ScheduleId { get; set; }
    public required Guid ReportUid { get; set; }
    public required Report Report { get; set; }
}
