DROP PROC usp_UpsertVenue
GO

CREATE PROC usp_UpsertVenue
(
	@VenueID int = null,
	@Name nvarchar(200) = null,
	@Description nvarchar(max) = null,
	@Street nvarchar(200) = null,
	@City nvarchar(200) = null,
	@State varchar(10) = null,
	@PostalCode nvarchar(50) = null,
	@WebsiteUrl nvarchar(max) = null,
	@MapUrl nvarchar(max) = null,
	@IsDeleted bit = 0
) AS
BEGIN	

	if (@VenueID is null)
	begin
		insert Venue
		([Name], [Description], Street, City, [State], PostalCode, WebsiteUrl, MapUrl, IsDeleted)
		values
		(@Name, @Description, @Street, @City, @State, @PostalCode, @WebsiteUrl, @MapUrl, @IsDeleted)
	end
	else begin
		update Venue
		set
			[Name] = COALESCE(@Name, [Name]),
			[Description] = COALESCE(@Description, [Description]),
			Street = COALESCE(@Street, Street),
			City = COALESCE(@City, City),
			[State] = COALESCE(@State, [State]),
			PostalCode = COALESCE(@PostalCode, PostalCode),
			WebsiteUrl = COALESCE(@WebsiteUrl, WebsiteUrl),
			MapUrl = COALESCE(@MapUrl, MapUrl),
			IsDeleted = COALESCE(@IsDeleted, IsDeleted)
		where VenueID = @VenueID
	end

END
GO

