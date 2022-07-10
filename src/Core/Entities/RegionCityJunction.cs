namespace Core.Entities
{
	/// <summary>
    /// Represents region city junction
    /// </summary>
	public class RegionCityJunction : BaseEntity
	{
		/// <summary>
        /// Gets or sets the region
        /// </summary>
		public Region Region { get; set; } = default!;

		/// <summary>
        /// Gets or sets the region identifier
        /// </summary>
		public long RegionId { get; set; }

		/// <summary>
		/// Gets or sets the city
		/// </summary>
		public City City { get; set; } = default!;

		/// <summary>
		/// Gets or sets the city identifier
		/// </summary>
		public long CityId { get; set; }
	}
}

