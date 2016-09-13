using System;
using FluentNHibernate.Mapping;
using Server.Model;

namespace Server.Mappings
{
    public class BaseMap<T> : ClassMap<T> where T : BaseModel
    {
        public BaseMap()
        {
            try
            {
                Id(x => x.Id).GeneratedBy.Increment().Not.Nullable().Unique();
                Version(x => x.Version).Default(1).Not.Nullable();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
