using SQLite;

namespace TAndCal.Model
{
    public class StudentModel
    {
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int RollNo { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
    }
}
