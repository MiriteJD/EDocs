using System;
using FluentNHibernate.Mapping;
using Server.Model;

namespace Server.Mappings
{
    public class DocumentMap : BaseMap<Document>
    {
        public DocumentMap()
        {
            try
            {
                Table("Documents");
                Map(x => x.Title).Length(100).Not.Nullable();
                Map(x => x.Comment).Length(500).Nullable();
                Map(x => x.CreationDate).Not.Nullable();
                Map(x => x.Path).Length(260).Nullable().Unique();
                Map(x => x.Filename).Length(260).Not.Nullable();
                References(x => x.DossierList).Column("DossierId").LazyLoad().Cascade.None();
                HasManyToMany(x => x.Keywords).Table("DocumentToKeywordRelation")
                                               .ParentKeyColumn("DocumentId")
                                               .ChildKeyColumn("KeywordId")
                                               .Cascade.SaveUpdate();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
