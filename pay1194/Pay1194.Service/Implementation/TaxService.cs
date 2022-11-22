﻿using Microsoft.EntityFrameworkCore;
using Pay1194.Entity;
using Pay1194.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay1194.Service.Implementation
{
    public class TaxService : ITaxService
    {
        private decimal taxRate;
        private decimal tax;
        private readonly ApplicationDbContext _context;
        public TaxService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<TaxYear> GetAll()
        {
            return _context.TaxYears.ToList();
        }

        public decimal TaxAmount(decimal totalAmount)
        {
            if (totalAmount <= 1200)
            {
                taxRate = .0m;
                tax = totalAmount * taxRate;
            }
            else if (totalAmount > 1200 && totalAmount < 5000)
            {
                taxRate = .20m;
                tax = (1200 * .0m) + ((totalAmount - 1200) * taxRate);
            }
            else if (totalAmount > 5000 && totalAmount <= 15000)
            {
                taxRate = .40m;
                tax = (1200 * .0m) + ((5000 - 1200) * 0.20m) + ((totalAmount - 5000) * taxRate);
            }
            else if (totalAmount > 15000)
            {
                taxRate = .45m;
                tax = (1200 * .0m) + ((5000 - 1200) * 0.20m) + ((15000 - 5000) * .40m) + ((totalAmount - 15000) * taxRate);
            }
            return tax;
        }

        public TaxYear GetById(int id)
        {
            return _context.TaxYears.Where(TaxYear => TaxYear.Id == id).FirstOrDefault();
        }
    }
}
