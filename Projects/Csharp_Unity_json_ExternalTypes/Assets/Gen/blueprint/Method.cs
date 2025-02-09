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



namespace cfg.blueprint
{

public abstract partial class Method :  Bright.Config.BeanBase 
{
    public Method(JSONNode _json) 
    {
        { if(!_json["name"].IsString) { throw new SerializationException(); }  Name = _json["name"]; }
        { if(!_json["desc"].IsString) { throw new SerializationException(); }  Desc = _json["desc"]; }
        { if(!_json["is_static"].IsBoolean) { throw new SerializationException(); }  IsStatic = _json["is_static"]; }
        { if(!_json["return_type"].IsString) { throw new SerializationException(); }  ReturnType = _json["return_type"]; }
        { var __json0 = _json["parameters"]; if(!__json0.IsArray) { throw new SerializationException(); } Parameters = new System.Collections.Generic.List<blueprint.ParamInfo>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { blueprint.ParamInfo __v0;  { if(!__e0.IsObject) { throw new SerializationException(); }  __v0 = blueprint.ParamInfo.DeserializeParamInfo(__e0);  }  Parameters.Add(__v0); }   }
        PostInit();
    }

    public Method(string name, string desc, bool is_static, string return_type, System.Collections.Generic.List<blueprint.ParamInfo> parameters ) 
    {
        this.Name = name;
        this.Desc = desc;
        this.IsStatic = is_static;
        this.ReturnType = return_type;
        this.Parameters = parameters;
        PostInit();
    }

    public static Method DeserializeMethod(JSONNode _json)
    {
        string type = _json["$type"];
        switch (type)
        {
            case "AbstraceMethod": return new blueprint.AbstraceMethod(_json);
            case "ExternalMethod": return new blueprint.ExternalMethod(_json);
            case "BlueprintMethod": return new blueprint.BlueprintMethod(_json);
            default: throw new SerializationException();
        }
    }

    public string Name { get; private set; }
    public string Desc { get; private set; }
    public bool IsStatic { get; private set; }
    public string ReturnType { get; private set; }
    public System.Collections.Generic.List<blueprint.ParamInfo> Parameters { get; private set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Parameters) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Parameters) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "IsStatic:" + IsStatic + ","
        + "ReturnType:" + ReturnType + ","
        + "Parameters:" + Bright.Common.StringUtil.CollectionToString(Parameters) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
