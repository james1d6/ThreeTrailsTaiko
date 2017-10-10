IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Performance')
CREATE TABLE Performance
(
	PerformanceID int IDENTITY not null,
	VenueID int null,
	EventName nvarchar(200) not null,
	EventUrl nvarchar(max) null,
	[Description] nvarchar(max) null,
	StartDate date null,	
	StartTime time null,
	StartTime2 time null,
	IsDeleted bit not null default(0),
	PRIMARY KEY (PerformanceID)
)
GO

ALTER TABLE Performance ADD FOREIGN KEY (VenueID) REFERENCES Venue(VenueID)
ALTER TABLE Performance ADD IsPrivate bit not null default(0)
GO
