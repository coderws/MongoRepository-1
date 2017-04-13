﻿using Mh.Entries;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Mh.MongoRepository.TestInstructure
{
    public class OrderStringId:IEntity<string>
    {
        [BsonId]
        public string ID { get; set; }
        public string Name { get; set; }
    }
    public class OrderObjectId : IEntity<string>
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string ID { get; set; }
        public string Name { get; set; }
    }
    public class OrderIncId : IAutoInc
    {
        [BsonId]
        public long ID { get; set; }
        public string Name { get; set; }
    }
}
