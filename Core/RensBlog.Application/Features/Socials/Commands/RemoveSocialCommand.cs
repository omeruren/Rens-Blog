using MediatR;
using RensBlog.Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.Socials.Commands
{
    public record RemoveSocialCommand(Guid Id) : IRequest<BaseResult<object>>;
    
}
