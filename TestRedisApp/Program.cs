using ServiceStack.Redis;
using TestRedisApp;

var host = "localhost:6379";

const int MAX_RETRIES = 15;
var count = 0;

while (count <= MAX_RETRIES)
{
    var clientTest = new ClientTest();

    ClientTest? clientFromRedis = null;

    try
    {
         RedisCacheSet(host, clientTest);
    }
    catch (Exception e)
    {
        Console.WriteLine($"ERROR MESSAGE {e.Message}");
        count++;
    }
}

static void RedisCacheSet(string host, ClientTest clientTest)
{
    ClientTest? clientFromRedis;
    using (var redis = new RedisClient(host))
    {
        redis.Set<ClientTest>(clientTest.Key.ToString(), clientTest);

        clientFromRedis = redis.Get<ClientTest>("legal");
    }

    Console.Write($"Data found:{clientFromRedis.Key.ToString()}, {clientFromRedis.Name}");
}