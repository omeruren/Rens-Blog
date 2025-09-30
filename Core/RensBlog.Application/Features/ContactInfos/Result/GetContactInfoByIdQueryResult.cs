using RensBlog.Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RensBlog.Application.Features.ContactInfos.Result
{
    public class GetContactInfoByIdQueryResult : BaseDto
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string MapUrl { get; set; }
    }
}
