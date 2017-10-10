DROP PROC usp_SelectPerformance
GO

CREATE PROC usp_SelectPerformance
(
	@PerformanceID int = null
) AS BEGIN

select p.*, v.[Name] as VenueName
from Performance p

join Venue v
	on p.VenueID = v.VenueID

where (
	@PerformanceID is null
	and p.IsDeleted = 0
)
or (
	@PerformanceID is not null
	and p.PerformanceID = @PerformanceID 
)

END
GO


