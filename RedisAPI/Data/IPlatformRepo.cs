namespace RedisAPI.Models
{
    public interface IPlatformRepo
    {
        void CreatePlatform(Platform plat);
        Platform GetPlatformById(string id);
        IEnumerable<Platform> GetAllPlatforms();
    }
}