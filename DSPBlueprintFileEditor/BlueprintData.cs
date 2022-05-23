// Decompiled with JetBrains decompiler
// Type: BlueprintData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C87D95C5-FEA4-445C-8FA9-3276876406D1
// Assembly location: E:\SteamLibrary\steamapps\common\Dyson Sphere Program\DSPGAME_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

public class BlueprintData
{
    public DateTime time;
    public string gameVersion;
    public string shortDesc;
    public string desc;
    public EIconLayout layout;
    public int icon0;
    public int icon1;
    public int icon2;
    public int icon3;
    public int icon4;
    public int cursorOffset_x;
    public int cursorOffset_y;
    public int cursorTargetArea;
    public int dragBoxSize_x;
    public int dragBoxSize_y;
    public int primaryAreaIdx;
    public BlueprintArea[] areas;
    public BlueprintBuilding[] buildings;
    private List<BlueprintBuilding> _tmp_buidings = new List<BlueprintBuilding>();
    private List<BlueprintBuilding> _del_buidings = new List<BlueprintBuilding>();
    private int version;

    public bool isValid => this.primaryAreaIdx >= 0 && this.buildings != null && (this.areas != null && this.areas.Length != 0);

    public bool isEmpty => this.buildings == null || this.buildings.Length == 0;

    public static bool IsNullOrEmpty(BlueprintData blueprint) => blueprint == null || !blueprint.isValid || blueprint.buildings.Length == 0;

    public string headerStr => "BLUEPRINT:0," + ((int)this.layout).ToString() + "," + this.icon0.ToString() + "," + this.icon1.ToString() + "," + this.icon2.ToString() + "," + this.icon3.ToString() + "," + this.icon4.ToString() + ",0," + this.time.Ticks.ToString() + "," + this.gameVersion + "," + Uri.EscapeDataString(this.shortDesc) + "," + Uri.EscapeDataString(this.desc) + "\"";

    public BlueprintData()
    {
        this.Reset();
    }

    private BlueprintData(string _str64Data)
    {
        if (this.ContentFromBase64String(_str64Data) == BlueprintDataIOError.OK)
            return;
        this.Reset();
    }

    public void Reset()
    {
        this.time = new DateTime();
        this.gameVersion = "";
        this.shortDesc = "";
        this.desc = "";
        this.layout = EIconLayout.None;
        this.icon0 = 0;
        this.icon1 = 0;
        this.icon2 = 0;
        this.icon3 = 0;
        this.icon4 = 0;
        this.cursorOffset_x = 0;
        this.cursorOffset_y = 0;
        this.dragBoxSize_x = 1;
        this.dragBoxSize_y = 1;
        this.cursorTargetArea = 0;
        this.primaryAreaIdx = -1;
        this.areas = (BlueprintArea[])null;
        this.buildings = (BlueprintBuilding[])null;
    }

    public void ResetAsEmpty()
    {
        this.time = DateTime.Now;
        this.gameVersion = Config.game_version;
        this.shortDesc = "新的蓝图";
        this.desc = "";
        this.layout = EIconLayout.OneIcon;
        this.icon0 = 0;
        this.icon1 = 0;
        this.icon2 = 0;
        this.icon3 = 0;
        this.icon4 = 0;
        this.cursorOffset_x = 0;
        this.cursorOffset_y = 0;
        this.dragBoxSize_x = 1;
        this.dragBoxSize_y = 1;
        this.cursorTargetArea = 0;
        this.primaryAreaIdx = 0;
        this.areas = new BlueprintArea[1];
        this.areas[0] = new BlueprintArea();
        this.areas[0].index = 0;
        this.areas[0].parentIndex = -1;
        this.areas[0].tropicAnchor = 0;
        this.areas[0].areaSegments = 200;
        this.areas[0].anchorLocalOffsetX = 0;
        this.areas[0].anchorLocalOffsetY = 0;
        this.areas[0].width = 1;
        this.areas[0].height = 1;
        this.buildings = new BlueprintBuilding[0];
    }

    public void ResetContentAsEmpty()
    {
        this.cursorOffset_x = 0;
        this.cursorOffset_y = 0;
        this.dragBoxSize_x = 1;
        this.dragBoxSize_y = 1;
        this.cursorTargetArea = 0;
        this.primaryAreaIdx = 0;
        this.areas = new BlueprintArea[1];
        this.areas[0] = new BlueprintArea();
        this.areas[0].index = 0;
        this.areas[0].parentIndex = -1;
        this.areas[0].tropicAnchor = 0;
        this.areas[0].areaSegments = 200;
        this.areas[0].anchorLocalOffsetX = 0;
        this.areas[0].anchorLocalOffsetY = 0;
        this.areas[0].width = 1;
        this.areas[0].height = 1;
        this.buildings = new BlueprintBuilding[0];
    }

    public void Free()
    {
        if (this.areas != null)
        {
            for (int index = 0; index < this.areas.Length; ++index)
                this.areas[index] = (BlueprintArea)null;
        }
        this.Reset();
    }

    



    public bool SaveBlueprintData(string _fileName)
    {
        if (!this.isValid)
            return false;
        try
        {
            string fullName = new FileInfo(_fileName).Directory.FullName;
            if (!Directory.Exists(fullName))
                Directory.CreateDirectory(fullName);
            File.WriteAllText(_fileName, this.ToBase64String(), Encoding.ASCII);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public BlueprintDataIOError LoadBlueprintData(string _fileName)
    {
        string str64Data;
        try
        {
            str64Data = File.ReadAllText(_fileName, Encoding.ASCII);
        }
        catch
        {
            this.Reset();
            return BlueprintDataIOError.FileIOError;
        }
        try
        {
            int num = (int)this.FromBase64String(str64Data);
            if (num != 0)
                this.Reset();
            return (BlueprintDataIOError)num;
        }
        catch
        {
            this.Reset();
            return BlueprintDataIOError.DataCorruption;
        }
    }

    public BlueprintDataIOError LoadHeader(string _fileName)
    {
        if (File.Exists(_fileName))
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder(128);
                using (FileStream fileStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader binaryReader = new BinaryReader((Stream)fileStream))
                    {
                        int num = fileStream.Length < 4096L ? (int)fileStream.Length : 4096;
                        char[] chArray = binaryReader.ReadChars(28);
                        stringBuilder.Append(chArray);
                        for (int index = 0; index < num; ++index)
                        {
                            char ch = binaryReader.ReadChar();
                            stringBuilder.Append(ch);
                            if (ch == '"')
                                break;
                        }
                    }
                }
                return this.HeaderFromBase64String(stringBuilder.ToString());
            }
            catch
            {
                this.Reset();
                return BlueprintDataIOError.FileIOError;
            }
        }
        else
        {
            this.Reset();
            return BlueprintDataIOError.FileIOError;
        }
    }

    public BlueprintDataIOError HeaderFromBase64String(string contentStr)
    {
        this.Reset();
        if (contentStr.Length < 28)
        {
            this.Reset();
            return BlueprintDataIOError.HeaderDataError;
        }
        if (contentStr[0] == 'B' && contentStr[1] == 'L' && (contentStr[2] == 'U' && contentStr[3] == 'E') && (contentStr[4] == 'P' && contentStr[5] == 'R' && (contentStr[6] == 'I' && contentStr[7] == 'N')) && contentStr[8] == 'T')
        {
            if (contentStr[9] == ':')
            {
                try
                {
                    int num = Math.Min(contentStr.Length, 4096);
                    for (int index = 28; index < num; ++index)
                    {
                        if (contentStr[index] == '"')
                        {
                            string[] strArray = contentStr.Substring(10, index - 10).Split(',');
                            if (strArray.Length < 12)
                                return BlueprintDataIOError.HeaderDataError;
                            int o1=Int32.Parse(strArray[1]);
                            this.icon0 = Int32.Parse(strArray[2]);
                            this.icon1 = Int32.Parse(strArray[3]);
                            this.icon2 = Int32.Parse(strArray[4]);
                            this.icon3 = Int32.Parse(strArray[5]);
                            this.icon4 = Int32.Parse(strArray[6]);
                            long o2=long.Parse(strArray[8]);
                            this.gameVersion = strArray[9];
                            this.shortDesc = Uri.UnescapeDataString(strArray[10]);
                            this.desc = Uri.UnescapeDataString(strArray[11]);
                            this.layout = (EIconLayout)o1;
                            this.time = new DateTime(o2);
                            return BlueprintDataIOError.OK;
                        }
                    }
                    this.Reset();
                    return BlueprintDataIOError.HeaderDataError;
                }
                catch
                {
                    this.Reset();
                    return BlueprintDataIOError.HeaderDataError;
                }
            }
        }
        this.Reset();
        return BlueprintDataIOError.HeaderDataError;
    }

    public BlueprintDataIOError CheckSignature(string _str64Data)
    {
        int num = Math.Max(_str64Data.Length - 36, 0);
        for (int index = _str64Data.Length - 1; index >= num; --index)
        {
            if (_str64Data[index] == '"')
                return MD5F.Compute(_str64Data.Substring(0, index)).Equals(_str64Data.Substring(index + 1, 32), StringComparison.Ordinal) ? BlueprintDataIOError.OK : BlueprintDataIOError.MD5CannotMatch;
        }
        return BlueprintDataIOError.DataCorruption;
    }

    public BlueprintDataIOError ContentFromBase64String(string strData)
    {
        try
        {
            int num1 = -1;
            int num2 = -1;
            for (int index = 0; index < strData.Length; ++index)
            {
                if (strData[index] == '"')
                {
                    num1 = index;
                    break;
                }
            }
            if (num1 < 0)
                return BlueprintDataIOError.DataCorruption;
            for (int index = strData.Length - 1; index >= 0; --index)
            {
                if (strData[index] == '"')
                {
                    num2 = index;
                    break;
                }
            }
            if (num2 < num1 + 32)
                return BlueprintDataIOError.DataCorruption;
            using (MemoryStream memoryStream1 = new MemoryStream(Convert.FromBase64String(strData.Substring(num1 + 1, num2 - num1 - 1))))
            {
                using (MemoryStream memoryStream2 = new MemoryStream())
                {
                    using (GZipStream gzipStream = new GZipStream((Stream)memoryStream1, CompressionMode.Decompress))
                        gzipStream.CopyTo((Stream)memoryStream2);
                    memoryStream2.Position = 0L;
                    using (BinaryReader r = new BinaryReader((Stream)memoryStream2))
                        this.Import(r);
                }
            }
            return BlueprintDataIOError.OK;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Load Blueprint Error: \r\n" + ex.ToString().Replace("Exception", "Excption"));
            return BlueprintDataIOError.DataCorruption;
        }
    }

    public string ToBase64String()
    {
        try
        {
            StringBuilder stringBuilder = new StringBuilder(1024);
            using (MemoryStream memoryStream1 = new MemoryStream())
            {
                using (BinaryWriter w = new BinaryWriter((Stream)memoryStream1))
                {
                    this.Export(w);
                    memoryStream1.Position = 0L;
                    using (MemoryStream memoryStream2 = new MemoryStream())
                    {
                        using (GZipStream gzipStream = new GZipStream((Stream)memoryStream2, CompressionMode.Compress))
                            memoryStream1.CopyTo((Stream)gzipStream);
                        byte[] array = memoryStream2.ToArray();
                        stringBuilder.Append(this.headerStr);
                        stringBuilder.Append(Convert.ToBase64String(array));
                        string str = MD5F.Compute(stringBuilder.ToString());
                        stringBuilder.Append("\"");
                        stringBuilder.Append(str);
                        return stringBuilder.ToString();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString().Replace("Exception", "Excption"));
        }
        return "";
    }

    public StringBuilder ToBase64StringBuilder()
    {
        try
        {
            StringBuilder stringBuilder = new StringBuilder(1024);
            using (MemoryStream memoryStream1 = new MemoryStream())
            {
                using (BinaryWriter w = new BinaryWriter((Stream)memoryStream1))
                {
                    this.Export(w);
                    memoryStream1.Position = 0L;
                    using (MemoryStream memoryStream2 = new MemoryStream())
                    {
                        using (GZipStream gzipStream = new GZipStream((Stream)memoryStream2, CompressionMode.Compress))
                            memoryStream1.CopyTo((Stream)gzipStream);
                        byte[] array = memoryStream2.ToArray();
                        stringBuilder.Append(this.headerStr);
                        stringBuilder.Append(Convert.ToBase64String(array));
                        string str = MD5F.Compute(stringBuilder.ToString());
                        stringBuilder.Append("\"");
                        stringBuilder.Append(str);
                        return stringBuilder;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString().Replace("Exception", "Excption"));
        }
        return (StringBuilder)null;
    }

    public BlueprintDataIOError FromBase64String(string str64Data)
    {
        BlueprintDataIOError blueprintDataIoError1 = this.HeaderFromBase64String(str64Data);
        if (blueprintDataIoError1 != BlueprintDataIOError.OK)
        {
            this.Reset();
            return blueprintDataIoError1;
        }
        BlueprintDataIOError blueprintDataIoError2 = this.CheckSignature(str64Data);
        if (blueprintDataIoError2 != BlueprintDataIOError.OK)
        {
            this.Reset();
            return blueprintDataIoError2;
        }
        BlueprintDataIOError blueprintDataIoError3 = this.ContentFromBase64String(str64Data);
        if (blueprintDataIoError3 == BlueprintDataIOError.OK)
            return BlueprintDataIOError.OK;
        this.Reset();
        return blueprintDataIoError3;
    }

    public bool Import(BinaryReader r)
    {
        this.version = r.ReadInt32();
        this.cursorOffset_x = r.ReadInt32();
        this.cursorOffset_y = r.ReadInt32();
        this.cursorTargetArea = r.ReadInt32();
        this.dragBoxSize_x = r.ReadInt32();
        this.dragBoxSize_y = r.ReadInt32();
        this.primaryAreaIdx = r.ReadInt32();
        int length1 = (int)r.ReadByte();
        if (length1 >= 0 && length1 <= 64 && (this.primaryAreaIdx >= -1 && this.primaryAreaIdx <= length1))
        {
            this.areas = new BlueprintArea[length1];
        }
        else
        {
            return false;
        }
        for (int index = 0; index < length1; ++index)
        {
            this.areas[index] = new BlueprintArea();
            this.areas[index].Import(r, this.version);
        }
        int length2 = r.ReadInt32();
        if (length2 >= 0 && length2 <= 1048576)
        {
            this.buildings = new BlueprintBuilding[length2];
        }
        else
        {
            return false;
        }
        for (int index = 0; index < length2; ++index)
        {
            this.buildings[index] = new BlueprintBuilding();
            this.buildings[index].Import(r, this.version);
        }
        for (int index = 0; index < length2; ++index)
        {
            if (this.buildings[index].outputObj == null && this.buildings[index].tempOutputObjIdx >= 0)
                this.buildings[index].outputObj = this.buildings[this.buildings[index].tempOutputObjIdx];
            if (this.buildings[index].inputObj == null && this.buildings[index].tempInputObjIdx >= 0)
                this.buildings[index].inputObj = this.buildings[this.buildings[index].tempInputObjIdx];
        }
        this.DataRepair();
        return true;
    }

    public void Export(BinaryWriter w)
    {
        this.version = 1;
        w.Write(this.version);
        w.Write(this.cursorOffset_x);
        w.Write(this.cursorOffset_y);
        w.Write(this.cursorTargetArea);
        w.Write(this.dragBoxSize_x);
        w.Write(this.dragBoxSize_y);
        w.Write(this.primaryAreaIdx);
        int num1 = this.areas != null ? this.areas.Length : 0;
        w.Write((byte)num1);
        for (int index = 0; index < num1; ++index)
            this.areas[index].Export(w);
        int num2 = this.buildings != null ? this.buildings.Length : 0;
        w.Write(num2);
        for (int index = 0; index < num2; ++index)
            this.buildings[index].Export(w);
    }

    public void DataRepair()
    {
        int length = this.areas.Length;
        if (this.version > 0 || length <= 0 || (this.areas[0].areaSegments != 4 || this.areas[0].anchorLocalOffsetX != 17 ? (this.areas[length - 1].areaSegments != 4 ? 0 : (this.areas[length - 1].anchorLocalOffsetX == 17 ? 1 : 0)) : 1) == 0)
            return;
        for (int index = 0; index < length; ++index)
            this.areas[index].anchorLocalOffsetX = 0;
    }
}
