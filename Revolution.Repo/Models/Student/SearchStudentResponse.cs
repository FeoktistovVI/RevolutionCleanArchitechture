using PublishingHouse.Interfaces.Extensions.Pagination;

namespace Revolution.Repo.Models.Student;

public class SearchStudentResponse : IPaginationResponse<StudentShortModel>
{
    public Page Page { get; set; } = new Page();
    public long Count { get; set; }
    public IReadOnlyCollection<StudentShortModel> Items { get; set; }
}