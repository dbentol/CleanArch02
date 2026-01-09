namespace CleanArch02.Domain.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        // Foreign Key for Budget
        public int BudgetId { get; set; }
    }
}