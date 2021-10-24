using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HW8_21
{
    class Storage
    {
        private Dictionary<string, double> dictonary = new Dictionary<string, double>();

        public Storage(Product[] product)
        {
            for (int i = 0; i < product.Length; i++)
            {
                dictonary.Add(product[i].Name, product[i].Price);
            }

        }


        public string gotFirst(Dictionary<string, double> dictonary2)
        {
            string res = null;
            foreach (var item in dictonary2)
            {
                if (!dictonary.ContainsKey(item.Key))
                {
                    res += item.ToString() + "\n";
                }
            }
            return res;
        }


        public string gotFirst(Storage storage2)
        {
            string res = null;
            foreach (var item in storage2.dictonary)
            {
                if (!dictonary.ContainsKey(item.Key))
                {
                    res += item.ToString() + "\n";
                }
            }
            return res;
        }



        public string HasTwo(Storage storage2, Program.More_or_Less del)
        {
            string res = null;
            int st1 = dictonary.Count;
            int st2 = storage2.dictonary.Count;
            if (del(st1, st2))
            {
                foreach (var item in storage2.dictonary)
                {
                    if (dictonary.ContainsKey(item.Key))
                    {
                        //res += item.Key + "   " + item.Value + "\n";
                        res += item.ToString()+"\n";
                    }
                }
            }
            else
            {
                foreach (var item in dictonary)
                {
                    if (storage2.dictonary.ContainsKey(item.Key))
                    {
                        //res += item.Key + "   " + item.Value + "\n";
                        res += item.ToString() + "\n";
                    }
                }
            }

            return res;
        }




        public Dictionary<string, double> Get()
        {
            return dictonary;
        }


    }

}
