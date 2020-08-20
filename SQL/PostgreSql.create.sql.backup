




CREATE TABLE Организация (

 primaryKey UUID NOT NULL,

 Наименование VARCHAR(255) NULL,

 Адрес VARCHAR(255) NULL,

 ИНН VARCHAR(255) NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE Застройщик (

 primaryKey UUID NOT NULL,

 Описание VARCHAR(255) NULL,

 ОрганизЗастр_m0 UUID NOT NULL,

 Разрешение_m0 UUID NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE РазрешНаСтроит (

 primaryKey UUID NOT NULL,

 Наименование VARCHAR(255) NULL,

 ВидРазрешения VARCHAR(13) NULL,

 Архив BOOLEAN NULL,

 ДатаРазрешения TIMESTAMP(3) NULL,

 НомерРазрешения INT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE ОбъектСтроит (

 primaryKey UUID NOT NULL,

 Наименование VARCHAR(255) NULL,

 Адрес VARCHAR(255) NULL,

 Разрешение_m0 UUID NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMNETLOCKDATA (

 LockKey VARCHAR(300) NOT NULL,

 UserName VARCHAR(300) NOT NULL,

 LockDate TIMESTAMP(3) NULL,

 PRIMARY KEY (LockKey));



CREATE TABLE STORMSETTINGS (

 primaryKey UUID NOT NULL,

 Module VARCHAR(1000) NULL,

 Name VARCHAR(255) NULL,

 Value TEXT NULL,

 "User" VARCHAR(255) NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMAdvLimit (

 primaryKey UUID NOT NULL,

 "User" VARCHAR(255) NULL,

 Published BOOLEAN NULL,

 Module VARCHAR(255) NULL,

 Name VARCHAR(255) NULL,

 Value TEXT NULL,

 HotKeyData INT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMFILTERSETTING (

 primaryKey UUID NOT NULL,

 Name VARCHAR(255) NOT NULL,

 DataObjectView VARCHAR(255) NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMWEBSEARCH (

 primaryKey UUID NOT NULL,

 Name VARCHAR(255) NOT NULL,

 "Order" INT NOT NULL,

 PresentView VARCHAR(255) NOT NULL,

 DetailedView VARCHAR(255) NOT NULL,

 FilterSetting_m0 UUID NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMFILTERDETAIL (

 primaryKey UUID NOT NULL,

 Caption VARCHAR(255) NOT NULL,

 DataObjectView VARCHAR(255) NOT NULL,

 ConnectMasterProp VARCHAR(255) NOT NULL,

 OwnerConnectProp VARCHAR(255) NULL,

 FilterSetting_m0 UUID NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE STORMFILTERLOOKUP (

 primaryKey UUID NOT NULL,

 DataObjectType VARCHAR(255) NOT NULL,

 Container VARCHAR(255) NULL,

 ContainerTag VARCHAR(255) NULL,

 FieldsToView VARCHAR(255) NULL,

 FilterSetting_m0 UUID NOT NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE UserSetting (

 primaryKey UUID NOT NULL,

 AppName VARCHAR(256) NULL,

 UserName VARCHAR(512) NULL,

 UserGuid UUID NULL,

 ModuleName VARCHAR(1024) NULL,

 ModuleGuid UUID NULL,

 SettName VARCHAR(256) NULL,

 SettGuid UUID NULL,

 SettLastAccessTime TIMESTAMP(3) NULL,

 StrVal VARCHAR(256) NULL,

 TxtVal TEXT NULL,

 IntVal INT NULL,

 BoolVal BOOLEAN NULL,

 GuidVal UUID NULL,

 DecimalVal DECIMAL(20,10) NULL,

 DateTimeVal TIMESTAMP(3) NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE ApplicationLog (

 primaryKey UUID NOT NULL,

 Category VARCHAR(64) NULL,

 EventId INT NULL,

 Priority INT NULL,

 Severity VARCHAR(32) NULL,

 Title VARCHAR(256) NULL,

 Timestamp TIMESTAMP(3) NULL,

 MachineName VARCHAR(32) NULL,

 AppDomainName VARCHAR(512) NULL,

 ProcessId VARCHAR(256) NULL,

 ProcessName VARCHAR(512) NULL,

 ThreadName VARCHAR(512) NULL,

 Win32ThreadId VARCHAR(128) NULL,

 Message VARCHAR(2500) NULL,

 FormattedMessage TEXT NULL,

 PRIMARY KEY (primaryKey));




 ALTER TABLE Застройщик ADD CONSTRAINT FK8c3af4533d934c66aaf28caf09167bf7 FOREIGN KEY (ОрганизЗастр_m0) REFERENCES Организация; 
CREATE INDEX Indexe269602e026b40eb725e048530c226638f54ca7e on Застройщик (ОрганизЗастр_m0); 

 ALTER TABLE Застройщик ADD CONSTRAINT FKabe2ddbea566492a81e67d776b552ff5 FOREIGN KEY (Разрешение_m0) REFERENCES РазрешНаСтроит; 
CREATE INDEX Indexc385e8a56a0f77a5bbdd47f857860847e1129610 on Застройщик (Разрешение_m0); 

 ALTER TABLE ОбъектСтроит ADD CONSTRAINT FK150b50dac0944ee4a33f8ec6842934a3 FOREIGN KEY (Разрешение_m0) REFERENCES РазрешНаСтроит; 
CREATE INDEX Indexe1d2aaa57078d7ce41c9c2d0f8010494b206123c on ОбъектСтроит (Разрешение_m0); 

 ALTER TABLE STORMWEBSEARCH ADD CONSTRAINT FKcb6bcbdfb0b7452d8b80d3802d2cc1df FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

 ALTER TABLE STORMFILTERDETAIL ADD CONSTRAINT FK95487fc44d3649299b93ef1548174ce1 FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

 ALTER TABLE STORMFILTERLOOKUP ADD CONSTRAINT FKf02fa1b2d2514b8ca0e9e1ae6557cb8e FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

