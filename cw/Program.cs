using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace cw
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new object());
            arrayList.Add("da");
            arrayList.Add(321);
            //arrayList[2];


            Hashtable hashtable = new Hashtable();
            hashtable.Add('a', "первая буква алфавита");
            bool isContainsKey = hashtable.ContainsKey('a');
            bool isContainsValue = hashtable.ContainsValue("sfsg");
            hashtable.Remove('a');
            //hashtable['a'];


            Queue queue = new Queue();

            Stack stack = new Stack();

            List<int> dow = new List<int>();
            dow.Add((int)Enum.Home);

        }

        public enum Enum
        {
             Work,
             Home,
             Uni
        }
    }

    
}
