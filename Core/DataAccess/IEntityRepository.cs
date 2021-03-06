﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //Generic constraint -- generic kısıt
    //T : class  ==> referans tip
    // :IEntity ==> IEntity veya IEntity implemente eden bir nesne olabilir
    // : new() ==> newlenebilir bir nesne olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
