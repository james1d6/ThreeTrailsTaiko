using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThreeTrailsTaiko.Contracts.DataModels;

namespace ThreeTrailsTaiko.Contracts.Repositories
{
    public interface ISlideShowRepository
    {
		ISlideShow GetSlideShowByAlias(string alias);
    }
}
