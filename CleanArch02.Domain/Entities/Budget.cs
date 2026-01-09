namespace CleanArch02.Domain.Entities
{
    public class Budget
    {
        public int Id { get; set; }
        public decimal TotalBudgetAmount { get; set; }
        public int SchoolId { get; set; }
        public int ProjectId { get; set; }

        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();

        public decimal UsedBudget => Teachers.Sum(t => t.Salary);

        // Helper property to see remaining funds
        public decimal RemainingBudget => TotalBudgetAmount - UsedBudget;
    }
}