namespace N_Layer.Core.Models
{
    public class Team : BaseModel
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
