using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDemoConsole
{
    public class Stores
    {
        private List<Store> stores;

        public List<Store> GetFilteredStores(Func<Store, bool> filter) { 
            var filteredStores = stores.Where(filter);
            return filteredStores.ToList();
        }

        public Stores(List<Store> stores) { 
            this.stores = stores;
        }

    }
}
