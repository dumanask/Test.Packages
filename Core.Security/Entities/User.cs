﻿using Core.Persistence.Repositories;
using Core.Security.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Entities;

public class User<TId> : Entity<TId>
{
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public AuthenticatorType AuthenticatorType { get; set; }

    public User()
    {
        Email = string.Empty;
        PasswordHash = Array.Empty<byte>();
        PasswordSalt = Array.Empty<byte>();
    }

    public User(string email, byte[] passwordSalt, byte[] passwordHash, AuthenticatorType authenticatorType)
    {
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        AuthenticatorType = authenticatorType;
    }

    public User(TId id, string email, byte[] passwordSalt, byte[] passwordHash, AuthenticatorType authenticatorType)
        : base(id)
    {
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        AuthenticatorType = authenticatorType;
    }
}
