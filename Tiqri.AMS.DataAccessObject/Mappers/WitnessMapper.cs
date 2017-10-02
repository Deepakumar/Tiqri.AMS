using System.Data.Entity.ModelConfiguration;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject.Mappers
{
    public class WitnessMapper : EntityTypeConfiguration<Witness>
    {
        public WitnessMapper()
        {
            #region Properties

            this.HasKey(t => t.ID);
            this.ToTable("Witness");

            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID").HasColumnType("int").IsOptional();
            this.Property(t => t.FirstName).HasColumnType("varchar").HasMaxLength(50);
            this.Property(t => t.LastName).HasColumnType("varchar").HasMaxLength(50);

            #endregion

            #region Relations

            this.HasRequired(t => t.Accident).WithMany(t => t.WitnessList).HasForeignKey(t => t.AccidentID);

            #endregion
        }
    }
}