﻿using DMA_AU24_LAB2_Group4.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA_AU24_LAB2_Group4.Data.Repository
{
    public interface IConcertRepository : IRepository<Concert>
    {
        Task<bool> DoesItemExist(int id);
        Task<Concert?> Find(int id);
        void Update(Concert item);
        void Delete(int id);
    }
}