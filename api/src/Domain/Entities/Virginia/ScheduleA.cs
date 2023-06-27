using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Domain.Entities.Virginia;

/// <summary>
/// Structure copied from the Virginia Department of Elections Campaign Finance Report CSV file.
/// "ReportId","CommitteeContactId","FirstName","MiddleName","LastOrCompanyName","Prefix","Suffix","NameOfEmployer","OccupationOrTypeOfBusiness","PrimaryCityAndStateOfEmploymentOrBusiness",
/// "AddressLine1","AddressLine2","City","StateCode","ZipCode","IsIndividual","TransactionDate","Amount","TotalToDate","ScheduleAId","ScheduleId","ReportUID"
/// </summary>
public class ScheduleA
{
    public int ScheduleAId { get; set; }
    public int ReportId { get; set; }
    public int CommitteeContactId { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastOrCompanyName { get; set; }
    public string? Prefix { get; set; }
    public string? Suffix { get; set; }
    public string? NameOfEmployer { get; set; }
    public string? OccupationOrTypeOfBusiness { get; set; }
    public string? PrimaryCityAndStateOfEmploymentOrBusiness { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? ZipCode { get; set; }
    public bool IsIndividual { get; set; }
    public DateTime? TransactionDate { get; set; }
    public decimal? Amount { get; set; }
    public decimal? TotalToDate { get; set; }

    public required Guid ReportUid { get; set; }
    public required Report Report { get; set; }

}
