﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;

public partial class CstwebEntities : DbContext
{
    public CstwebEntities()
        : base("name=CstwebEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public DbSet<accounts> accounts { get; set; }
    public DbSet<lesclass> lesclass { get; set; }
    public DbSet<lesrelation> lesrelation { get; set; }
    public DbSet<news> news { get; set; }
    public DbSet<sysdiagrams> sysdiagrams { get; set; }
    public DbSet<teachers> teachers { get; set; }
    public DbSet<teachlevel> teachlevel { get; set; }
    public DbSet<title> title { get; set; }
    public DbSet<teachersall> teachersall { get; set; }
    public DbSet<lesson> lesson { get; set; }
    public DbSet<lessonandclass> lessonandclass { get; set; }
    public DbSet<games> games { get; set; }
    public DbSet<cooperation> cooperation { get; set; }
    public DbSet<labs> labs { get; set; }

    public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));

        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }

    public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));

        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }

    public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
    }

    public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
    }

    public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
    }

    public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
    {
        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));

        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));

        var new_diagramnameParameter = new_diagramname != null ?
            new ObjectParameter("new_diagramname", new_diagramname) :
            new ObjectParameter("new_diagramname", typeof(string));

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
    }

    public virtual int sp_upgraddiagrams()
    {
        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
    }
}
