using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Domain.Entities.Virginia;
/// <summary>
/// Structure copied from the Virginia Department of Elections Campaign Finance Report CSV file.
/// "ReportId","CommitteeCode","CommitteeName","CommitteeType","CandidateName","IsStateWide","IsGeneralAssembly",
/// "IsLocal","Party","FecNumber","ReportYear","FilingDate","StartDate","EndDate","AddressLine1","AddressLine2",
/// "AddressLine3","City","StateCode","ZipCode","FilingType","IsFinalReport","IsAmendment","AmendmentCount",
/// "SubmitterPhone","SubmitterEmail","ElectionCycle","ElectionCycleStartDate","ElectionCycleEndDate","OfficeSought",
/// "District","NoActivity","BalanceLastReportingPeriod","DateOfReferendum","SubmittedDate","AccountId","DueDate","IsXmlUpload","ReportUID"
/// </summary>
public class Report
{
    public int ReportId { get; set; }
    public string? CommitteeCode { get; set; }
    public string? CommitteeName { get; set; }
    public string? CommitteeType { get; set; }
    public string? CandidateName { get; set; }
    public bool IsStateWide { get; set; }
    public bool IsGeneralAssembly { get; set; }
    public bool IsLocal { get; set; }
    public string? Party { get; set; }
    public string? FecNumber { get; set; }
    public int? ReportYear { get; set; }
    public DateTime? FilingDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? ZipCode { get; set; }
    public string? FilingType { get; set; }
    public bool IsFinalReport { get; set; }
    public bool IsAmendment { get; set; }
    public int? AmendmentCount { get; set; }
    public string? SubmitterPhone { get; set; }
    public string? SubmitterEmail { get; set; }
    public string? ElectionCycle { get; set; }
    public DateTime? ElectionCycleStartDate { get; set; }
    public DateTime? ElectionCycleEndDate { get; set; }
    public string? OfficeSought { get; set; }
    public string? District { get; set; }
    public bool NoActivity { get; set; }
    public decimal? BalanceLastReportingPeriod { get; set; }
    public DateTime? DateOfReferendum { get; set; }
    public DateTime? SubmittedDate { get; set; }
    public string? AccountId { get; set; }
    public DateTime? DueDate { get; set; }
    public bool IsXmlUpload { get; set; }
    public Guid ReportUid { get; set; }

    public IEnumerable<ScheduleA>? ScheduleAs {get;set;}    
    public IEnumerable<ScheduleB>? ScheduleBs {get;set;}
    public IEnumerable<ScheduleC>? ScheduleCs { get;set;}
    public IEnumerable<ScheduleD>? ScheduleDs { get;set;}
    public IEnumerable<ScheduleE>? ScheduleEs {get;set;}
    public IEnumerable<ScheduleF>? ScheduleFs { get;set;}
    public IEnumerable<ScheduleG>? ScheduleGs { get;set;}
    public IEnumerable<ScheduleH>? ScheduleHs {get;set;}
    public IEnumerable<ScheduleI>? ScheduleIs {get;set;}
}