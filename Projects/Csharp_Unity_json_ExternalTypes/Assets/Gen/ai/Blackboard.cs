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



namespace cfg.ai
{

public sealed partial class Blackboard :  Bright.Config.BeanBase 
{
    public Blackboard(JSONNode _json) 
    {
        { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
        { if(!_json["desc"].IsString) { throw new SerializationException(); }  Desc = _json["desc"]; }
        { if(!_json["parent_name"].IsString) { throw new SerializationException(); }  ParentName = _json["parent_name"]; }
        { var __json0 = _json["keys"]; if(!__json0.IsArray) { throw new SerializationException(); } Keys = new System.Collections.Generic.List<ai.BlackboardKey>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { ai.BlackboardKey __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = ai.BlackboardKey.DeserializeBlackboardKey(__e0);  }  Keys.Add(__v0); }   }
        PostInit();
    }

    public Blackboard(string name, string desc, string parent_name, System.Collections.Generic.List<ai.BlackboardKey> keys ) 
    {
        this.Name = name;
        this.Desc = desc;
        this.ParentName = parent_name;
        this.Keys = keys;
        PostInit();
    }

    public static Blackboard DeserializeBlackboard(JSONNode _json)
    {
        return new ai.Blackboard(_json);
    }

    public string Name { get; private set; }
    public string Desc { get; private set; }
    public string ParentName { get; private set; }
    public ai.Blackboard ParentName_Ref { get; private set; }
    public System.Collections.Generic.List<ai.BlackboardKey> Keys { get; private set; }

    public const int __ID__ = 1576193005;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.ParentName_Ref = (_tables["ai.TbBlackboard"] as ai.TbBlackboard).GetOrDefault(ParentName);
        foreach(var _e in Keys) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Keys) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "ParentName:" + ParentName + ","
        + "Keys:" + Bright.Common.StringUtil.CollectionToString(Keys) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
