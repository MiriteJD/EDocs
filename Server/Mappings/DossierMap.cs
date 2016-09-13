using System;
using FluentNHibernate.Mapping;
using Server.Model;

namespace Server.Mappings
{
    public class DossierMap : BaseMap<Dossier>
    {
        public DossierMap()
        {
            try
            {
                Table("Dossiers");
                Map(x => x.Nr).Length(100).Not.Nullable().Unique();
                Map(x => x.Counter).Not.Nullable();
                Map(x => x.Year).Not.Nullable();
                Map(x => x.Name).Length(200).Not.Nullable();
                Map(x => x.Comment).Length(500).Nullable();
                Map(x => x.CreationDate).Not.Nullable();
                HasMany(x => x.Documents).KeyColumn("DossierId").NotFound.Ignore().Inverse().Cascade.AllDeleteOrphan().KeyNullable();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

    }
}

