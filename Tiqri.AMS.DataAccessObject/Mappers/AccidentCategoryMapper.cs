using System.Data.Entity.ModelConfiguration;
using Tiqri.AMS.Model;

namespace Tiqri.AMS.DataAccessObject.Mappers
{
    public class AccidentCategoryMapper : EntityTypeConfiguration<AccidentCategory>
    {
        public AccidentCategoryMapper()
        {
            #region Properties

                this.HasKey(t => t.ID);
                this.ToTable("AccidentCategory");
                this.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar").HasMaxLength(40);

            #endregion

            #region Relations

            this.HasMany(t => t.AccidentList).WithRequired(t => t.AccidentCategory).HasForeignKey(t=>t.ActionCategoryID);

            #endregion

        }
    }
}