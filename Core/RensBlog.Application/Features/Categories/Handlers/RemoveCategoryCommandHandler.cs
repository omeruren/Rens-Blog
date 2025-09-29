using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Categories.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Categories.Handlers;

public class RemoveCategoryCommandHandler(IRepository<Category> _repository, IUnitOfWork _unitOfWork) : IRequestHandler<RemoveCategoryCommand, BaseResult<bool>>
{
    public async Task<BaseResult<bool>> Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _repository.GetByIdAsync(request.Id);

        if (category == null)
        {
            return BaseResult<bool>.Fail("Category not found");
        }
        _repository.Delete(category);
        var response = await _unitOfWork.SaveChangesAsync();

        return response ? BaseResult<bool>.Success(response) : BaseResult<bool>.Fail("Category could not be deleted");
    }
}
