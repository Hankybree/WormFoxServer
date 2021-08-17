using System;
namespace WormFoxAPI.Database.DatabaseSettings
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string TowerCollection { get; set; }
        string UserCollection { get; set; }
    }
}
