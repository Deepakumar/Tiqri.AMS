using System.Data.Entity.ModelConfiguration;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject.Mappers
{
    public class VictimMapper : EntityTypeConfiguration<Victim>
    {
        public VictimMapper()
        {
            #region Properties

            this.HasKey(t => t.ID);
            this.ToTable("Victim");
            this.Property(t => t.EmployeeID).HasColumnType("varchar").HasMaxLength(128).IsOptional();
            this.Property(t => t.FirstName).HasColumnName("FirstName").HasColumnType("varchar").HasMaxLength(40);
            this.Property(t => t.LastName).HasColumnName("LastName").HasColumnType("varchar").HasMaxLength(40);

            #endregion

            #region Relations

            this.HasRequired(t => t.Accident).WithMany(t => t.VictimList).HasForeignKey(t => t.AccidentID);

            #endregion
        }
    }
}