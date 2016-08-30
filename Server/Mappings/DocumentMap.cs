using FluentNHibernate.Mapping;
using Server.Model;

namespace Server.Mappings
{
    public class DocumentMap : BaseMap<Document>
    {
        public DocumentMap()
        {
            Table("Documents");
            Map(x => x.Title).Length(100).Not.Nullable();
            Map(x => x.Comment).Length(500).Nullable();
            Map(x => x.CreationDate).Not.Nullable();
            Map(x => x.Path).Length(260).Nullable().Unique();
            Map(x => x.Filename).Length(260).Not.Nullable();
            Map(x => x.DossierId).Not.Nullable();

            //Bsp Tasklistaufgabe
            //References(x => x.TaskList).Column("TasklistID").LazyLoad().Cascade.None();
            //HasManyToMany(x => x.Categories).Table("TaskToCategoryRelations")
            //                                .ParentKeyColumn("TaskID")
            //                                .ChildKeyColumn("CategoryID")
            //                                .Cascade.SaveUpdate();
        }

    }
}
