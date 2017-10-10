using System.Collections.Generic;

namespace ThreeTrailsTaiko.Contracts.DataModels
{
	public interface ISlideShow
	{
		int SlideShowID { get; set; }
		string Alias { get; set; }
		List<ISlide> Slides { get; }
	}
}
