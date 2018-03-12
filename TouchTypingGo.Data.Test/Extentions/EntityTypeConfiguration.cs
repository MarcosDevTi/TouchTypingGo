using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TouchTypingGo.Data.Test.Extentions
{
    public abstract class EntityTypeConfiguration<TEntity> where TEntity : class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }
}
