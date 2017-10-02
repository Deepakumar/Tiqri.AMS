using System.Data.Entity.ModelConfiguration;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject.Mappers
{
    public class InvestigationActionMapper : EntityTypeConfiguration<InvestigationAction>
    {
        public InvestigationActionMapper()
        {
            #region Properties

            this.HasKey(t => t.ID);
            this.ToTable("InvestigationAction");

            this.Property(t => t.Action).HasColumnName("Action").HasColumnType("varchar").HasMaxLength(1000);

            #endregion


            #region Relations

            this.HasRequired(t => t.Investigation).WithMany(t => t.InvestigationActionList).HasForeignKey(t => t.InvestigationID);

            #endregion
        }
    }
}