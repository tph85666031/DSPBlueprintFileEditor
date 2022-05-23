// Decompiled with JetBrains decompiler
// Type: MD5F
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C87D95C5-FEA4-445C-8FA9-3276876406D1
// Assembly location: E:\SteamLibrary\steamapps\common\Dyson Sphere Program\DSPGAME_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.IO;
using System.Text;

public static class MD5F
{
    private static uint A;
    private static uint B;
    private static uint C;
    private static uint D;
    private const int S11 = 7;
    private const int S12 = 12;
    private const int S13 = 17;
    private const int S14 = 22;
    private const int S21 = 5;
    private const int S22 = 9;
    private const int S23 = 14;
    private const int S24 = 20;
    private const int S31 = 4;
    private const int S32 = 11;
    private const int S33 = 16;
    private const int S34 = 23;
    private const int S41 = 6;
    private const int S42 = 10;
    private const int S43 = 15;
    private const int S44 = 21;

    private static uint F(uint x, uint y, uint z) => (uint)((int)x & (int)y | ~(int)x & (int)z);

    private static uint G(uint x, uint y, uint z) => (uint)((int)x & (int)z | (int)y & ~(int)z);

    private static uint H(uint x, uint y, uint z) => x ^ y ^ z;

    private static uint I(uint x, uint y, uint z) => y ^ (x | ~z);

    private static void FF(ref uint a, uint b, uint c, uint d, uint mj, int s, uint ti)
    {
        a = a + MD5F.F(b, c, d) + mj + ti;
        a = a << s | a >> 32 - s;
        a += b;
    }

    private static void GG(ref uint a, uint b, uint c, uint d, uint mj, int s, uint ti)
    {
        a = a + MD5F.G(b, c, d) + mj + ti;
        a = a << s | a >> 32 - s;
        a += b;
    }

    private static void HH(ref uint a, uint b, uint c, uint d, uint mj, int s, uint ti)
    {
        a = a + MD5F.H(b, c, d) + mj + ti;
        a = a << s | a >> 32 - s;
        a += b;
    }

    private static void II(ref uint a, uint b, uint c, uint d, uint mj, int s, uint ti)
    {
        a = a + MD5F.I(b, c, d) + mj + ti;
        a = a << s | a >> 32 - s;
        a += b;
    }

    private static void MD5_Init()
    {
        MD5F.A = 1732584193U;
        MD5F.B = 4024216457U;
        MD5F.C = 2562383102U;
        MD5F.D = 271734598U;
    }

    private static uint[] MD5_Append(byte[] input)
    {
        int num1 = 1;
        int length = input.Length;
        int num2 = length % 64;
        int num3;
        int num4;
        if (num2 < 56)
        {
            num3 = 55 - num2;
            num4 = length - num2 + 64;
        }
        else if (num2 == 56)
        {
            num3 = 63;
            num1 = 1;
            num4 = length + 8 + 64;
        }
        else
        {
            num3 = 63 - num2 + 56;
            num4 = length + 64 - num2 + 64;
        }
        ArrayList arrayList = new ArrayList((ICollection)input);
        if (num1 == 1)
            arrayList.Add((object)(byte)128);
        for (int index = 0; index < num3; ++index)
            arrayList.Add((object)(byte)0);
        long num5 = (long)length * 8L;
        byte num6 = (byte)((ulong)num5 & (ulong)byte.MaxValue);
        byte num7 = (byte)((ulong)num5 >> 8 & (ulong)byte.MaxValue);
        byte num8 = (byte)((ulong)num5 >> 16 & (ulong)byte.MaxValue);
        byte num9 = (byte)((ulong)num5 >> 24 & (ulong)byte.MaxValue);
        byte num10 = (byte)((ulong)num5 >> 32 & (ulong)byte.MaxValue);
        byte num11 = (byte)((ulong)num5 >> 40 & (ulong)byte.MaxValue);
        byte num12 = (byte)((ulong)num5 >> 48 & (ulong)byte.MaxValue);
        byte num13 = (byte)((ulong)num5 >> 56);
        arrayList.Add((object)num6);
        arrayList.Add((object)num7);
        arrayList.Add((object)num8);
        arrayList.Add((object)num9);
        arrayList.Add((object)num10);
        arrayList.Add((object)num11);
        arrayList.Add((object)num12);
        arrayList.Add((object)num13);
        byte[] array = (byte[])arrayList.ToArray(typeof(byte));
        uint[] numArray = new uint[num4 / 4];
        long index1 = 0;
        long index2 = 0;
        for (; index1 < (long)num4; index1 += 4L)
        {
            numArray[index2] = (uint)((int)array[index1] | (int)array[index1 + 1L] << 8 | (int)array[index1 + 2L] << 16 | (int)array[index1 + 3L] << 24);
            ++index2;
        }
        return numArray;
    }

    private static uint[] MD5_Trasform(uint[] x)
    {
        for (int index = 0; index < x.Length; index += 16)
        {
            uint a = MD5F.A;
            uint b = MD5F.B;
            uint c = MD5F.C;
            uint d = MD5F.D;
            MD5F.FF(ref a, b, c, d, x[index], 7, 3614090360U);
            MD5F.FF(ref d, a, b, c, x[index + 1], 12, 3906451286U);
            MD5F.FF(ref c, d, a, b, x[index + 2], 17, 606105819U);
            MD5F.FF(ref b, c, d, a, x[index + 3], 22, 3250441966U);
            MD5F.FF(ref a, b, c, d, x[index + 4], 7, 4118548399U);
            MD5F.FF(ref d, a, b, c, x[index + 5], 12, 1200080426U);
            MD5F.FF(ref c, d, a, b, x[index + 6], 17, 2821735971U);
            MD5F.FF(ref b, c, d, a, x[index + 7], 22, 4249261313U);
            MD5F.FF(ref a, b, c, d, x[index + 8], 7, 1770035416U);
            MD5F.FF(ref d, a, b, c, x[index + 9], 12, 2336552879U);
            MD5F.FF(ref c, d, a, b, x[index + 10], 17, 4294925233U);
            MD5F.FF(ref b, c, d, a, x[index + 11], 22, 2304563134U);
            MD5F.FF(ref a, b, c, d, x[index + 12], 7, 1805586722U);
            MD5F.FF(ref d, a, b, c, x[index + 13], 12, 4254626195U);
            MD5F.FF(ref c, d, a, b, x[index + 14], 17, 2792965006U);
            MD5F.FF(ref b, c, d, a, x[index + 15], 22, 968099873U);
            MD5F.GG(ref a, b, c, d, x[index + 1], 5, 4129170786U);
            MD5F.GG(ref d, a, b, c, x[index + 6], 9, 3225465664U);
            MD5F.GG(ref c, d, a, b, x[index + 11], 14, 643717713U);
            MD5F.GG(ref b, c, d, a, x[index], 20, 3384199082U);
            MD5F.GG(ref a, b, c, d, x[index + 5], 5, 3593408605U);
            MD5F.GG(ref d, a, b, c, x[index + 10], 9, 38024275U);
            MD5F.GG(ref c, d, a, b, x[index + 15], 14, 3634488961U);
            MD5F.GG(ref b, c, d, a, x[index + 4], 20, 3889429448U);
            MD5F.GG(ref a, b, c, d, x[index + 9], 5, 569495014U);
            MD5F.GG(ref d, a, b, c, x[index + 14], 9, 3275163606U);
            MD5F.GG(ref c, d, a, b, x[index + 3], 14, 4107603335U);
            MD5F.GG(ref b, c, d, a, x[index + 8], 20, 1197085933U);
            MD5F.GG(ref a, b, c, d, x[index + 13], 5, 2850285829U);
            MD5F.GG(ref d, a, b, c, x[index + 2], 9, 4243563512U);
            MD5F.GG(ref c, d, a, b, x[index + 7], 14, 1735328473U);
            MD5F.GG(ref b, c, d, a, x[index + 12], 20, 2368359562U);
            MD5F.HH(ref a, b, c, d, x[index + 5], 4, 4294588738U);
            MD5F.HH(ref d, a, b, c, x[index + 8], 11, 2272392833U);
            MD5F.HH(ref c, d, a, b, x[index + 11], 16, 1839030562U);
            MD5F.HH(ref b, c, d, a, x[index + 14], 23, 4259657740U);
            MD5F.HH(ref a, b, c, d, x[index + 1], 4, 2763975236U);
            MD5F.HH(ref d, a, b, c, x[index + 4], 11, 1272893353U);
            MD5F.HH(ref c, d, a, b, x[index + 7], 16, 4139469664U);
            MD5F.HH(ref b, c, d, a, x[index + 10], 23, 3200236656U);
            MD5F.HH(ref a, b, c, d, x[index + 13], 4, 681279174U);
            MD5F.HH(ref d, a, b, c, x[index], 11, 3936430074U);
            MD5F.HH(ref c, d, a, b, x[index + 3], 16, 3572445317U);
            MD5F.HH(ref b, c, d, a, x[index + 6], 23, 76029189U);
            MD5F.HH(ref a, b, c, d, x[index + 9], 4, 3654602809U);
            MD5F.HH(ref d, a, b, c, x[index + 12], 11, 3873151461U);
            MD5F.HH(ref c, d, a, b, x[index + 15], 16, 530742520U);
            MD5F.HH(ref b, c, d, a, x[index + 2], 23, 3299628645U);
            MD5F.II(ref a, b, c, d, x[index], 6, 4096336452U);
            MD5F.II(ref d, a, b, c, x[index + 7], 10, 1126891415U);
            MD5F.II(ref c, d, a, b, x[index + 14], 15, 2878612391U);
            MD5F.II(ref b, c, d, a, x[index + 5], 21, 4237533241U);
            MD5F.II(ref a, b, c, d, x[index + 12], 6, 1700485571U);
            MD5F.II(ref d, a, b, c, x[index + 3], 10, 2399980690U);
            MD5F.II(ref c, d, a, b, x[index + 10], 15, 4293915773U);
            MD5F.II(ref b, c, d, a, x[index + 1], 21, 2240044497U);
            MD5F.II(ref a, b, c, d, x[index + 8], 6, 1873313359U);
            MD5F.II(ref d, a, b, c, x[index + 15], 10, 4264355552U);
            MD5F.II(ref c, d, a, b, x[index + 6], 15, 2734768916U);
            MD5F.II(ref b, c, d, a, x[index + 13], 21, 1309151649U);
            MD5F.II(ref a, b, c, d, x[index + 4], 6, 4149444226U);
            MD5F.II(ref d, a, b, c, x[index + 11], 10, 3174756917U);
            MD5F.II(ref c, d, a, b, x[index + 2], 15, 718787259U);
            MD5F.II(ref b, c, d, a, x[index + 9], 21, 3951481745U);
            MD5F.A += a;
            MD5F.B += b;
            MD5F.C += c;
            MD5F.D += d;
        }
        return new uint[4] { MD5F.A, MD5F.B, MD5F.C, MD5F.D };
    }

    private static uint[] MD5_Append_Opt(byte[] input)
    {
        int num1 = 1;
        int length1 = input.Length;
        int num2 = length1 % 64;
        int num3;
        int num4;
        if (num2 < 56)
        {
            num3 = 55 - num2;
            num4 = length1 - num2 + 64;
        }
        else if (num2 == 56)
        {
            num3 = 63;
            num1 = 1;
            num4 = length1 + 8 + 64;
        }
        else
        {
            num3 = 63 - num2 + 56;
            num4 = length1 + 64 - num2 + 64;
        }
        int length2 = input.Length;
        int length3 = num3 + 8 + length2;
        if (num1 == 1)
            ++length3;
        byte[] numArray1 = new byte[length3];
        Array.Copy((Array)input, (Array)numArray1, length2);
        if (num1 == 1)
            numArray1[length2++] = (byte)128;
        for (int index = 0; index < num3; ++index)
            numArray1[length2++] = (byte)0;
        long num5 = (long)length1 * 8L;
        byte num6 = (byte)((ulong)num5 & (ulong)byte.MaxValue);
        byte num7 = (byte)((ulong)num5 >> 8 & (ulong)byte.MaxValue);
        byte num8 = (byte)((ulong)num5 >> 16 & (ulong)byte.MaxValue);
        byte num9 = (byte)((ulong)num5 >> 24 & (ulong)byte.MaxValue);
        byte num10 = (byte)((ulong)num5 >> 32 & (ulong)byte.MaxValue);
        byte num11 = (byte)((ulong)num5 >> 40 & (ulong)byte.MaxValue);
        byte num12 = (byte)((ulong)num5 >> 48 & (ulong)byte.MaxValue);
        byte num13 = (byte)((ulong)num5 >> 56);
        byte[] numArray2 = numArray1;
        int index1 = length2;
        int num14 = index1 + 1;
        int num15 = (int)num6;
        numArray2[index1] = (byte)num15;
        byte[] numArray3 = numArray1;
        int index2 = num14;
        int num16 = index2 + 1;
        int num17 = (int)num7;
        numArray3[index2] = (byte)num17;
        byte[] numArray4 = numArray1;
        int index3 = num16;
        int num18 = index3 + 1;
        int num19 = (int)num8;
        numArray4[index3] = (byte)num19;
        byte[] numArray5 = numArray1;
        int index4 = num18;
        int num20 = index4 + 1;
        int num21 = (int)num9;
        numArray5[index4] = (byte)num21;
        byte[] numArray6 = numArray1;
        int index5 = num20;
        int num22 = index5 + 1;
        int num23 = (int)num10;
        numArray6[index5] = (byte)num23;
        byte[] numArray7 = numArray1;
        int index6 = num22;
        int num24 = index6 + 1;
        int num25 = (int)num11;
        numArray7[index6] = (byte)num25;
        byte[] numArray8 = numArray1;
        int index7 = num24;
        int num26 = index7 + 1;
        int num27 = (int)num12;
        numArray8[index7] = (byte)num27;
        byte[] numArray9 = numArray1;
        int index8 = num26;
        int num28 = index8 + 1;
        int num29 = (int)num13;
        numArray9[index8] = (byte)num29;
        uint[] numArray10 = new uint[num4 / 4];
        long index9 = 0;
        long index10 = 0;
        for (; index9 < (long)num4; index9 += 4L)
        {
            numArray10[index10] = (uint)((int)numArray1[index9] | (int)numArray1[index9 + 1L] << 8 | (int)numArray1[index9 + 2L] << 16 | (int)numArray1[index9 + 3L] << 24);
            ++index10;
        }
        return numArray10;
    }

    private static byte[] MD5_Array(byte[] input)
    {
        MD5F.MD5_Init();
        uint[] numArray1 = MD5F.MD5_Trasform(MD5F.MD5_Append(input));
        byte[] numArray2 = new byte[numArray1.Length * 4];
        int index1 = 0;
        int index2 = 0;
        while (index1 < numArray1.Length)
        {
            numArray2[index2] = (byte)(numArray1[index1] & (uint)byte.MaxValue);
            numArray2[index2 + 1] = (byte)(numArray1[index1] >> 8 & (uint)byte.MaxValue);
            numArray2[index2 + 2] = (byte)(numArray1[index1] >> 16 & (uint)byte.MaxValue);
            numArray2[index2 + 3] = (byte)(numArray1[index1] >> 24 & (uint)byte.MaxValue);
            ++index1;
            index2 += 4;
        }
        return numArray2;
    }

    private static string ArrayToHexString(byte[] array, bool uppercase)
    {
        string str = "";
        string format = "x2";
        if (uppercase)
            format = "X2";
        foreach (byte num in array)
            str += num.ToString(format);
        return str;
    }

    public static string Compute(byte[] message)
    {
        MD5F.MD5_Init();
        uint[] numArray = MD5F.MD5_Trasform(MD5F.MD5_Append(message));
        byte[] array = new byte[numArray.Length * 4];
        int index1 = 0;
        int index2 = 0;
        while (index1 < numArray.Length)
        {
            array[index2] = (byte)(numArray[index1] & (uint)byte.MaxValue);
            array[index2 + 1] = (byte)(numArray[index1] >> 8 & (uint)byte.MaxValue);
            array[index2 + 2] = (byte)(numArray[index1] >> 16 & (uint)byte.MaxValue);
            array[index2 + 3] = (byte)(numArray[index1] >> 24 & (uint)byte.MaxValue);
            ++index1;
            index2 += 4;
        }
        return MD5F.ArrayToHexString(array, true);
    }

    public static string Compute(Stream stream)
    {
        byte[] input = new BinaryReader(stream).ReadBytes((int)stream.Length);
        MD5F.MD5_Init();
        uint[] numArray = MD5F.MD5_Trasform(MD5F.MD5_Append(input));
        byte[] array = new byte[numArray.Length * 4];
        int index1 = 0;
        int index2 = 0;
        while (index1 < numArray.Length)
        {
            array[index2] = (byte)(numArray[index1] & (uint)byte.MaxValue);
            array[index2 + 1] = (byte)(numArray[index1] >> 8 & (uint)byte.MaxValue);
            array[index2 + 2] = (byte)(numArray[index1] >> 16 & (uint)byte.MaxValue);
            array[index2 + 3] = (byte)(numArray[index1] >> 24 & (uint)byte.MaxValue);
            ++index1;
            index2 += 4;
        }
        return MD5F.ArrayToHexString(array, true);
    }

    public static string Compute_Opt(Stream stream)
    {
        byte[] input = new BinaryReader(stream).ReadBytes((int)stream.Length);
        MD5F.MD5_Init();
        uint[] numArray = MD5F.MD5_Trasform(MD5F.MD5_Append_Opt(input));
        byte[] array = new byte[numArray.Length * 4];
        int index1 = 0;
        int index2 = 0;
        while (index1 < numArray.Length)
        {
            array[index2] = (byte)(numArray[index1] & (uint)byte.MaxValue);
            array[index2 + 1] = (byte)(numArray[index1] >> 8 & (uint)byte.MaxValue);
            array[index2 + 2] = (byte)(numArray[index1] >> 16 & (uint)byte.MaxValue);
            array[index2 + 3] = (byte)(numArray[index1] >> 24 & (uint)byte.MaxValue);
            ++index1;
            index2 += 4;
        }
        return MD5F.ArrayToHexString(array, true);
    }

    public static string Compute(string message) => MD5F.ArrayToHexString(MD5F.MD5_Array(Encoding.UTF8.GetBytes(message)), true);
}
