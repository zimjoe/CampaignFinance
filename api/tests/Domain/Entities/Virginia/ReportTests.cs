using Aeveco.CampaignFinance.Domain.Entities.Virginia;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeveco.CampaignFinance.Domain.Tests.Entities.Virginia
{
    public class ReportTests
    {
        [Fact]
        public void ReportId_IsRequired()
        {
            try
            {
                // Arrange
                var report = new Report();

                // Act
                var context = new ValidationContext(report);
                Validator.ValidateObject(report, context, validateAllProperties: true);
            }
            catch (ValidationException exception)
            {
                // Assert
                Assert.Equal("The ReportId field is required.", exception.Message);
            }
        }

        [Fact]
        public void ReportUid_IsRequired()
        {
            try
            {
                // Arrange
                var report = new Report();

                // Act
                var context = new ValidationContext(report);
                Validator.ValidateObject(report, context, validateAllProperties: true);
            }
            catch (ValidationException exception)
            {
                // Assert
                Assert.Equal("The ReportUid field is required.", exception.Message);
            }
        }
    }
}
