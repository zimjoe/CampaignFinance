using Aeveco.CampaignFinance.Domain.Configuration;
using Aeveco.CampaignFinance.Domain.Entities.Virginia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Infrastructure.Persistance;

public class VirginiaContext : DbContext
{
    private readonly CosmoDBSettings _cosmoDBSettings;
    public VirginiaContext(IOptions<CosmoDBSettings> cosmoDBSettings) 
    {
        _cosmoDBSettings = cosmoDBSettings.Value;
    }
    

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseCosmos(
            _cosmoDBSettings.AccountEndPoint,
            _cosmoDBSettings.AccountKey,
            databaseName: _cosmoDBSettings.DatabaseName);
    }

    public DbSet<Report> Reports { get; set; }
    public DbSet<ScheduleA> ScheduleAs { get; set; }
    public DbSet<ScheduleB> ScheduleBs { get; set; }
    public DbSet<ScheduleC> ScheduleCs { get; set; }
    public DbSet<ScheduleD> ScheduleDs { get; set; }
    public DbSet<ScheduleE> ScheduleEs { get; set; }
    public DbSet<ScheduleF> ScheduleFs { get; set; }
    public DbSet<ScheduleG> ScheduleGs { get; set; }
    public DbSet<ScheduleH> ScheduleHs { get; set; }
    public DbSet<ScheduleI> ScheduleIs { get; set; }
}
