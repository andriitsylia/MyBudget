﻿using MyBudget.Models;
using System;
using System.Collections.Generic;

namespace MyBudget.Interfaces
{
    public interface IIncomeRepository
    {
        bool SaveChanges();
        IEnumerable<Income> GetAll();
        Income GetById(int id);
        IEnumerable<Income> GetByDate(DateTime beginDate, DateTime endDate);
        void Create(Income income);
        void Update(Income income);
        void Delete(Income income);
    }
}
