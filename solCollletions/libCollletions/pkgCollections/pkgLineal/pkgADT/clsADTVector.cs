using LibCollections.pkgServices.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCollections.pkgServices.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTVector<T> : clsADTLineal<T>, iADTVector<T> where T : IComparable<T>
    {
        #region Attributes
        int attCapacity=100;
        T[] attItems = new T[100];
        bool attItsFlexible = false;
        int attGrowingFactor = 100;
        #endregion
        #region Operations
        #region Getters
        public int opGetCapacity()
        {
            throw new NotImplementedException();
        }
        public int opGetAvalibleCapacity()
        {
            throw new NotImplementedException();
        }
        public int opGetGrowingFactor()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Setters
        public bool opSetGrowingFactor(int prmValue)
        {
            throw new NotImplementedException();
        }
        public bool opSetCapacity(int prmValue)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Query
        public bool opItsFull()
        {
            throw new NotImplementedException();
        }
        public bool opItsFlexible()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Builders
        public clsADTVector()
        {
            throw new NotImplementedException();
        }
        public clsADTVector(int Capacity)
        {
            throw new NotImplementedException();
        }
        #endregion 
        #endregion
       
    }
}
