//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.8.X CodeSmith Templates.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'CategoryList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.Collections.EditableRoot
{
    [Serializable]
    public partial class CategoryList : BusinessListBase< CategoryList, Category >
    {    
        #region Contructor(s)
        
        private CategoryList()
        { 
            AllowNew = true;
        }
        
        #endregion

        #region Factory Methods 
        
        public static CategoryList NewList()
        {
            return DataPortal.Create< CategoryList >();
        }

        public static CategoryList GetByCategoryId(System.String categoryId)
        {
            return DataPortal.Fetch< CategoryList >(
                new CategoryCriteria{CategoryId = categoryId});
        }

        public static CategoryList GetAll()
        {
            return DataPortal.Fetch< CategoryList >(new CategoryCriteria());
        }

        #endregion

        #region Properties
        
        protected override object AddNewCore()
        {
            Category item = PetShop.Tests.Collections.EditableRoot.Category.NewCategory();
            Add(item);
            return item;
        }
        
        #endregion

        #region Exists Command

        public static bool Exists(CategoryCriteria criteria)
        {
            return Category.Exists(criteria);
        }

        #endregion
    }
}