using System;
namespace WormFoxAPI.Database.DatabaseSettings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string TowerCollection { get; set; }
        public string UserCollection { get; set; }
    }
}
