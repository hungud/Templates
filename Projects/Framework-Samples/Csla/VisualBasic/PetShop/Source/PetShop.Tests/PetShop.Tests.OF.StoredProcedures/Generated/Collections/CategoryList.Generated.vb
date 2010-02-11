'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'CategoryList.vb.
'
'     Template: EditableRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

<Serializable()> _
<Csla.Server.ObjectFactory(FactoryNames.CategoryListFactoryName)> _
Public Partial Class CategoryList 
    Inherits BusinessListBase(Of CategoryList, Category)

    #Region "Contructor(s)"
    
    Private Sub New()
        AllowNew = true
    End Sub
    
    #End Region

    #Region "Factory Methods"

    Public Shared Function NewList() As CategoryList
        Return DataPortal.Create(Of CategoryList)()
    End Function

    Public Shared Function GetByCategoryId(ByVal categoryId As System.String) As CategoryList 
        Dim criteria As New CategoryCriteria()
		criteria.CategoryId = categoryId

        Return DataPortal.Fetch(Of CategoryList)(criteria)
    End Function

    Public Shared Function GetAll() As CategoryList
        Return DataPortal.Fetch(Of CategoryList)(New CategoryCriteria())
    End Function

    #End Region

    #Region "Properties"

    Protected Overrides Function AddNewCore() As Object
        Dim item As Category = PetShop.Tests.OF.StoredProcedures.Category.NewCategory()
        Me.Add(item)
        Return item
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As CategoryCriteria) As Boolean
        Return PetShop.Tests.OF.StoredProcedures.Category.Exists(criteria)
    End Function

    #End Region

        #Region "Property overrides"

        ''' <summary>
        ''' Returns true if any children are dirty
        ''' </summary>
        Public Shadows ReadOnly Property IsDirty() As Boolean
            Get
                For Each item As Category In Me.Items
                    If item.IsDirty Then
                        Return True
                    End If
                Next
        
                Return False
            End Get
        End Property

        #End Region

End Class