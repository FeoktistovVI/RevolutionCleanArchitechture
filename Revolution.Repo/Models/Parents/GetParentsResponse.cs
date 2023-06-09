﻿using PublishingHouse.Interfaces.Extensions.Pagination;

namespace Revolution.Repo.Models.Parents
{

public class GetParentsResponse : IPaginationResponse<ParentsShortModel>
{
	public Page Page { get; set; } = new Page();

	public long Count { get; set; }

	public IReadOnlyCollection<ParentsShortModel> Items { get; set; }
}
}