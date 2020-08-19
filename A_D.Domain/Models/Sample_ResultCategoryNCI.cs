namespace A_D.Domain.Models
{
    public class Sample_ResultCategoryNCI
    {
        public int Id { get; set; }
        public int ResultCategoryNCI_Id { get; set; }
        public int Sample_Id { get; set; }
        public ResultCategoryNCI ResultCategoryNCI { get; set; }
        public Sample Sample { get; set; }
    }
}