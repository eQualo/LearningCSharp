using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Indexers
{
    class Dictionary
    {
        private string[] value = new string[5];
        private string[] key = new string[5];
        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book";
            key[1] = "ручка"; value[1] = "pen";
            key[2] = "солнце"; value[2] = "sun";
            key[3] = "яблоко"; value[3] = "apple";
            key[4] = "стол"; value[4] = "table";
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < value.Length)
                    return key[index] + " - " + value[index];
                else
                    return "No index";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                        return "Translation of " + key[i] + " is " + value[i];
                    else
                        if (value[i] == index)
                            return "Translation of " + value[i] + " is " + key[i];
                    
                }
                return "No word";

            }
        }
    }
}
