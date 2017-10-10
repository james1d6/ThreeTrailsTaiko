DROP PROC usp_SelectSlideShowByAlias
GO

CREATE PROC usp_SelectSlideShowByAlias (
	@Alias nvarchar(100)
) AS
BEGIN
	
	SELECT 
		ss.*, s.*
	
	FROM SlideShow ss
	
	JOIN Slide s
		ON ss.SlideShowID = s.SlideShowID
	
	WHERE ss.Alias = @Alias
	
	ORDER BY s.SortOrder, s.SlideID
END
GO