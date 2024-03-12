using LibCollections.pkgServices.pkgCollections.pkgLineal.pkgADT;
using LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorQueue<T> : clsADTVector<T>, iQueue<T> where T : IComparable<T>
    {
        #region CRUDs
        public bool opPush(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPop(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opPeek(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Builders
        public clsVectorQueue(int capacity)
        {
            throw new NotImplementedException();
        }
        public clsVectorQueue()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
