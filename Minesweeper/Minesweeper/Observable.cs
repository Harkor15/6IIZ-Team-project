using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Observable<T>
    {
        public event EventHandler<T> Handler;

        public void Event(T e) => Handler?.Invoke(this, e);
    }
}
