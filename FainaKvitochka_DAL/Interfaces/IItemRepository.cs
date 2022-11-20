using FainaKvitochka_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_DAL.Interfaces
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetAllByPredicate(Expression<Func<Item, bool>> predicate);
    }
}
