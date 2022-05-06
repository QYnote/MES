/*Info_CategoryGroup 생성*/
Create Table Info_CategoryGroup
(

GroupCode	VARCHAR(10) NOT NULL UNIQUE PRIMARY KEY ,
Level TINYINT,
HighGroup VARCHAR(10),
GroupName VARCHAR(100),
UseYn CHAR(1),
CreDt			DATETIME,
CreID			VARCHAR(100),
CreIP			VARCHAR(15),
ModDt			DATETIME,
ModID			VARCHAR(100),
ModIP			VARCHAR(15)

);

alter table Info_CategoryGroup modify column GroupName VARCHAR(100) after GroupCode;
alter table Info_CategoryGroup modify column GroupCOde VARCHAR(15);
alter table Info_CategoryGroup modify column HighGroup VARCHAR(15);


/*Info_CategoryItem 수정 22-05-06*/
alter Table Info_CategoryItem Modify Column CateCode VARCHAR(10);
alter Table Info_CategoryItem drop Column level;
alter Table Info_CategoryItem change Column HighCate GroupCode VARCHAR(10);
alter table Info_CategoryItem drop Column CateCode;
alter table Info_CategoryItem add Column CateCode VARCHAR(10);
alter Table Info_CategoryItem Modify Column CateCode VARCHAR(10) first;
alter Table Info_CategoryItem Modify Column CateValue VARCHAR(10) after CateCode;
alter Table Info_CategoryItem Modify Column GroupCode VARCHAR(10) first;



