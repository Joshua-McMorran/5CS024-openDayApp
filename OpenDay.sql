/*Drop previous versions*/
DROP TABLE Staff;
DROP TABLE Users;
DROP TABLE Rooms;
DROP TABLE QR_Codes;
DROP TABLE Talks;
DROP TABLE QR_Codes_Users_FK

/*Create Staff*/
CREATE TABLE Staff(
staffID VARCHAR(6) CONSTRAINT PK_Staff PRIMARY KEY,
name VARCHAR2(30) NOT NULL,
email VARCHAR2(40) NOT NULL,
phone VARCHAR2(15) NULL
);

/*Insert into Staff*/  
INSERT INTO Staff VALUES
	('STF001', 'John Doe', 'john001@wlv.ac.uk', '00278188029');
 
/*Create Users*/
CREATE TABLE Users(
userID CHAR(6) CONSTRAINT PK_Users PRIMARY KEY,
firstName VARCHAR2(15) NOT NULL,
surnameName VARCHAR2(15) NOT NULL,
email VARCHAR2(50) NOT NULL,
phone VARCHAR(15) NOT NULL,
postCode VARCHAR (8) NULL,
dateScanned DATE
);
  
/*Insert into Users*/
INSERT INTO Users VALUES
	('USR001', 'Crash', 'Bandicoot', 'crash99@bandiscoot.com', '0123456789101112', 'WH123SD', TO_DATE('2000-10-10','YYYY/MM/DD'));

/*Create Rooms*/
CREATE TABLE Rooms(
roomID VARCHAR(6) CONSTRAINT PK_Rooms PRIMARY KEY,
roomNum VARCHAR2(6) NOT NULL
);

/*Insert into Rooms*/
INSERT INTO Athletes VALUES
	('ROM001', 'MI9289');

/*Create QR_Codes*/
CREATE TABLE QR_Codes(
codeID CHAR(6) CONSTRAINT PK_QR_Codes PRIMARY KEY,
codeName VARCHAR2(20) NOT NULL,
roomID  VARCHAR(6) CONSTRAINT FK_Rooms REFERENCES Rooms
);

/*Insert into QR_Codes*/
INSERT INTO QR_Codes VALUES
	('QRC001', 'GamesDev', 'ROM001'); 

/*Create Talks*/
CREATE TABLE Talks(
talkID NUMBER(6) CONSTRAINT PK_Talks PRIMARY KEY,
title VARCHAR2(50) NOT NULL,
roomID VARCHAR2(6) CONSTRAINT FK_Rooms REFERENCES Rooms
codeID NUMBER(6) CONSTRAINT FK_QR_Codes REFERENCES QR_Codes
);

/*Insert into Talks*/
INSERT INTO Talks VALUES
	('TLK001', 'GamesDevTalk', 'ROM001', 'QRC001');

/*Create QR_Codes_Users_FK*/
/* CREATE TABLE QR_Codes_Users_FK(
UserID    NUMBER (6) CONSTRAINT ,
QR_Codes_CodeID NUMBER (6) NOT NULL
);
ALTER TABLE QR_Codes_Users_FK ADD CONSTRAINT QR_Codes_Users_FK_PK PRIMARY KEY ( Users_UserID, QR_Codes_CodeID ) ; */

/*Insert into QR_Codes_Users_FK*/ 


/* ALTER TABLE QR_Codes_Users_FK ADD CONSTRAINT FK_ASS_1 FOREIGN KEY ( Users_UserID ) REFERENCES Users ( UserID ) ;

ALTER TABLE QR_Codes_Users_FK ADD CONSTRAINT FK_ASS_2 FOREIGN KEY ( QR_Codes_CodeID ) REFERENCES QR_Codes ( CodeID ) ; */