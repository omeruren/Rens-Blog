﻿using RensBlog.Domain.Entities.Common;

namespace RensBlog.Domain.Entities;

public class Message : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string MessageBody { get; set; }
    public bool IsRead { get; set; }


}
