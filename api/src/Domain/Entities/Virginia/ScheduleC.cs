using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Domain.Entities.Virginia;

/// <summary>
///  Structure copied from the Virginia Department of Elections Campaign Finance Report CSV file.
/// "ReportId","CommitteeContactId","FirstName","MiddleName","LastOrCompanyName","Prefix","Suffix","AddressLine1","AddressLine2","City","StateCode","ZipCode","IsIndividual",
/// "TransactionDate","Amount","ScheduleCId","ReceiptType","ScheduleId","ReportUID"
/// </summary>
public class ScheduleC
{
    public int ReportId { get; set; }
    public int CommitteeContactId { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastOrCompanyName { get; set; }
    public string? Prefix { get; set; }
    public string? Suffix { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? ZipCode { get; set; }
    public bool IsIndividual { get; set; }
    public DateTime? TransactionDate { get; set; }
    public decimal? Amount { get; set; }
    public int ScheduleCId { get; set; }
    public string? ReceiptType { get; set; }
    public int ScheduleId { get; set; }
    public required Guid ReportUid { get; set; }
    public required Report Report { get; set; }

}
