using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        // Lớp này có tác dụng cung cấp khả năng giải phóng tài nguyên (dispose)
        // khi đối tượng không còn cần thiết

        private bool _isDisposed;

        ~Disposable()
        {
            Dispose(false); // Chỉ giải phóng tài nguyên không được quản lý
        }

        public void Dispose()
        {
            Dispose(true); 
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed && disposing)
            {
                DisposeCore();
            }
            _isDisposed = true; // Đánh dấu là đã dispose

        }


        protected virtual void DisposeCore()
        {
        }

    }
}
