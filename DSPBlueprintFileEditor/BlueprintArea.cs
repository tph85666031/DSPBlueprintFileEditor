// Decompiled with JetBrains decompiler
// Type: BlueprintArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C87D95C5-FEA4-445C-8FA9-3276876406D1
// Assembly location: E:\SteamLibrary\steamapps\common\Dyson Sphere Program\DSPGAME_Data\Managed\Assembly-CSharp.dll

using System.IO;

public class BlueprintArea
{
    public int index;
    public int parentIndex;
    public int tropicAnchor;
    public int areaSegments;
    public int anchorLocalOffsetX;
    public int anchorLocalOffsetY;
    public int width;
    public int height;

    public void Import(BinaryReader r, int _version)
    {
        this.index = (int)r.ReadSByte();
        this.parentIndex = (int)r.ReadSByte();
        this.tropicAnchor = (int)r.ReadInt16();
        this.areaSegments = (int)r.ReadInt16();
        this.anchorLocalOffsetX = (int)r.ReadInt16();
        this.anchorLocalOffsetY = (int)r.ReadInt16();
        this.width = (int)r.ReadInt16();
        this.height = (int)r.ReadInt16();
    }

    public void Export(BinaryWriter w)
    {
        w.Write((sbyte)this.index);
        w.Write((sbyte)this.parentIndex);
        w.Write((short)this.tropicAnchor);
        w.Write((short)this.areaSegments);
        w.Write((short)this.anchorLocalOffsetX);
        w.Write((short)this.anchorLocalOffsetY);
        w.Write((short)this.width);
        w.Write((short)this.height);
    }
}
