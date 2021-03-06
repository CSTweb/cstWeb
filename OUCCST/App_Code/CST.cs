﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class accounts
{
    public int id { get; set; }
    public string account { get; set; }
    public string password { get; set; }
    public int accountlevel { get; set; }
    public Nullable<int> teacherid { get; set; }

    public virtual teachers teachers { get; set; }
}

public partial class cooperation
{
    public int id { get; set; }
    public string cooperation1 { get; set; }
    public string body { get; set; }
    public System.DateTime addtime { get; set; }
    public int @class { get; set; }
}

public partial class exchange
{
    public int id { get; set; }
    public string name { get; set; }
    public string grade { get; set; }
    public string major { get; set; }
    public string nation { get; set; }
    public string photo { get; set; }
    public string email { get; set; }
    public string home { get; set; }
    public string birth { get; set; }
    public string ect { get; set; }
}

public partial class friends
{
    public int id { get; set; }
    public string fname { get; set; }
    public int sex { get; set; }
    public string cyear { get; set; }
    public string workplace { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string birth { get; set; }
    public string ect { get; set; }
    public string photo { get; set; }
}

public partial class games
{
    public int id { get; set; }
    public string gamename { get; set; }
    public int status { get; set; }
    public string body { get; set; }
    public System.DateTime addtime { get; set; }
}

public partial class graduate
{
    public int id { get; set; }
    public string graduate1 { get; set; }
    public System.DateTime addtime { get; set; }
    public string body { get; set; }
}

public partial class labs
{
    public int id { get; set; }
    public string labname { get; set; }
    public string labbody { get; set; }
    public System.DateTime addtime { get; set; }
}

public partial class lesclass
{
    public lesclass()
    {
        this.lesson = new HashSet<lesson>();
    }

    public int id { get; set; }
    public string name { get; set; }

    public virtual ICollection<lesson> lesson { get; set; }
}

public partial class lesrelation
{
    public int id { get; set; }
    public int lesson { get; set; }
    public int firstlesson { get; set; }

    public virtual lesson lesson1 { get; set; }
    public virtual lesson lesson2 { get; set; }
}

public partial class lesson
{
    public lesson()
    {
        this.lesrelation = new HashSet<lesrelation>();
        this.lesrelation1 = new HashSet<lesrelation>();
    }

    public int id { get; set; }
    public string classname { get; set; }
    public int teach { get; set; }
    public int experiment { get; set; }
    public double credits { get; set; }
    public int lesscla { get; set; }
    public string lesfile { get; set; }
    public string etc { get; set; }

    public virtual lesclass lesclass { get; set; }
    public virtual ICollection<lesrelation> lesrelation { get; set; }
    public virtual ICollection<lesrelation> lesrelation1 { get; set; }
}

public partial class lessonandclass
{
    public string name { get; set; }
    public int id { get; set; }
    public string classname { get; set; }
    public int teach { get; set; }
    public int experiment { get; set; }
    public double credits { get; set; }
    public int lesscla { get; set; }
}

public partial class news
{
    public int id { get; set; }
    public string title { get; set; }
    public string body { get; set; }
    public System.DateTime time { get; set; }
    public int @class { get; set; }
    public string pic { get; set; }
}

public partial class sysdiagrams
{
    public string name { get; set; }
    public int principal_id { get; set; }
    public int diagram_id { get; set; }
    public Nullable<int> version { get; set; }
    public byte[] definition { get; set; }
}

public partial class teachers
{
    public teachers()
    {
        this.accounts = new HashSet<accounts>();
    }

    public int id { get; set; }
    public string name { get; set; }
    public string mail { get; set; }
    public string photo { get; set; }
    public string office { get; set; }
    public int title { get; set; }
    public string phone { get; set; }
    public int teacherlevel { get; set; }
    public System.DateTime time { get; set; }
    public string home { get; set; }
    public string field { get; set; }
    public string education { get; set; }
    public string parttimejob { get; set; }
    public string course { get; set; }
    public string reward { get; set; }
    public string project { get; set; }
    public string paper { get; set; }
    public string etc { get; set; }

    public virtual ICollection<accounts> accounts { get; set; }
    public virtual teachlevel teachlevel { get; set; }
    public virtual title title1 { get; set; }
}

public partial class teachersall
{
    public int id { get; set; }
    public string name { get; set; }
    public string mail { get; set; }
    public string photo { get; set; }
    public string office { get; set; }
    public int title { get; set; }
    public string phone { get; set; }
    public int teacherlevel { get; set; }
    public System.DateTime time { get; set; }
    public string home { get; set; }
    public string field { get; set; }
    public string education { get; set; }
    public string parttimejob { get; set; }
    public string course { get; set; }
    public string reward { get; set; }
    public string project { get; set; }
    public string paper { get; set; }
    public string etc { get; set; }
    public string levelname { get; set; }
    public string titlename { get; set; }
}

public partial class teachlevel
{
    public teachlevel()
    {
        this.teachers = new HashSet<teachers>();
    }

    public int id { get; set; }
    public string name { get; set; }

    public virtual ICollection<teachers> teachers { get; set; }
}

public partial class title
{
    public title()
    {
        this.teachers = new HashSet<teachers>();
    }

    public int id { get; set; }
    public string name { get; set; }

    public virtual ICollection<teachers> teachers { get; set; }
}

public partial class sp_helpdiagramdefinition_Result
{
    public Nullable<int> version { get; set; }
    public byte[] definition { get; set; }
}

public partial class sp_helpdiagrams_Result
{
    public string Database { get; set; }
    public string Name { get; set; }
    public int ID { get; set; }
    public string Owner { get; set; }
    public int OwnerID { get; set; }
}
