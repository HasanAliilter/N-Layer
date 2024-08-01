namespace N_Layer.Core.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}
