using FluentNHibernate.Mapping;
using Server.Model;

namespace Server.Mappings
{
    public class BaseMap<T> : ClassMap<T> where T : BaseModel
    {
        public BaseMap()
        {
            Id(x => x.Id).GeneratedBy.Increment().Not.Nullable();
            Version(x => x.Version).Default(1);
        }
    }
}
