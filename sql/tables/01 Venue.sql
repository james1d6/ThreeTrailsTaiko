IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Venue')
CREATE TABLE Venue
(
	VenueID int IDENTITY not null,
	[Name] nvarchar(200) not null,
	[Description] nvarchar(max) not null,
	Street nvarchar(200) null,
	City nvarchar(200) null,
	[State] varchar(10) null,
	PostalCode nvarchar(50) null,
	WebsiteUrl nvarchar(max),
	MapUrl nvarchar(max),
	IsDeleted bit not null default(0),
	PRIMARY KEY (VenueID)
)
GO

