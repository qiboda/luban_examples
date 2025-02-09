//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.condition
{

public sealed partial class ClothesPropertyScoreGreaterThan :  condition.BoolRoleCondition 
{
    public ClothesPropertyScoreGreaterThan(JSONNode _json)  : base(_json) 
    {
        { if(!_json["prop"].IsNumber) { throw new SerializationException(); }  Prop = (item.EClothesPropertyType)_json["prop"].AsInt; }
        { if(!_json["value"].IsNumber) { throw new SerializationException(); }  Value = _json["value"]; }
        PostInit();
    }

    public ClothesPropertyScoreGreaterThan(item.EClothesPropertyType prop, int value )  : base() 
    {
        this.Prop = prop;
        this.Value = value;
        PostInit();
    }

    public static ClothesPropertyScoreGreaterThan DeserializeClothesPropertyScoreGreaterThan(JSONNode _json)
    {
        return new condition.ClothesPropertyScoreGreaterThan(_json);
    }

    public item.EClothesPropertyType Prop { get; private set; }
    public int Value { get; private set; }

    public const int __ID__ = 696630835;
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

    public override string ToString()
    {
        return "{ "
        + "Prop:" + Prop + ","
        + "Value:" + Value + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
