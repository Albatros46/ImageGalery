namespace ImageGalery.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int ViewCount { get; set; }
        public bool isActive { get; set; } = true;

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
