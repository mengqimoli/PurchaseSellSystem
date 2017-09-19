--食品进销存销售系统
--SQL Server 2014

--数据库表
--用户表（UserTable）
--drop table UserTable
create table UserTable(
UserName nvarchar(50) not null,             --用户名
UserPwd nvarchar(50) not null,				--密码
primary key(UserName)						--主键（用户名）
)
select * from UserTable

--供应商货品汇总（GYSAllFood）
--drop table GYSAllFood	
create table GYSAllFood(
GYS nvarchar(50) not null,					--供应商
GYSFoodName nvarchar(50),					--商品名称
GYSFoodType nvarchar(50),					--商品类型
GYSDM decimal(10,2),						--商品单价
GYSDiscountL decimal(10,2),					--折扣率
GYSQuantity decimal(10,2),					--商家货存
GYSText nvarchar(50),						--备注
)
select * from GYSAllFood

--库存（KC）
--drop table KC
--delete from KC
create table KC(
KCGYS nvarchar(50),							--供应商
KCFoodName nvarchar(50),					--商品名称
KCFoodType nvarchar(50),					--商品类型
KCBM decimal(10,2),							--成本
KCSJ decimal(10,2),							--售价
KCQuantity decimal(10,2),					--仓库存货
)
select * from KC


--采购订单（CG）
--drop table CG
--delete from CG
create table CG(
OrderMum nvarchar(50),						--采购订单编号
CGTime date,								--采购日期
CGGYS nvarchar(50),							--供应商
CGFoodName nvarchar(50),					--商品名称
CGFoodType nvarchar(50),					--商品类型
CGDM decimal(10,2),							--购货单价
CGQuantity decimal(10,2),					--购货数量
CGDiscountL decimal(10,2),					--折扣率
CGDiscountM decimal(10,2),					--折扣额
CGAM decimal(10,2),							--购货金额
CGText nvarchar(50),						--备注
CGState nvarchar(50),						--状态
)
select * from CG

--入库单（RK）
--drop table RK
--delete from RK
create table RK(
RKNum nvarchar(50),							--入库编号
RKTime date,								--入库日期
RKGYS nvarchar(50),							--供应商
RKFoodName nvarchar(50),					--商品名称
RKFoodType nvarchar(50),					--商品类型
RKDM decimal(10,2),							--单价
RKQuantity decimal(10,2),					--入库数量
RKDiscountL decimal(10,2),					--折扣率
RKDiscountM decimal(10,2),					--折扣额
RKAM decimal(10,2),							--实付金额
RKText nvarchar(50)							--备注
)
select * from RK

--出库（CK）
--drop table CK
--delete from CK
create table CK(
CKNum nvarchar(50),							--出库编号
CKTime date,								--出库日期
CKGYS nvarchar(50),							--供应商
CKFoodName nvarchar(50),					--商品名称
CKFoodType nvarchar(50),					--商品类型
CKDM decimal(10,2),							--成本
CKSJ decimal(10,2),							--售价
CKQuantity decimal(10,2),					--数量
CKAM decimal(10,2),							--出售金额
CKLR decimal(10,2),							--利润
CKText nvarchar(50)							--备注
)
select * from CK 

--退货单（TH）
--drop table TH
--delete from TH
create table TH(
THNum nvarchar(50),							--退货单编号
THTime date,								--退货日期
THGYS nvarchar(50),							--供应商
THFoodName nvarchar(50),					--商品名称
THFoodType nvarchar(50),					--商品类型
THDM decimal(10,2),							--购货单价
THQuantity decimal(10,2),					--退货数量
THDiscountL decimal(10,2),					--折扣率
THDiscountM decimal(10,2),					--折扣额
THAM decimal(10,2),							--退货金额
THText nvarchar(50),						--备注
)
select * from TH

