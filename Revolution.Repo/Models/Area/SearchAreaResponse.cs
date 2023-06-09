using PublishingHouse.Interfaces.Extensions.Pagination;

namespace Revolution.Repo.Models.Area;

public class SearchAreaResponse : IPaginationResponse<AreaShortModel>
{
    public Page Page { get; set; } = new Page();
    public long Count { get; set; }
    public IReadOnlyCollection<AreaShortModel> Items { get; set; }
}