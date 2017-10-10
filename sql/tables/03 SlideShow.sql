IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'SlideShow')
CREATE TABLE SlideShow
(
	SlideShowID int IDENTITY not null,
	Alias nvarchar(100) not null,
	PRIMARY KEY (SlideShowID)
)
GO

ALTER TABLE SlideShow ADD [Width] int not null default(0)
ALTER TABLE SlideShow ADD [Height] int not null default(0)
GO
