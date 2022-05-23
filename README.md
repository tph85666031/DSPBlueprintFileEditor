**DSPBlueprintFileEditor**
---
*.Net Framework 4.5 required*

#### 1:batch set of all belt,sorter,assemble,smelter level and station param,批量修改运输站、所有传送带、分拣器、制造台、熔炉等级
#### 2:double click the item(station) to modify station info(1-5 items & capacity,charge power,warp distance ...) ,双击运输站修改其属性
#### 3:set recipe for assemle & smelter via list menu(multi-select supported),对选中设备右键菜单编辑生产配方(支持多选)

---
### Changelog:
**1.0.8:** 
* upload source code to github

**1.0.8:** 
* support editing all structures' position. 开放修改所有建筑的坐标
* support editing structure's angle.支持修改建筑偏转角度

**1.0.7:** 
* fix structure UI refresh bug. 修复建筑UI显示BUG 

**1.0.6:** 
* support editing structure's position(X,Y,Z).U can make special belt now.支持修改建筑坐标，方便自定义各种特殊传送带

**1.0.5:** 
* support setting station item storage mode: storage=0,supply=1,demand=2，支持修改物品的“需求，供应，仓储属性”
* support setting charge power up to 600，支持修改运输站最大充电功率至600Mw
* bug fix
