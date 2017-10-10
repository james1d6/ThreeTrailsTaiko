DROP PROC usp_SelectPastPerformances
GO

CREATE PROC usp_SelectPastPerformances AS
BEGIN

select p.*, 
v.[Name] as VenueName, 
v.[Description] as VenueDescription,	
v.Street as VenueStreet,
v.City as VenueCity,
v.[State] as VenueState,
v.PostalCode as VenuePostalCode,
v.WebsiteUrl as VenueWebsiteUrl,
v.MapUrl as VenueMapUrl,
v.IsDeleted as VenueIsDeleted

from Performance p

join Venue v
	on v.VenueID = p.VenueID

where p.StartDate < GETDATE()
and p.IsDeleted = 0
and p.IsPrivate = 0

order by StartDate, StartTime, StartTime2

END
GO
