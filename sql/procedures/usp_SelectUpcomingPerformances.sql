DROP PROC usp_SelectUpcomingPerformances
GO

CREATE PROC usp_SelectUpcomingPerformances AS 
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

where p.StartDate >= GETDATE()
and p.IsDeleted = 0
and p.IsPrivate = 0

order by p.StartDate, p.StartTime

END
GO


