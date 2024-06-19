using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Iterator
{
    internal class BufferIterator<T> : IEnumerator<(T, T)>
    {
        public (T, T) Current { get; private set; }

        object IEnumerator.Current => Current;

        private IEnumerator<T>? _enumerator;

        public BufferIterator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
            Reset();
        }

        public void Dispose()
        {
            _enumerator.Dispose();
            _enumerator = null;
            Current = default;
        }

        public bool MoveNext()
        {
            if(_enumerator.MoveNext())
            {
                Current = (Current.Item2, _enumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            Current = _enumerator.MoveNext() ? ((T, T))(default, _enumerator.Current) : default;
        }
    }
}
