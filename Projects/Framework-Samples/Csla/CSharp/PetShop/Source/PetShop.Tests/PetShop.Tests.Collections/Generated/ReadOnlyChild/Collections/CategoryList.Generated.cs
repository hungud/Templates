
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Category.cs'.
//
//     Template: ReadOnlyChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using Csla;

#endregion

namespace PetShop.Tests.Collections.ReadOnlyChild
{
    [Serializable]
    public partial class CategoryList : ReadOnlyListBase< CategoryList, Category >
    {
        #region Factory Methods 

        internal static CategoryList GetByCategoryId(System.String categoryId)
        {
            return DataPortal.FetchChild< CategoryList >(
                new CategoryCriteria{CategoryId = categoryId});
        }

        internal static CategoryList GetAll()
        {
            return DataPortal.FetchChild< CategoryList >(new CategoryCriteria());
        }

        #endregion

        #region Constructor(s)

        private CategoryList()
        { /* Require use of factory methods */ }
        
        #endregion

        #region Exists Command

        public static bool Exists(CategoryCriteria criteria)
        {
            return Category.Exists(criteria);
        }

        #endregion
    }
}