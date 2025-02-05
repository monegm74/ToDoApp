using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoDemo.Models
{
    public class TODO
    {
        public uint Id { get; set; }
        [Required(ErrorMessage = "Please enter a description.")]
        public string Description { get; set; } =string.Empty;

        [Required(ErrorMessage = "Please enter a due date.")]
        public DateTime? DueDate { get; set; }


        [Required(ErrorMessage = "Please enter a category.")]
        public string CategoryId { get; set; } = string.Empty;
        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; } = string.Empty;
        [ValidateNever]
        public Status Status { get; set; } = null!;
        public bool Overdue => StatusId == "open" && DueDate < DateTime.Today;

    }
}
