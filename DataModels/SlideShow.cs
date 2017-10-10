using System.Collections.Generic;
using ThreeTrailsTaiko.Contracts.DataModels;

namespace ThreeTrailsTaiko.DataModels
{
	public class SlideShow : ISlideShow
	{
		public SlideShow()
		{
			Slides = new List<ISlide>();
		}

		public int SlideShowID { get; set; }
		public string Alias { get; set; }
		public List<ISlide> Slides { get; private set; }

	}
}


