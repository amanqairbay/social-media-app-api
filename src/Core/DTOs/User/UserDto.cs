﻿namespace Core.DTOs.User
{
    /// <summary>
    /// Represents the user data transfer object
    /// </summary>
    public class UserDto
	{
        public long Id { get; set; }
		public string Email { get; set; } = String.Empty;
		public string Token { get; set; } = String.Empty;

        public string Name { get; set; } = String.Empty;
		public string Surname { get; set; } = String.Empty;

        public DateTime DateOfBirth { get; set; } = default!;
        public DateTime Created { get; set; } = default!;
        public DateTime LastActive { get; set; } = default!;

        public string Interests { get; set; } = String.Empty;

        public string Gender { get; set; } = String.Empty;
        public long? GenderId { get; set; }

        public string Status { get; set; } = String.Empty;
        public long? StatusId { get; set; }

        public string City { get; set; } = String.Empty;
        public long? CityId { get; set; }
        
        public string Region { get; set; } = String.Empty;
        public long? RegionId { get; set; }

        public string PhotoUrl { get; set; } = String.Empty;
    }
}

