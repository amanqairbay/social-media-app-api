namespace Core.DTOs.User
{
	/// <summary>
    /// Represents the user for update data transfer object
    /// </summary>
	public class UserForUpdateDto
	{
        /// <summary>
        /// Gets or sets the email
        /// </summary>
        public string Email { get; set; } = String.Empty;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; } = String.Empty;

        /// <summary>
        /// Gets or sets the surname
        /// </summary>
		public string Surname { get; set; } = String.Empty;

        /// <summary>
        /// Gets or sets the date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; } = default!;

        /// <summary>
        /// Gets or sets the interests
        /// </summary>
        public string Interests { get; set; } = String.Empty;

        /// <summary>
        /// Gets or sets the gender identifier
        /// </summary>
        public long GenderId { get; set; }

        /// <summary>
        /// Gets or sets the status identifier
        /// </summary>
        public long StatusId { get; set; }

        /// <summary>
        /// Gets or sets the city identifier
        /// </summary>
        public long CityId { get; set; }

        /// <summary>
        /// Gets or sets the region identifier
        /// </summary>
        public long RegionId { get; set; }
    }
}

