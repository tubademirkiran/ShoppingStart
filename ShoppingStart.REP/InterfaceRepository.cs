﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingStart.REP
{
    interface InterfaceRepository<T> where T:class,new()
    {
        DbSet<T> Set();
        void Sil(T entity);
        void Ekle(T entity);
        T Bul(int id);
        void Guncelle(T entity);
        void Save();
        List<T> Liste();
        IQueryable<T> GenelListe();
    }
}
