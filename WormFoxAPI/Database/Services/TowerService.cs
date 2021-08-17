using System;
using System.Collections.Generic;
using MongoDB.Driver;
using WormFoxAPI.Database.DatabaseSettings;
using WormFoxAPI.Models;

namespace WormFoxAPI.Database.Services
{
    public class TowerService
    {
        private readonly IMongoCollection<Tower> _towers;

        public TowerService(IDatabaseSettings settings)
        {
            MongoClient client = new MongoClient(settings.ConnectionString);
            IMongoDatabase database = client.GetDatabase(settings.DatabaseName);

            _towers = database.GetCollection<Tower>(settings.TowerCollection);
        }

        public IEnumerable<Tower> GetAll()
        {
            return _towers.Find(tower => true).ToEnumerable();
        }

        public Tower GetOne(string id)
        {
            return _towers.Find(tower => tower.Id == id).FirstOrDefault();
        }

        public void Insert(Tower tower)
        {
            _towers.InsertOne(tower);
        }

        public void Update(string id, Tower newTower)
        {
            _towers.ReplaceOne(tower => tower.Id == id, newTower);
        }

        public void Delete(string id)
        {
            _towers.DeleteOne(tower => tower.Id == id);
        }
    }
}
