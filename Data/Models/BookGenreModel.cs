namespace SkillFactory.Data.Models
{
    public class BookGenreModel
    {
        public int Id { get; set; }
        public string Name { get; }
        public BookGenreModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}