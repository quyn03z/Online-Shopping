using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Infrastructure
{
    // UnitOfWork để quản lý các thao tác với cơ sở dữ liệu.
    public interface IUnitOfWork
    {
        void Commit();
    }
}
