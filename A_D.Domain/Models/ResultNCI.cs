namespace A_D.Domain.Models
{
    public class ResultNCI
    {
        public int Id { get; set; }
        public int ResultCategoryNCI_Id { get; set; }
        public string Name { get; set; }
        public ResultCategoryNCI ResultCategoryNCI { get; set; }
    }
}
