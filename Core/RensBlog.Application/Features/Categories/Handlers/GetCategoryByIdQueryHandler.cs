using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Categories.Queries;
using RensBlog.Application.Features.Categories.Results;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Categories.Handlers;

public class GetCategoryByIdQueryHandler(IRepository<Category> _repository, IMapper _mapper) : IRequestHandler<GetCategoryByIdQuery, BaseResult<GetCategoryByIdQueryResult>>
{
    public async Task<BaseResult<GetCategoryByIdQueryResult>> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var category = await _repository.GetByIdAsync(request.Id);

        if (category == null)
            return BaseResult<GetCategoryByIdQueryResult>.NotFound("Category Not Found");


        var response = _mapper.Map<GetCategoryByIdQueryResult>(category);

        return BaseResult<GetCategoryByIdQueryResult>.Success(response);
    }
}
