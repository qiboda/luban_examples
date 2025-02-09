//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed partial class ExcelFromJson :  Bright.Config.BeanBase 
{
    public ExcelFromJson(ByteBuf _buf) 
    {
        X4 = _buf.ReadInt();
        X1 = _buf.ReadBool();
        X5 = _buf.ReadLong();
        X6 = _buf.ReadFloat();
        S1 = _buf.ReadString();
        S2_l10n_key = _buf.ReadString(); S2 = _buf.ReadString();
        V2 = _buf.ReadUnityVector2();
        V3 = _buf.ReadUnityVector3();
        V4 = _buf.ReadUnityVector4();
        T1 = _buf.ReadInt();
        X12 = test.DemoType1.DeserializeDemoType1(_buf);
        X13 = (test.DemoEnum)_buf.ReadInt();
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf);
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K1 = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); K1[__index0] = __e0;}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K8 = new System.Collections.Generic.Dictionary<int, int>(n0 * 3 / 2);for(var i0 = 0 ; i0 < n0 ; i0++) { int _k0;  _k0 = _buf.ReadInt(); int _v0;  _v0 = _buf.ReadInt();     K8.Add(_k0, _v0);}}
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K9 = new System.Collections.Generic.List<test.DemoE2>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { test.DemoE2 _e0;  _e0 = test.DemoE2.DeserializeDemoE2(_buf); K9.Add(_e0);}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);K15 = new test.DemoDynamic[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { test.DemoDynamic __e0;__e0 = test.DemoDynamic.DeserializeDemoDynamic(_buf); K15[__index0] = __e0;}}
        PostInit();
    }

    public static ExcelFromJson DeserializeExcelFromJson(ByteBuf _buf)
    {
        return new test.ExcelFromJson(_buf);
    }

    public int X4 { get; private set; }
    public bool X1 { get; private set; }
    public long X5 { get; private set; }
    public float X6 { get; private set; }
    public string S1 { get; private set; }
    public string S2 { get; private set; }
    public string S2_l10n_key { get; }
    public UnityEngine.Vector2 V2 { get; private set; }
    public UnityEngine.Vector3 V3 { get; private set; }
    public UnityEngine.Vector4 V4 { get; private set; }
    public int T1 { get; private set; }
    public long T1_Millis => T1 * 1000L;
    public test.DemoType1 X12 { get; private set; }
    public test.DemoEnum X13 { get; private set; }
    public test.DemoDynamic X14 { get; private set; }
    public int[] K1 { get; private set; }
    public System.Collections.Generic.Dictionary<int, int> K8 { get; private set; }
    public System.Collections.Generic.List<test.DemoE2> K9 { get; private set; }
    public test.DemoDynamic[] K15 { get; private set; }

    public const int __ID__ = -1485706483;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X12?.Resolve(_tables);
        X14?.Resolve(_tables);
        foreach(var _e in K9) { _e?.Resolve(_tables); }
        foreach(var _e in K15) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        S2 = translator(S2_l10n_key, S2);
        X12?.TranslateText(translator);
        X14?.TranslateText(translator);
        foreach(var _e in K9) { _e?.TranslateText(translator); }
        foreach(var _e in K15) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "X4:" + X4 + ","
        + "X1:" + X1 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "S1:" + S1 + ","
        + "S2:" + S2 + ","
        + "V2:" + V2 + ","
        + "V3:" + V3 + ","
        + "V4:" + V4 + ","
        + "T1:" + T1 + ","
        + "X12:" + X12 + ","
        + "X13:" + X13 + ","
        + "X14:" + X14 + ","
        + "K1:" + Bright.Common.StringUtil.CollectionToString(K1) + ","
        + "K8:" + Bright.Common.StringUtil.CollectionToString(K8) + ","
        + "K9:" + Bright.Common.StringUtil.CollectionToString(K9) + ","
        + "K15:" + Bright.Common.StringUtil.CollectionToString(K15) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
