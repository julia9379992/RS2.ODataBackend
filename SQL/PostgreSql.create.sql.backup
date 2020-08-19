




CREATE TABLE Организация (

 primaryKey UUID NOT NULL,

 Наименование VARCHAR(255) NULL,

 Адрес VARCHAR(255) NULL,

 ИНН VARCHAR(255) NULL,

 PRIMARY KEY (primaryKey));



CREATE TABLE Застройщик (

 primaryKey UUID NOT NULL,

 Основной BOOLEAN NULL,

 Застройщик_m0 UUID NOT NULL,

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




 ALTER TABLE Застройщик ADD CONSTRAINT FKf7c024d8f46a4852a94baa8abff4136f FOREIGN KEY (Застройщик_m0) REFERENCES Организация; 
CREATE INDEX Indexda6f9b1c29e5d0ced841f0cde1b726db41f9d428 on Застройщик (Застройщик_m0); 

 ALTER TABLE Застройщик ADD CONSTRAINT FKba80828c71514153bf2448b894595093 FOREIGN KEY (Разрешение_m0) REFERENCES РазрешНаСтроит; 
CREATE INDEX Indexc385e8a56a0f77a5bbdd47f857860847e1129610 on Застройщик (Разрешение_m0); 

 ALTER TABLE ОбъектСтроит ADD CONSTRAINT FK9a60d5e801d942598b87f7abcf71faf7 FOREIGN KEY (Разрешение_m0) REFERENCES РазрешНаСтроит; 
CREATE INDEX Indexe1d2aaa57078d7ce41c9c2d0f8010494b206123c on ОбъектСтроит (Разрешение_m0); 

 ALTER TABLE STORMWEBSEARCH ADD CONSTRAINT FKf520dc944b194be0882938df571c9f3f FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

 ALTER TABLE STORMFILTERDETAIL ADD CONSTRAINT FKe80ff60bfe614acebe380df2b3fdb474 FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

 ALTER TABLE STORMFILTERLOOKUP ADD CONSTRAINT FK9417ffa3fa4c4a62b3b765ab72679ec5 FOREIGN KEY (FilterSetting_m0) REFERENCES STORMFILTERSETTING; 

