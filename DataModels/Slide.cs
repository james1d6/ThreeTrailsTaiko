using ThreeTrailsTaiko.Contracts.DataModels;

namespace ThreeTrailsTaiko.DataModels
{
	public class Slide : ISlide
	{
		public Slide() {}
		public int SlideID { get; set; }
		public int SlideShowID { get; set; }
		public string ImagePath { get; set; }
		public string Caption { get; set; }
		public int SortOrder { get; set; }
	}
}