﻿using Core.DataAccess.Abstrats.Core.DataAccess;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    internal interface IOfferDal: IEntityRepository<Offer>
    {
    }
}
