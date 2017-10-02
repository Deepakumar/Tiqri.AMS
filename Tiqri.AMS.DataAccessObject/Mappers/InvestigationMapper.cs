using System.Data.Entity.ModelConfiguration;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject.Mappers
{
    public class InvestigationMapper : EntityTypeConfiguration<Investigation>
    {
        public InvestigationMapper()
        {
            #region Properties

            this.HasKey(t => t.ID);
            this.ToTable("Investigation");

            this.Property(t => t.InvestigationOfficerID).HasColumnName("InvestigationOfficerID").HasColumnType("int");

            #endregion



            #region Relations

            this.HasRequired(t => t.Accident).WithOptional(t => t.Investigation);
            this.HasMany(t => t.InvestigationActionList).WithRequired(t => t.Investigation).HasForeignKey(t => t.InvestigationID);

            #endregion
        }
    }
}