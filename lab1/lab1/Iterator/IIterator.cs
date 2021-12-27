using System;

namespace lab1.Iterator
{
    internal interface IIterator
    {
        bool HasNext();
        Object Next();

        Object Previous();
    }
}
