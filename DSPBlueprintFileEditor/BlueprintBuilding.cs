// Decompiled with JetBrains decompiler
// Type: BlueprintBuilding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C87D95C5-FEA4-445C-8FA9-3276876406D1
// Assembly location: E:\SteamLibrary\steamapps\common\Dyson Sphere Program\DSPGAME_Data\Managed\Assembly-CSharp.dll

using System.IO;

public class BlueprintBuilding
{
    public int index;
    public int areaIndex;
    public float localOffset_x;
    public float localOffset_y;
    public float localOffset_z;
    public float localOffset_x2;
    public float localOffset_y2;
    public float localOffset_z2;
    public float yaw;
    public float yaw2;
    public short itemId;
    public short modelIndex;
    public BlueprintBuilding outputObj;
    public BlueprintBuilding inputObj;
    public int tempOutputObjIdx;
    public int tempInputObjIdx;
    public int outputToSlot;
    public int inputFromSlot;
    public int outputFromSlot;
    public int inputToSlot;
    public int outputOffset;
    public int inputOffset;
    public int recipeId;
    public int filterId;
    public int[] parameters;

    public void Import(BinaryReader r, int _version)
    {
        this.index = r.ReadInt32();
        this.areaIndex = (int)r.ReadSByte();
        this.localOffset_x = r.ReadSingle();
        this.localOffset_y = r.ReadSingle();
        this.localOffset_z = r.ReadSingle();
        this.localOffset_x2 = r.ReadSingle();
        this.localOffset_y2 = r.ReadSingle();
        this.localOffset_z2 = r.ReadSingle();
        this.yaw = r.ReadSingle();
        this.yaw2 = r.ReadSingle();
        this.itemId = r.ReadInt16();
        this.modelIndex = r.ReadInt16();
        this.tempOutputObjIdx = r.ReadInt32();
        this.tempInputObjIdx = r.ReadInt32();
        this.outputToSlot = (int)r.ReadSByte();
        this.inputFromSlot = (int)r.ReadSByte();
        this.outputFromSlot = (int)r.ReadSByte();
        this.inputToSlot = (int)r.ReadSByte();
        this.outputOffset = (int)r.ReadSByte();
        this.inputOffset = (int)r.ReadSByte();
        this.recipeId = (int)r.ReadInt16();
        this.filterId = (int)r.ReadInt16();
        int length = (int)r.ReadInt16();
        this.parameters = new int[length];
        for (int index = 0; index < length; ++index)
            this.parameters[index] = r.ReadInt32();
    }

    public void Export(BinaryWriter w)
    {
        w.Write(this.index);
        w.Write((sbyte)this.areaIndex);
        w.Write(this.localOffset_x);
        w.Write(this.localOffset_y);
        w.Write(this.localOffset_z);
        w.Write(this.localOffset_x2);
        w.Write(this.localOffset_y2);
        w.Write(this.localOffset_z2);
        w.Write(this.yaw);
        w.Write(this.yaw2);
        w.Write(this.itemId);
        w.Write(this.modelIndex);
        w.Write(this.outputObj == null ? -1 : this.outputObj.index);
        w.Write(this.inputObj == null ? -1 : this.inputObj.index);
        w.Write((sbyte)this.outputToSlot);
        w.Write((sbyte)this.inputFromSlot);
        w.Write((sbyte)this.outputFromSlot);
        w.Write((sbyte)this.inputToSlot);
        w.Write((sbyte)this.outputOffset);
        w.Write((sbyte)this.inputOffset);
        w.Write((short)this.recipeId);
        w.Write((short)this.filterId);
        int num = this.parameters != null ? this.parameters.Length : 0;
        w.Write((short)num);
        for (int index = 0; index < num; ++index)
            w.Write(this.parameters[index]);
    }
}
