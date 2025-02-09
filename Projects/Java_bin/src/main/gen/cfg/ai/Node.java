
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.ai;

import bright.serialization.*;



public abstract class Node {
    public Node(ByteBuf _buf) { 
        id = _buf.readInt();
        nodeName = _buf.readString();
    }

    public Node(int id, String node_name ) {
        this.id = id;
        this.nodeName = node_name;
    }

    public static Node deserializeNode(ByteBuf _buf) {
        switch (_buf.readInt()) {
            case cfg.ai.UeSetDefaultFocus.__ID__: return new cfg.ai.UeSetDefaultFocus(_buf);
            case cfg.ai.ExecuteTimeStatistic.__ID__: return new cfg.ai.ExecuteTimeStatistic(_buf);
            case cfg.ai.ChooseTarget.__ID__: return new cfg.ai.ChooseTarget(_buf);
            case cfg.ai.KeepFaceTarget.__ID__: return new cfg.ai.KeepFaceTarget(_buf);
            case cfg.ai.GetOwnerPlayer.__ID__: return new cfg.ai.GetOwnerPlayer(_buf);
            case cfg.ai.UpdateDailyBehaviorProps.__ID__: return new cfg.ai.UpdateDailyBehaviorProps(_buf);
            case cfg.ai.UeLoop.__ID__: return new cfg.ai.UeLoop(_buf);
            case cfg.ai.UeCooldown.__ID__: return new cfg.ai.UeCooldown(_buf);
            case cfg.ai.UeTimeLimit.__ID__: return new cfg.ai.UeTimeLimit(_buf);
            case cfg.ai.UeBlackboard.__ID__: return new cfg.ai.UeBlackboard(_buf);
            case cfg.ai.UeForceSuccess.__ID__: return new cfg.ai.UeForceSuccess(_buf);
            case cfg.ai.IsAtLocation.__ID__: return new cfg.ai.IsAtLocation(_buf);
            case cfg.ai.DistanceLessThan.__ID__: return new cfg.ai.DistanceLessThan(_buf);
            case cfg.ai.Sequence.__ID__: return new cfg.ai.Sequence(_buf);
            case cfg.ai.Selector.__ID__: return new cfg.ai.Selector(_buf);
            case cfg.ai.SimpleParallel.__ID__: return new cfg.ai.SimpleParallel(_buf);
            case cfg.ai.UeWait.__ID__: return new cfg.ai.UeWait(_buf);
            case cfg.ai.UeWaitBlackboardTime.__ID__: return new cfg.ai.UeWaitBlackboardTime(_buf);
            case cfg.ai.MoveToTarget.__ID__: return new cfg.ai.MoveToTarget(_buf);
            case cfg.ai.ChooseSkill.__ID__: return new cfg.ai.ChooseSkill(_buf);
            case cfg.ai.MoveToRandomLocation.__ID__: return new cfg.ai.MoveToRandomLocation(_buf);
            case cfg.ai.MoveToLocation.__ID__: return new cfg.ai.MoveToLocation(_buf);
            case cfg.ai.DebugPrint.__ID__: return new cfg.ai.DebugPrint(_buf);
            default: throw new SerializationException();
        }
    }

    public final int id;
    public final String nodeName;

    public abstract int getTypeId();

    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "}";
    }
}
