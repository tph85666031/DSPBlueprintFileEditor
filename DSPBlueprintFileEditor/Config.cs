using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Config
{
    public static string path;
    public static string game_version;
    public static Dictionary<int, string> items = new Dictionary<int, string>();
    public static Dictionary<int, string> recipes = new Dictionary<int, string>();

    public static int index_charge_power = 320;
    public static int index_warp_distance = 324;
    public static int index_drone_load = 326;
    public static int index_vessel_load = 327;
    public static int index_gather_speed = 329;
    public static int index_proliferator = 0;

    public static int index_item1 = 0;
    public static int index_item1_local_mode = 1;
    public static int index_item1_remote_mode = 2;
    public static int index_item1_capacity = 3;

    public static int index_item2 = 6;
    public static int index_item2_local_mode = 7;
    public static int index_item2_remote_mode = 8;
    public static int index_item2_capacity = 9;

    public static int index_item3 = 12;
    public static int index_item3_local_mode = 13;
    public static int index_item3_remote_mode = 14;
    public static int index_item3_capacity = 15;

    public static int index_item4 = 18;
    public static int index_item4_local_mode = 19;
    public static int index_item4_remote_mode = 20;
    public static int index_item4_capacity = 21;

    public static int index_item5 = 24;
    public static int index_item5_local_mode = 25;
    public static int index_item5_remote_mode = 26;
    public static int index_item5_capacity = 27;

    public static int STATON_ITEM_MODE_STORE = 0;
    public static int STATON_ITEM_MODE_SUPPLY = 1;
    public static int STATON_ITEM_MODE_DEMAND = 2;

    public static bool hasRecipe(int item_id)
    {
        if (item_id == 2303 || item_id == 2304 || item_id == 2305
            || item_id == 2302 || item_id == 2315 || item_id==2310
            || item_id == 2901||item_id == 2309 || item_id == 2308)
        {
            return true;
        }
        return false;
    }

    public static bool isBelt(int item_id)
    {
        if (item_id == 2001 || item_id == 2002 || item_id == 2003)
        {
            return true;
        }
        return false;
    }

    public static bool isSorter(int item_id)
    {
        if (item_id == 2011 || item_id == 2012 || item_id == 2013)
        {
            return true;
        }
        return false;
    }

    public static bool isStation(int item_id)
    {
        if (item_id == 2103 || item_id == 2104)
        {
            return true;
        }
        return false;
    }

    public static bool isGalaxyStation(int item_id)
    {
        return (item_id == 2104);
    }

    public static List<int> getItemIds()
    {
        List<int> ids = new List<int>();
        foreach (var item in items)
        {
            ids.Add(item.Key);
        }
        return ids;
    }

    public static List<string> getItemsAsString()
    {
        List<string> ids = new List<string>();
        foreach (var item in items)
        {
            ids.Add(item.Key + "," + item.Value);
        }
        return ids;
    }

    public static string getItemAsString(int item_id)
    {
        foreach (var item in items)
        {
            if (item.Key == item_id)
            {
                return item.Key + "," + item.Value;
            }
        }
        return "";
    }

    public static List<string> getRecipesAsString()
    {
        List<string> ids = new List<string>();
        foreach (var recipe in recipes)
        {
            ids.Add(recipe.Key + "," + recipe.Value);
        }
        return ids;
    }

    public static string getRecipeAsString(int recipe_id)
    {
        foreach (var recipe in recipes)
        {
            if (recipe.Key == recipe_id)
            {
                return recipe.Key + "," + recipe.Value;
            }
        }
        return "";
    }

    private static void InitRecipes()
    {
        string lang = System.Globalization.CultureInfo.CurrentCulture.Name.ToLower();
        if (lang == "zh-cn")
        {
            recipes.Add(0, "空");
            recipes.Add(1, "铁块");
            recipes.Add(2, "磁铁");
            recipes.Add(3, "铜块");
            recipes.Add(4, "石材");
            recipes.Add(5, "齿轮");
            recipes.Add(6, "磁线圈");
            recipes.Add(7, "风力涡轮机");
            recipes.Add(8, "电力感应塔");
            recipes.Add(9, "电磁矩阵");
            recipes.Add(10, "矩阵研究站");
            recipes.Add(11, "棱镜");
            recipes.Add(12, "电浆激发器");
            recipes.Add(13, "无线输电塔");
            recipes.Add(14, "原油萃取站");
            recipes.Add(15, "原油精炼厂");
            recipes.Add(16, "等离子精炼");
            recipes.Add(17, "高能石墨");
            recipes.Add(18, "能量矩阵");
            recipes.Add(19, "液氢燃料棒");
            recipes.Add(20, "推进器");
            recipes.Add(21, "加力推进器");
            recipes.Add(22, "化工厂");
            recipes.Add(23, "塑料");
            recipes.Add(24, "硫酸");
            recipes.Add(25, "有机晶体");
            recipes.Add(26, "钛晶石");
            recipes.Add(27, "结构矩阵");
            recipes.Add(28, "卡西米尔晶体");
            recipes.Add(29, "卡西米尔晶体（高效）");
            recipes.Add(30, "钛化玻璃");
            recipes.Add(31, "石墨烯");
            recipes.Add(32, "石墨烯（高效）");
            recipes.Add(33, "碳纳米管");
            recipes.Add(34, "硅石");
            recipes.Add(35, "碳纳米管（高效）");
            recipes.Add(36, "粒子宽带");
            recipes.Add(37, "晶格硅");
            recipes.Add(38, "位面过滤器");
            recipes.Add(39, "微型粒子对撞机");
            recipes.Add(40, "重氢");
            recipes.Add(41, "氘核燃料棒");
            recipes.Add(42, "湮灭约束球");
            recipes.Add(43, "人造恒星");
            recipes.Add(44, "反物质燃料棒");
            recipes.Add(45, "制造台 Mk.I");
            recipes.Add(46, "制造台 Mk.II");
            recipes.Add(47, "制造台 Mk.III");
            recipes.Add(48, "采矿机");
            recipes.Add(49, "抽水站");
            recipes.Add(50, "电路板");
            recipes.Add(51, "处理器");
            recipes.Add(52, "量子芯片");
            recipes.Add(53, "微晶元件");
            recipes.Add(54, "有机晶体（原始）");
            recipes.Add(55, "信息矩阵");
            recipes.Add(56, "电弧熔炉");
            recipes.Add(57, "玻璃");
            recipes.Add(58, "X射线裂解");
            recipes.Add(59, "高纯硅块");
            recipes.Add(60, "金刚石");
            recipes.Add(61, "金刚石（高效）");
            recipes.Add(62, "晶格硅（高效）");
            recipes.Add(63, "钢材");
            recipes.Add(64, "火力发电厂");
            recipes.Add(65, "钛块");
            recipes.Add(66, "钛合金");
            recipes.Add(67, "太阳能板");
            recipes.Add(68, "光子合并器");
            recipes.Add(69, "光子合并器（高效）");
            recipes.Add(70, "太阳帆");
            recipes.Add(71, "电磁轨道弹射器");
            recipes.Add(72, "射线接收站");
            recipes.Add(73, "卫星配电站");
            recipes.Add(74, "质能储存");
            recipes.Add(75, "宇宙矩阵");
            recipes.Add(76, "蓄电器");
            recipes.Add(77, "能量枢纽");
            recipes.Add(78, "空间翘曲器");
            recipes.Add(79, "空间翘曲器（高级）");
            recipes.Add(80, "框架材料");
            recipes.Add(81, "戴森球组件");
            recipes.Add(82, "垂直发射井");
            recipes.Add(83, "小型运载火箭");
            recipes.Add(84, "传送带");
            recipes.Add(85, "分拣器");
            recipes.Add(86, "小型储物仓");
            recipes.Add(87, "四向分流器");
            recipes.Add(88, "高速分拣器");
            recipes.Add(89, "高速传送带");
            recipes.Add(90, "极速分拣器");
            recipes.Add(91, "大型储物仓");
            recipes.Add(92, "极速传送带");
            recipes.Add(93, "行星内物流运输站");
            recipes.Add(94, "物流运输机");
            recipes.Add(95, "星际物流运输站");
            recipes.Add(96, "星际物流运输船");
            recipes.Add(97, "电动机");
            recipes.Add(98, "电磁涡轮");
            recipes.Add(99, "粒子容器");
            recipes.Add(100, "粒子容器（高效）");
            recipes.Add(101, "引力透镜");
            recipes.Add(102, "引力矩阵");
            recipes.Add(103, "超级磁场环");
            recipes.Add(104, "奇异物质");
            recipes.Add(106, "增产剂 Mk.I");
            recipes.Add(107, "增产剂 Mk.II");
            recipes.Add(108, "增产剂 Mk.III");
            recipes.Add(109, "喷涂机");
            recipes.Add(110, "分馏塔");
            recipes.Add(111, "轨道采集器");
            recipes.Add(112, "地基");
            recipes.Add(113, "微型聚变发电站");
            recipes.Add(114, "储液罐");
            recipes.Add(115, "重氢分馏");
            recipes.Add(116, "位面熔炉");
            recipes.Add(117, "流速监测器");
            recipes.Add(118, "地热发电站");
            recipes.Add(119, "大型采矿机");
            recipes.Add(120, "自动集装机");
        }
        else
        {
            recipes.Add(0, "Empty");
            recipes.Add(1, "Iron ingot");
            recipes.Add(2, "Magnet");
            recipes.Add(3, "Copper ingot");
            recipes.Add(4, "Stone brick");
            recipes.Add(5, "Gear");
            recipes.Add(6, "Magnetic coil");
            recipes.Add(7, "Wind turbine");
            recipes.Add(8, "Tesla tower");
            recipes.Add(9, "Electromagnetic matrix");
            recipes.Add(10, "Matrix lab");
            recipes.Add(11, "Prism");
            recipes.Add(12, "Plasma exciter");
            recipes.Add(13, "Wireless power tower");
            recipes.Add(14, "Oil extractor");
            recipes.Add(15, "Oil refinery");
            recipes.Add(16, "Plasma refining");
            recipes.Add(17, "Energetic graphite");
            recipes.Add(18, "Energy matrix");
            recipes.Add(19, "Hydrogen fuel rod");
            recipes.Add(20, "Thruster");
            recipes.Add(21, "Reinforced thruster");
            recipes.Add(22, "Chemical plant");
            recipes.Add(23, "Plastic");
            recipes.Add(24, "Sulfuric acid");
            recipes.Add(25, "Organic crystal");
            recipes.Add(26, "Titanium crystal");
            recipes.Add(27, "Structure matrix");
            recipes.Add(28, "Casimir crystal");
            recipes.Add(29, "Casimir crystal (advanced)");
            recipes.Add(30, "Titanium glass");
            recipes.Add(31, "Graphene");
            recipes.Add(32, "Graphene (advanced)");
            recipes.Add(33, "Carbon nanotube");
            recipes.Add(34, "Silicon ore");
            recipes.Add(35, "Carbon nanotube (advanced)");
            recipes.Add(36, "Particle broadband");
            recipes.Add(37, "Crystal silicon");
            recipes.Add(38, "Plane filter");
            recipes.Add(39, "Miniature particle collider");
            recipes.Add(40, "Deuterium");
            recipes.Add(41, "Deuteron fuel rod");
            recipes.Add(42, "Annihilation constraint sphere");
            recipes.Add(43, "Artificial star");
            recipes.Add(44, "Antimatter fuel rod");
            recipes.Add(45, "Assembling machine Mk.I");
            recipes.Add(46, "Assembling machine Mk.II");
            recipes.Add(47, "Assembling machine Mk.III");
            recipes.Add(48, "Mining machine");
            recipes.Add(49, "Water pump");
            recipes.Add(50, "Circuit board");
            recipes.Add(51, "Processor");
            recipes.Add(52, "Quantum chip");
            recipes.Add(53, "Microcrystalline component");
            recipes.Add(54, "Organic crystal (original)");
            recipes.Add(55, "Information matrix");
            recipes.Add(56, "Arc Smelter");
            recipes.Add(57, "Glass");
            recipes.Add(58, "X-ray cracking");
            recipes.Add(59, "High-purity silicon");
            recipes.Add(60, "Diamond");
            recipes.Add(61, "Diamond (advanced)");
            recipes.Add(62, "Crystal silicon (advanced)");
            recipes.Add(63, "Steel");
            recipes.Add(64, "Thermal power plant");
            recipes.Add(65, "Titanium ingot");
            recipes.Add(66, "Titanium alloy");
            recipes.Add(67, "Solar panel");
            recipes.Add(68, "Photon combiner");
            recipes.Add(69, "Photon combiner (advanced)");
            recipes.Add(70, "Solar sail");
            recipes.Add(71, "EM-Rail Ejector");
            recipes.Add(72, "Ray receiver");
            recipes.Add(73, "Satellite substation");
            recipes.Add(74, "Mass-energy storage");
            recipes.Add(75, "Universe matrix");
            recipes.Add(76, "Accumulator");
            recipes.Add(77, "Energy exchanger");
            recipes.Add(78, "Space warper");
            recipes.Add(79, "Space warper (advanced)");
            recipes.Add(80, "Frame material");
            recipes.Add(81, "Dyson sphere component");
            recipes.Add(82, "Vertical launching silo");
            recipes.Add(83, "Small carrier rocket");
            recipes.Add(84, "Conveyor belt MK.I");
            recipes.Add(85, "Sorter MK.I");
            recipes.Add(86, "Storage MK.I");
            recipes.Add(87, "Splitter");
            recipes.Add(88, "Sorter MK.II");
            recipes.Add(89, "Conveyor belt MK.II");
            recipes.Add(90, "Sorter MK.III");
            recipes.Add(91, "Storage MK.II");
            recipes.Add(92, "Conveyor belt MK.III");
            recipes.Add(93, "Planetary Logistics Station");
            recipes.Add(94, "Logistics drone");
            recipes.Add(95, "Interstellar Logistics Station");
            recipes.Add(96, "Logistics vessel");
            recipes.Add(97, "Electric motor");
            recipes.Add(98, "Electromagnetic turbine");
            recipes.Add(99, "Particle container");
            recipes.Add(100, "Particle container (advanced)");
            recipes.Add(101, "Graviton lens");
            recipes.Add(102, "Gravity matrix");
            recipes.Add(103, "Super-magnetic ring");
            recipes.Add(104, "Strange matter");
            recipes.Add(106, "Proliferator Mk.I");
            recipes.Add(107, "Proliferator Mk.II");
            recipes.Add(108, "Proliferator Mk.III");
            recipes.Add(109, "Spray coater");
            recipes.Add(110, "Fractionator");
            recipes.Add(111, "Orbital Collector");
            recipes.Add(112, "Foundation");
            recipes.Add(113, "Mini fusion power plant");
            recipes.Add(114, "Storage tank");
            recipes.Add(115, "Deuterium fractionation");
            recipes.Add(116, "Plane Smelter");
            recipes.Add(117, "Traffic monitor");
            recipes.Add(118, "Geothermal power station");
            recipes.Add(119, "Advanced mining machine");
            recipes.Add(120, "Automatic piler");
        }
        /*
        recipes = recipes.OrderBy(p => p.Key).ToDictionary(o => o.Key, p => p.Value); ;
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe.Key + "=" + recipe.Value);
        }
        */
    }

    private static void InitItems()
    {
        string lang = System.Globalization.CultureInfo.CurrentCulture.Name.ToLower();
        if (lang == "zh-cn")
        {
            items.Add(0, "空");
            items.Add(1000, "水");
            items.Add(1001, "铁矿");
            items.Add(1002, "铜矿");
            items.Add(1003, "硅石");
            items.Add(1004, "钛石");
            items.Add(1005, "石矿");
            items.Add(1006, "煤矿");
            items.Add(1007, "原油");
            items.Add(1011, "可燃冰");
            items.Add(1012, "金伯利矿石");
            items.Add(1013, "分形硅石");
            items.Add(1014, "光栅石");
            items.Add(1015, "刺笋结晶");
            items.Add(1016, "单极磁石");
            items.Add(1030, "木材");
            items.Add(1031, "植物燃料");
            items.Add(1101, "铁块");
            items.Add(1102, "磁铁");
            items.Add(1103, "钢材");
            items.Add(1104, "铜块");
            items.Add(1105, "高纯硅块");
            items.Add(1106, "钛块");
            items.Add(1107, "钛合金");
            items.Add(1108, "石材");
            items.Add(1109, "高能石墨");
            items.Add(1110, "玻璃");
            items.Add(1111, "棱镜");
            items.Add(1112, "金刚石");
            items.Add(1113, "晶格硅");
            items.Add(1114, "精炼油");
            items.Add(1115, "塑料");
            items.Add(1116, "硫酸");
            items.Add(1117, "有机晶体");
            items.Add(1118, "钛晶石");
            items.Add(1119, "钛化玻璃");
            items.Add(1120, "氢");
            items.Add(1121, "重氢");
            items.Add(1122, "反物质");
            items.Add(1123, "石墨烯");
            items.Add(1124, "碳纳米管");
            items.Add(1125, "框架材料");
            items.Add(1126, "卡西米尔晶体");
            items.Add(1127, "奇异物质");
            items.Add(1131, "地基");
            items.Add(1141, "加速剂Mk.I");
            items.Add(1142, "加速剂Mk.II");
            items.Add(1143, "加速剂Mk.III");
            items.Add(1201, "齿轮");
            items.Add(1202, "磁线圈");
            items.Add(1203, "电动机");
            items.Add(1204, "电磁涡轮");
            items.Add(1205, "超级磁场环");
            items.Add(1206, "粒子容器");
            items.Add(1208, "临界光子");
            items.Add(1209, "引力透镜");
            items.Add(1210, "空间翘曲器");
            items.Add(1301, "电路板");
            items.Add(1302, "微晶元件");
            items.Add(1303, "处理器");
            items.Add(1304, "位面过滤器");
            items.Add(1305, "量子芯片");
            items.Add(1401, "电浆激发器");
            items.Add(1402, "粒子宽带");
            items.Add(1403, "湮灭约束球");
            items.Add(1404, "光子合并器");
            items.Add(1405, "推进器");
            items.Add(1406, "加力推进器");
            items.Add(1501, "太阳帆");
            items.Add(1502, "戴森球组件");
            items.Add(1503, "小型运载火箭");
            items.Add(1801, "液氢燃料棒");
            items.Add(1802, "氘核燃料棒");
            items.Add(1803, "反物质燃料棒");
            items.Add(2001, "传送带");
            items.Add(2002, "高速传送带");
            items.Add(2003, "极速传送带");
            items.Add(2011, "分拣器");
            items.Add(2012, "高速分拣器");
            items.Add(2013, "极速分拣器");
            items.Add(2020, "四向分流器");
            items.Add(2030, "流速监测器");
            items.Add(2040, "自动集装机");
            items.Add(2101, "小型储物仓");
            items.Add(2102, "大型储物仓");
            items.Add(2103, "行星内物流运输站");
            items.Add(2104, "星际物流运输站");
            items.Add(2105, "轨道采集器");
            items.Add(2106, "储液罐");
            items.Add(2201, "电力感应塔");
            items.Add(2202, "无线输电塔");
            items.Add(2203, "风力涡轮机");
            items.Add(2204, "火力发电厂");
            items.Add(2205, "太阳能板");
            items.Add(2206, "蓄电器");
            items.Add(2207, "蓄电器（满）");
            items.Add(2208, "射线接收站");
            items.Add(2209, "能量枢纽");
            items.Add(2210, "人造恒星");
            items.Add(2211, "微型聚变发电站");
            items.Add(2212, "卫星配电站");
            items.Add(2213, "地热发电站");
            items.Add(2301, "采矿机");
            items.Add(2302, "电弧熔炉");
            items.Add(2303, "制造台Mk.I");
            items.Add(2304, "制造台Mk.II");
            items.Add(2305, "制造台Mk.III");
            items.Add(2306, "抽水站");
            items.Add(2307, "原油萃取站");
            items.Add(2308, "原油精炼厂");
            items.Add(2309, "化工厂");
            items.Add(2310, "微型粒子对撞机");
            items.Add(2311, "电磁轨道弹射器");
            items.Add(2312, "垂直发射井");
            items.Add(2313, "喷涂机");
            items.Add(2314, "分馏塔");
            items.Add(2315, "位面熔炉");
            items.Add(2316, "大型采矿机");
            items.Add(2901, "矩阵研究站");
            items.Add(5001, "物流运输机");
            items.Add(5002, "星际物流运输船");
            items.Add(6001, "电磁矩阵");
            items.Add(6002, "能量矩阵");
            items.Add(6003, "结构矩阵");
            items.Add(6004, "信息矩阵");
            items.Add(6005, "引力矩阵");
            items.Add(6006, "宇宙矩阵");
        }
        else
        {
            items.Add(1000, "Empty");
            items.Add(1000, "Water");
            items.Add(1001, "Iron ore");
            items.Add(1002, "Copper ore");
            items.Add(1003, "Silicon ore");
            items.Add(1004, "Titanium ore");
            items.Add(1005, "Stone");
            items.Add(1006, "Coal");
            items.Add(1007, "Crude oil");
            items.Add(1011, "Fire ice");
            items.Add(1012, "Kimberlite ore");
            items.Add(1013, "Fractal silicon");
            items.Add(1014, "Optical grating crystal");
            items.Add(1015, "Spiniform stalagmite crystal");
            items.Add(1016, "Unipolar magnet");
            items.Add(1030, "Log");
            items.Add(1031, "Plant fuel");
            items.Add(1101, "Iron ingot");
            items.Add(1102, "Magnet");
            items.Add(1103, "Steel");
            items.Add(1104, "Copper ingot");
            items.Add(1105, "High-purity silicon");
            items.Add(1106, "Titanium ingot");
            items.Add(1107, "Titanium alloy");
            items.Add(1108, "Stone brick");
            items.Add(1109, "Energetic graphite");
            items.Add(1110, "Glass");
            items.Add(1111, "Prism");
            items.Add(1112, "Diamond");
            items.Add(1113, "Crystal silicon");
            items.Add(1114, "Refined oil");
            items.Add(1115, "Plastic");
            items.Add(1116, "Sulfuric acid");
            items.Add(1117, "Organic crystal");
            items.Add(1118, "Titanium crystal");
            items.Add(1119, "Titanium glass");
            items.Add(1120, "Hydrogen");
            items.Add(1121, "Deuterium");
            items.Add(1122, "Antimatter");
            items.Add(1123, "Graphene");
            items.Add(1124, "Carbon nanotube");
            items.Add(1125, "Frame material");
            items.Add(1126, "Casimir crystal");
            items.Add(1127, "Strange matter");
            items.Add(1131, "Foundation");
            items.Add(1141, "Proliferator (Accelerant) Mk.I");
            items.Add(1142, "Proliferator (Accelerant) Mk.II");
            items.Add(1143, "Proliferator (Accelerant) Mk.III");
            items.Add(1201, "Gear");
            items.Add(1202, "Magnetic coil");
            items.Add(1203, "Electric motor");
            items.Add(1204, "Electromagnetic turbine");
            items.Add(1205, "Super-magnetic ring");
            items.Add(1206, "Particle container");
            items.Add(1208, "Critical photon");
            items.Add(1209, "Graviton lens");
            items.Add(1210, "Space warper");
            items.Add(1301, "Circuit board");
            items.Add(1302, "Microcrystalline component");
            items.Add(1303, "Processor");
            items.Add(1304, "Plane filter");
            items.Add(1305, "Quantum chip");
            items.Add(1401, "Plasma exciter");
            items.Add(1402, "Particle broadband");
            items.Add(1403, "Annihilation constraint sphere");
            items.Add(1404, "Photon combiner");
            items.Add(1405, "Thruster");
            items.Add(1406, "Reinforced thruster");
            items.Add(1501, "Solar sail");
            items.Add(1502, "Dyson sphere component");
            items.Add(1503, "Small carrier rocket");
            items.Add(1801, "Hydrogen fuel rod");
            items.Add(1802, "Deuteron fuel rod");
            items.Add(1803, "Antimatter fuel rod");
            items.Add(2001, "Conveyor belt MK.I");
            items.Add(2002, "Conveyor belt MK.II");
            items.Add(2003, "Conveyor belt MK.III");
            items.Add(2011, "Sorter MK.I");
            items.Add(2012, "Sorter MK.II");
            items.Add(2013, "Sorter MK.III");
            items.Add(2020, "Splitter(4-direction)");
            items.Add(2030, "Traffic Monitor");
            items.Add(2040, "Automatic Piler");
            items.Add(2101, "Storage MK.I");
            items.Add(2102, "Storage MK.II");
            items.Add(2103, "Planetary Logistics Station");
            items.Add(2104, "Interstellar Logistics Station");
            items.Add(2105, "Orbital Collector");
            items.Add(2106, "Storage tank");
            items.Add(2201, "Tesla tower");
            items.Add(2202, "Wireless power tower");
            items.Add(2203, "Wind turbine");
            items.Add(2204, "Thermal power station");
            items.Add(2205, "Solar panel");
            items.Add(2206, "Accumulator");
            items.Add(2207, "Accumulator(full)");
            items.Add(2208, "Ray receiver");
            items.Add(2209, "Energy exchanger");
            items.Add(2210, "Artificial star");
            items.Add(2211, "Mini fusion power station");
            items.Add(2212, "Satellite substation");
            items.Add(2213, "Geothermal Power Station");
            items.Add(2301, "Mining machine");
            items.Add(2302, "Smelter");
            items.Add(2303, "Assembling machine Mk.I");
            items.Add(2304, "Assembling machine Mk.II");
            items.Add(2305, "Assembling machine Mk.III");
            items.Add(2306, "Water pump");
            items.Add(2307, "Oil extractor");
            items.Add(2308, "Oil refinery");
            items.Add(2309, "Chemical plant");
            items.Add(2310, "Miniature particle collider");
            items.Add(2311, "EM-Rail Ejector");
            items.Add(2312, "Vertical launching silo");
            items.Add(2313, "Spray coater");
            items.Add(2314, "Fractionator");
            items.Add(2315, "Plane smelter");
            items.Add(2316, "Advanced Mining Machine");
            items.Add(2901, "Matrix lab");
            items.Add(5001, "Logistics drone");
            items.Add(5002, "Logistics vessel");
            items.Add(6001, "Electromagnetic matrix");
            items.Add(6002, "Energy matrix");
            items.Add(6003, "Structure matrix");
            items.Add(6004, "Information matrix");
            items.Add(6005, "Gravity matrix");
            items.Add(6006, "Universe matrix");
        }
        /*
        items = items.OrderBy(p => p.Key).ToDictionary(o => o.Key, p => p.Value); ;
        foreach (var item in items)
        {
            Console.WriteLine(item.Key + "=" + item.Value);
        }
        */
    }

    static Config()
    {
        InitItems();
        InitRecipes();
    }
}

