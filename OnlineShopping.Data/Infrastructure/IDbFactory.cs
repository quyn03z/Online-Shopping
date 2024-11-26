using OnlineShopping.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Infrastructure
{
    // IDbFactory là một lớp hoặc interface thường được sử dụng trong các ứng dụng để quản lý vòng đời của các đối tượng DbContext trong Entity Framework
    public interface IDbFactory
    {
        OnlineShoppingContext Init();
    }

}
