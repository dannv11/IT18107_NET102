using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_2_1_GENERIC_CLASS
{
    internal class ClassGeneric<T>
    {
        // thêm thuộc tính cho class
        private T[] items;
        //Constructor
        public ClassGeneric(int size)
        {
            // Khởi tạo mảng Items T
            items = new T[size];
        }
        public T[] Items
        {
            get=> items;
            set => items = value;
        }
        // add thêm phần tử cho items
        public void addItemElement(int index,T element)
        {
            if(index<0 && index > items.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            items[index] = element;
        }
        // Phương thức lấy giá trị phần tử của item
        public T getItemElement(int index)
        {
            if (index < 0 && index > items.Length)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            return items[index];
        }


    }
}
