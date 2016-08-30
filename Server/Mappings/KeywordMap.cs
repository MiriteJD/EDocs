using FluentNHibernate.Mapping;
using Server.Model;

namespace Server.Mappings
{
    public class KeywordMap : BaseMap<Dossier>
    {
        public KeywordMap()
        {
            Table("Keywords");
            Map(x => x.Name).Length(50).Not.Nullable().Unique();
        }
    }
}


