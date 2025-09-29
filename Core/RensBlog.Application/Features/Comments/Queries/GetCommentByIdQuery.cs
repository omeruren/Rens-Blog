using MediatR;
using RensBlog.Application.Base;
using RensBlog.Application.Features.Comments.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Comments.Queries;

public record GetCommentByIdQuery(Guid Id) : IRequest<BaseResult<GetCommentByIdQueryResult>>;
