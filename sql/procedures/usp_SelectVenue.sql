DROP PROC usp_SelectVenue 
GO

CREATE PROC usp_SelectVenue 
(
	@VenueID int = null
)AS BEGIN

select *
from Venue

where (
	@VenueID is null
	and IsDeleted = 0
)
or (
	@VenueID is not null
	and VenueID = @VenueID 
)
END
GO
