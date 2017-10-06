using System.Data.Entity.ModelConfiguration;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject.Mappers
{
    public class AccidentMapper : EntityTypeConfiguration<Accident>
    {
        public AccidentMapper()
        {
            #region Properties

            this.HasKey(t => t.ID);
            this.ToTable("Accident");

            this.Property(t => t.ReferenceNo).HasColumnName("ReferenceNo").HasColumnType("varchar").HasMaxLength(8);
            this.Property(t => t.ActionCategoryID).HasColumnType("int").IsRequired();
            this.Property(t => t.ReporterID).HasColumnType("varchar").HasMaxLength(128).IsRequired();
            this.Property(t => t.Status).HasColumnType("int").IsRequired();
            this.Property(t => t.InvestigationID).HasColumnType("int").IsOptional();
            this.Property(t => t.History).HasColumnType("varchar").HasMaxLength(1000);
            this.Property(t => t.AccidentDate).HasColumnType("datetime2").IsRequired();
            this.Property(t => t.TypeOfLocation).HasColumnType("int").IsRequired();

            #endregion

            #region Relations

            this.HasRequired(t => t.AccidentCategory).WithMany(t => t.AccidentList);
            this.HasOptional(t => t.Investigation).WithRequired(t => t.Accident);
            this.HasMany(t => t.WitnessList).WithRequired(t => t.Accident).HasForeignKey(t => t.AccidentID);
            this.HasMany(t => t.VictimList).WithRequired(t => t.Accident).HasForeignKey(t => t.AccidentID);

            #endregion

        }
    }
}