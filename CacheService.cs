using LearnAndEarn.DataAccess.Context;
using LearnAndEarn.Model.Models;
using LearnAndEarn.Services.IServices;
using Newtonsoft.Json;
using StackExchange.Redis;
using System.Collections.Generic;
using System.Threading.Tasks;


public class CacheService : ICacheService
{
    private IDatabase db;

    public CacheService(IConnectionMultiplexer cache)
    {
        db = cache.GetDatabase();
    }

    public string CheckValueInCache(int key)
    {
        var cacheValues = db.StringGet("KeyId" + key);
        if (cacheValues.HasValue == true)
        {
            return cacheValues;
        }
        return null;
    }

    public bool PutValueInCache(int key, object data)
    {
        var result = db.StringSet("quizSetId_" + key, (JsonConvert.SerializeObject(data)));
        return result;
    }

}
