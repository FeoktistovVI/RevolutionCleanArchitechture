using PublishingHouse.Interfaces.Extensions.Pagination;

namespace Revolution.Repo.Models.Events;

public class SearchEventsResponse : IPaginationResponse<EventsShortModel>
{
    public Page Page { get; set; }
    public long Count { get; set; }
    public IReadOnlyCollection<EventsShortModel> Items { get; set; }
}