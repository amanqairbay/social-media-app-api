
using Core.Entities;

namespace Core.DTOs
{
	public class PhotoForDetailedDto
	{
        public long Id { get; set; }
        public string Url { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime DateAdded { get; set; } = default!;
        public bool IsMain { get; set; } = default!;
    }
}

