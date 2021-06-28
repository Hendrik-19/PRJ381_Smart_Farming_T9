Create database SmartFarmingDB
Use SmartFarmingDB
go

Create Schema SFSchema

go

Create Table SFSchema.Locations
(
LocationID int identity (1,1) primary key,
CropLocation nvarchar (60),
CropID int,
Constraint FK_SFSchema_Crops foreign key (CropID) references SFSchema.Crops (CropID)
)


Create Table SFSchema.Crops
(
CropID  int identity (1,1) primary key,
CropName nvarchar(50),
LocationID int foreign key references SFSchema.Locations (LocationID)
)