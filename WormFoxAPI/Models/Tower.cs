using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WormFoxAPI.Models
{
    public class Tower
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Sprite { get; set; }
        public double Damage { get; set; }
        public double Range { get; set; }
        public double Aoe { get; set; }
        public int AttackType { get; set; }
    }

    public enum AttackType
    {
        Normal = 0,
        Slow = 1,
        Piercing = 2,
        Magic = 3
    }
}
