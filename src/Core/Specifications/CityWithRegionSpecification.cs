using Core.Entities;

namespace Core.Specifications
{
    public class CityWithRegionSpecification : BaseSpecification<RegionCityJunction>
	{
		public CityWithRegionSpecification(long? regionId) : base(cr => regionId == null || cr.RegionId == regionId)
		{
			AddInclude(rc => rc.Region);
			AddInclude(rc => rc.City);
		}
	}
}

