using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Domain.Entities;
/// <summary>
/// This is for creating a top level organization or a committee.
/// May not be needed, but I had an idea to speed up org searches
/// </summary>
public class Organization
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? StreetAddress { get; set; }
    public string? PhoneNumber { get; set; }
    public string? EmailAddress { get; set; }
    public string? Website { get; set; }
    public string? Description { get; set; }
}
