IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Slide')
CREATE TABLE Slide
(
	SlideID int IDENTITY not null,
	SlideShowID int null,
	ImagePath nvarchar(1000),
	Caption nvarchar(max),
	SortOrder int null,
	PRIMARY KEY (SlideID)
)
GO

ALTER TABLE Slide ADD FOREIGN KEY (SlideShowID) REFERENCES SlideShow(SlideShowID)
GO
