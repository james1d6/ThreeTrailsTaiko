DROP PROC usp_UpsertPerformance 
GO

CREATE PROC usp_UpsertPerformance 
(
	@PerformanceID int = null,
	@VenueID int = null,
	@EventName nvarchar(200) = null,
	@EventUrl nvarchar(max) = null,
	@Description nvarchar(max) = null,
	@StartDate date = null,	
	@StartTime time = null,
	@StartTime2 time = null,
	@IsDeleted bit = null
) AS
BEGIN

	if (@PerformanceID is null)
	begin
		insert Performance
		(VenueID, EventName, EventUrl, [Description], StartDate, StartTime, StartTime2, IsDeleted)
		values
		(@VenueID, @EventName, @EventUrl, @Description, @StartDate, @StartTime, @StartTime2, @IsDeleted)
	end
	else begin
		update Performance
		set
			VenueID = COALESCE(@VenueID, VenueID),
			EventName = COALESCE(@EventName, EventName),
			EventUrl = COALESCE(@EventUrl, EventUrl),
			[Description] = COALESCE(@Description, [Description]),
			StartDate = COALESCE(@StartDate, StartDate),
			StartTime = COALESCE(@StartTime, StartTime),
			--StartTime2 = COALESCE(@StartTime2, StartTime2),
			StartTime2 = @StartTime2,
			IsDeleted = COALESCE(@IsDeleted, IsDeleted)
		where PerformanceID = @PerformanceID
	end

END
GO
