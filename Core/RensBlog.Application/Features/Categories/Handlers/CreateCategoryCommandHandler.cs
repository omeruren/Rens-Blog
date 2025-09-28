using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Categories.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Categories.Handlers;

public class CreateCategoryCommandHandler(IRepository<Category> _repository, IUnitOfWork _unitOfWork, IMapper _mapper) : IRequestHandler<CreateCategoryCommand, BaseResult<object>>
{
    public async Task<BaseResult<object>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = _mapper.Map<Category>(request);

        await _repository.CrateAsync(category);

        await _unitOfWork.SaveChangesAsync();

        return BaseResult<object>.Success(category);
    }
}
