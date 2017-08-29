// begin generation Template.cs
#if !TEMPLATE
<#@ template debug="false" hostspecific="false" language="C#" #>
<#@ assembly name="System.Core" #>
<#@ assembly name="Microsoft.CSharp" #>
<#@ output extension=".cs" #>
<#@ import namespace="System.Dynamic" #>
<#@ import namespace="System.Linq" #>
<#@ import namespace="System.Reflection" #>
<#@ import namespace="System.Text" #>
<#@ import namespace="System.Collections" #>
<#@ import namespace="System.Collections.Generic" #>
using System;

namespace Acme
{

    public partial struct MetaInfo
    {
<#
    G.Main(this);
//#>
    }
}
#endif
// end generation Template.cs <#+
#if TEMPLATE
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
#endif

public static class G
{
    public static dynamic Self;

    public static void WriteLine(object o = null)
        => Write($"{o}{Environment.NewLine}");
    public static void Write(object o = null)
        => Self.Write($"{o}");

    public static void Main(dynamic self)
    {
        Self = self;
        Self.PushIndent("        ");

        WriteLine($"//Hello World!");

        Self.PopIndent();
    }
}
//#>