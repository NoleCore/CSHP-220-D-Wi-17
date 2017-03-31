using FlagsDB;

namespace FlagRepository
{
    public class DatabaseManager
    {
        private static readonly ScandicFlagsEntities entities;

        // Initialize and open the database connection
        static DatabaseManager()
        {
            entities = new ScandicFlagsEntities();
            entities.Database.Connection.Open();
        }

        // Provide an accessor to the database
        public static ScandicFlagsEntities Instance
        {
            get
            {
                return entities;
            }
        }
    }
}
