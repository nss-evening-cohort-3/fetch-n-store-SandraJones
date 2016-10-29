using System.Data.Entity;

namespace Fetch_and_Store.DAL
{
    public class RepoContext: DbContext

    {
        //virtual keyword is needed to use moq in testing
        public virtual DbSet<StoredURL> URLs { get; set; }

        public class StoredURL
        {
        }
    }
}