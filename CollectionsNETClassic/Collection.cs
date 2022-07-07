using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNETClassic
{
    internal class Collection : CollectionBase
    {
        public void Add(Object item) 
        {
            InnerList.Add(item);      
        }


    }
}
