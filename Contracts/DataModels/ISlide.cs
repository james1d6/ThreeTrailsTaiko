namespace ThreeTrailsTaiko.Contracts.DataModels
{
	public interface ISlide
	{
		int SlideID { get; set; }
		int SlideShowID { get; set; }
		string ImagePath { get; set; }
		string Caption { get; set; }
		int SortOrder { get; set; }
	}
}
