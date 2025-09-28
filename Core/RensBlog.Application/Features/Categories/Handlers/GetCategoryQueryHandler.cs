using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Categories.Queries;
using RensBlog.Application.Features.Categories.Result;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Categories.Handlers;

public class GetCategoryQueryHandler(IRepository<Category> _repository, IMapper _mapper) : IRequestHandler<GetCategoryQuery, BaseResult<List<GetCategoryQueryResult>>>
{
    public async Task<BaseResult<List<GetCategoryQueryResult>>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        var categories = await _repository.GetAllAsync();
        var response = _mapper.Map<List<GetCategoryQueryResult>>(categories);
        return BaseResult<List<GetCategoryQueryResult>>.Success(response);
    }
}
