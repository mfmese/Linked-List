using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public interface ILinkedList
    {
        void Display();

        void Append(object data);

        void Prepend(object data);

        void InsertBeforeValue(object data, object value);

        void InsertAfterValue(object data, object value);

        void InsertBeforePosition(object data, int position);

        void InsertAfterPosition(object data, int position);

        void Delete(object data);

        void DeleteAtPosition(int position);

        void DeleteFirst();

        void DeleteLast();

        int Length();

        bool Search(object data);
    }
}
