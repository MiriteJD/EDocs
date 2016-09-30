using System;
using FluentNHibernate.Mapping;
using FluentNHibernate.Visitors;
using Server.Model;

namespace Server.Mappings
{
    public class KeywordMap : BaseMap<Keyword>
    {
        public KeywordMap()
        {
            try
            {
                Table("Keywords");
                Map(x => x.Name).Length(50).Not.Nullable().Unique();
                HasManyToMany(x => x.Documents).Table("DocumentToKeywordRelation")
                    .ParentKeyColumn("KeywordId")
                    .ChildKeyColumn("DocumentId")
                    .Inverse().Cascade.None();
                    

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}