using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAndEarn.Services.IServices
{
    public interface ICacheService
    {
        public string CheckValueInCache(int key);
        public bool PutValueInCache(int key, object data);
    }

}

