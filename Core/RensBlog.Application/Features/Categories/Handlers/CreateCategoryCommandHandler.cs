using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Categories.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Categories.Handlers;

internal class CreateCategoryCommandHandler(IRepository<Category> _repository, IUnitOfWork _unitOfWork, IMapper _mapper) : IRequestHandler<CreateCategoryCommand, BaseResult<bool>>
{
    public async Task<BaseResult<bool>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = _mapper.Map<Category>(request);

        await _repository.CrateAsync(category);

        var result = await _unitOfWork.SaveChangesAsync();

        return result ? BaseResult<bool>.Success(result) : BaseResult<bool>.Fail();
    }
}
