using Core.Entities;

namespace Core.Specifications
{
    public class RegionWithCitySpecification : BaseSpecification<RegionCityJunction>
	{
		public RegionWithCitySpecification(long? cityId) : base(rc => cityId == null || rc.CityId == cityId)
		{
			AddInclude(rc => rc.Region);
			AddInclude(rc => rc.City);
		}
	}
}

