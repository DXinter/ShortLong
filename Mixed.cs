using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLongShort
{
    class Mixed
    {
        public string ShortlongShort(string first, string second)
        {
            string result = "";
            if (first.Length == 1 && second.Length > 1)
            {
                result += first;
                result += second;
                result += first;
                return result;
            }
            if (first.Length > 1 && second.Length == 1)
            {
                result += second;
                result += first;
                result += second;
                return result;
            }
            else
                throw new Exception("Ошибка!\n Операция невозможна из-за отсуствия условий!");

                                                                  
        }
    }
}
