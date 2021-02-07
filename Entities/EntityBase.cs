using Newtonsoft.Json;

namespace EnvNetTp1.Entities
{
    public class EntityBase
    {
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects
                });
        }
    }
}