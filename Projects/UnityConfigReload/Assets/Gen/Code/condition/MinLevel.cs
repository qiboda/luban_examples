//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.condition
{

public sealed partial class MinLevel :  condition.BoolRoleCondition 
{
    public MinLevel(ByteBuf _buf)  : base(_buf) 
    {
        Level = _buf.ReadInt();
        PostInit();
    }

    public static MinLevel DeserializeMinLevel(ByteBuf _buf)
    {
        return new condition.MinLevel(_buf);
    }

    public int Level { get; protected set; }

    public const int __ID__ = -1075273755;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public void Reload(MinLevel reloadData)
    {
        Level = reloadData.Level;
    }

    public override string ToString()
    {
        return "{ "
        + "Level:" + Level + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
