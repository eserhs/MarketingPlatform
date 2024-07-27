﻿using Core.Entities.Concretes;
using Core.Utilites.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);


    }
}
