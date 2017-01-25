using ResumeBlog.Model;
using System.Data.Entity.ModelConfiguration;

namespace ResumeBlog.DataLayer.EntityConfigurations
{
    internal class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {

            HasKey(c => c.UserId);

            Property(c => c.CompanyName)
                .IsRequired()
                .HasMaxLength(512);
            Property(c => c.WebSite)
                .IsRequired()
                .HasMaxLength(256);
            Property(c => c.CityTown)
                .IsRequired()
                .HasMaxLength(128);
            Property(c => c.RegionState)
                .IsRequired()
                .HasMaxLength(64);
            Property(c => c.Country)
                .IsRequired()
                .HasMaxLength(64);

            Property(c => c.OfferDetails)
                .IsRequired()
                .HasMaxLength(2048);
            


        }
    }
}