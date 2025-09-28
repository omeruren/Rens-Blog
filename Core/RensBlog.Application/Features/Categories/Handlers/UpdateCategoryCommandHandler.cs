using AutoMapper;
using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Contracts.Persistance;
using RensBlog.Application.Features.Categories.Commands;
using RensBlog.Domain.Entities;

namespace RensBlog.Application.Features.Categories.Handlers;

public class UpdateCategoryCommandHandler(IRepository<Category> _repository, IMapper _mapper, IUnitOfWork _unitOfWork) :
    IRequestHandler<UpdateCategoryCommand, BaseResult<bool>>
{
    public async Task<BaseResult<bool>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = _mapper.Map<Category>(request);
        _repository.Update(category);
        var response = await _unitOfWork.SaveChangesAsync();

        return response 
            ? BaseResult<bool>.Success(response) 
            : BaseResult<bool>.Fail("Category could not be updated");

    }
}
