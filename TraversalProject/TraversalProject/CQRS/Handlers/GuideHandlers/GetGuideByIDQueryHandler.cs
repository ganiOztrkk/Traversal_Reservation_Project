using DataAccessLayer.Concrete;
using MediatR;
using TraversalProject.CQRS.Queries.GuideQueries;
using TraversalProject.CQRS.Results.GuideResults;

namespace TraversalProject.CQRS.Handlers.GuideHandlers;

public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
{
    private readonly Context _context;

    public GetGuideByIDQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
    {
        var values = await _context.Guides.FindAsync(request.Id);
        return new GetGuideByIDQueryResult
        {
            GuideID = values.GuideId,
            Description = values.Description,
            Name = values.Name
        };
    }
}