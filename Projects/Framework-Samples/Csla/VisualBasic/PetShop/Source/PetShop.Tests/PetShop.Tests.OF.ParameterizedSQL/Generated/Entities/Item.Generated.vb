'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Item.vb.
'
'     Template: SwitchableObject.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data
Imports Csla.Validation

<Serializable()> _
<Csla.Server.ObjectFactory(FactoryNames.ItemFactoryName)> _
Public Partial Class Item 
    Inherits BusinessBase(Of Item)

    #Region "Contructor(s)"

    Private Sub New()
        ' require use of factory method 
    End Sub

    Private Sub New(ByVal itemId As System.String)
        Using(BypassPropertyChecks)
           LoadProperty(_itemIdProperty, itemId)
        End Using
    End Sub

    #End Region
    #Region "Validation Rules"

    Protected Overrides Sub AddBusinessRules()

        If AddBusinessValidationRules() Then Exit Sub

        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _itemIdProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_itemIdProperty, 10))
        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _productIdProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_productIdProperty, 10))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_statusProperty, 2))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_nameProperty, 80))
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_imageProperty, 80))
    End Sub

    #End Region

    #Region "Properties"

    
    Private Shared ReadOnly _itemIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.ItemId)
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property ItemId() As System.String
        Get 
            Return GetProperty(_itemIdProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_itemIdProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _productIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.ProductId)
    Public Property ProductId() As System.String
        Get 
            Return GetProperty(_productIdProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_productIdProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _listPriceProperty As PropertyInfo(Of System.Nullable(Of System.Decimal)) = RegisterProperty(Of System.Nullable(Of System.Decimal))(Function(p As Item) p.ListPrice)
    Public Property ListPrice() As System.Nullable(Of System.Decimal)
        Get 
            Return GetProperty(_listPriceProperty)
        End Get
        Set (ByVal value As System.Nullable(Of System.Decimal))
            SetProperty(_listPriceProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _unitCostProperty As PropertyInfo(Of System.Nullable(Of System.Decimal)) = RegisterProperty(Of System.Nullable(Of System.Decimal))(Function(p As Item) p.UnitCost)
    Public Property UnitCost() As System.Nullable(Of System.Decimal)
        Get 
            Return GetProperty(_unitCostProperty)
        End Get
        Set (ByVal value As System.Nullable(Of System.Decimal))
            SetProperty(_unitCostProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _supplierProperty As PropertyInfo(Of System.Nullable(Of System.Int32)) = RegisterProperty(Of System.Nullable(Of System.Int32))(Function(p As Item) p.Supplier)
    Public Property Supplier() As System.Nullable(Of System.Int32)
        Get 
            Return GetProperty(_supplierProperty)
        End Get
        Set (ByVal value As System.Nullable(Of System.Int32))
            SetProperty(_supplierProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _statusProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.Status)
    Public Property Status() As System.String
        Get 
            Return GetProperty(_statusProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_statusProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _nameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.Name)
    Public Property Name() As System.String
        Get 
            Return GetProperty(_nameProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_nameProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _imageProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.Image)
    Public Property Image() As System.String
        Get 
            Return GetProperty(_imageProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_imageProperty, value)
        End Set
    End Property
    
    'ManyToOne
    Private Shared ReadOnly _productMemberProperty As PropertyInfo(Of Product) = RegisterProperty(Of Product)(Function(p As Item) p.ProductMember, Csla.RelationshipTypes.Child)
    Public ReadOnly Property ProductMember() As Product
        Get
            If Not(FieldManager.FieldExists(_productMemberProperty))
                Dim criteria As New PetShop.Tests.OF.ParameterizedSQL.ProductCriteria()
                criteria.ProductId = ProductId
                
                If (Me.IsNew Or Not PetShop.Tests.OF.ParameterizedSQL.Product.Exists(criteria)) Then
                    LoadProperty(_productMemberProperty, PetShop.Tests.OF.ParameterizedSQL.Product.NewProduct())
                Else
                    LoadProperty(_productMemberProperty, PetShop.Tests.OF.ParameterizedSQL.Product.GetByProductId(ProductId))
                End If
            End If
            
            Return GetProperty(_productMemberProperty) 
        End Get
    End Property
    
    'ManyToOne
    Private Shared ReadOnly _supplierMemberProperty As PropertyInfo(Of Supplier) = RegisterProperty(Of Supplier)(Function(p As Item) p.SupplierMember, Csla.RelationshipTypes.Child)
    Public ReadOnly Property SupplierMember() As Supplier
        Get
            If Not(FieldManager.FieldExists(_supplierMemberProperty))
                Dim criteria As New PetShop.Tests.OF.ParameterizedSQL.SupplierCriteria()
                criteria.SuppId = Supplier.Value
                
                If (Me.IsNew Or Not PetShop.Tests.OF.ParameterizedSQL.Supplier.Exists(criteria)) Then
                    LoadProperty(_supplierMemberProperty, PetShop.Tests.OF.ParameterizedSQL.Supplier.NewSupplier())
                Else
                    LoadProperty(_supplierMemberProperty, PetShop.Tests.OF.ParameterizedSQL.Supplier.GetBySuppId(Supplier.Value))
                End If
            End If
            
            Return GetProperty(_supplierMemberProperty) 
        End Get
    End Property
    
    #End Region

    #Region "Root Factory Methods"

    Public Shared Function NewItem() As Item 
        Return DataPortal.Create(Of Item)()
    End Function

    Public Shared Function GetByItemId(ByVal itemId As System.String) As Item 
        Dim criteria As New ItemCriteria ()
        criteria.ItemId = itemId

        Return DataPortal.Fetch(Of Item)(criteria)
    End Function

    Public Shared Function GetByProductIdItemIdListPriceName(ByVal productId As System.String, ByVal itemId As System.String, ByVal listPrice As System.Nullable(Of System.Decimal), ByVal name As System.String) As Item 
        Dim criteria As New ItemCriteria ()
        criteria.ProductId = productId
		criteria.ItemId = itemId
		criteria.ListPrice = listPrice.Value
		criteria.Name = name

        Return DataPortal.Fetch(Of Item)(criteria)
    End Function

    Public Shared Function GetByProductId(ByVal productId As System.String) As Item 
        Dim criteria As New ItemCriteria ()
        criteria.ProductId = productId

        Return DataPortal.Fetch(Of Item)(criteria)
    End Function

    Public Shared Function GetBySupplier(ByVal supplier As System.Nullable(Of System.Int32)) As Item 
        Dim criteria As New ItemCriteria ()
        criteria.Supplier = supplier.Value

        Return DataPortal.Fetch(Of Item)(criteria)
    End Function

    Public Shared Sub DeleteItem(ByVal itemId As System.String)
        DataPortal.Delete(New ItemCriteria (itemId))
    End Sub

    #End Region

    #Region "Child Factory Methods"

    Friend Shared Function NewItemChild() As Item
        Return DataPortal.CreateChild(Of Item)()
    End Function

    Friend Shared Function GetByItemIdChild(ByVal itemId As System.String) As Item 
        Dim criteria As New ItemCriteria ()
        criteria.ItemId = itemId

        Return DataPortal.FetchChild(Of Item)(criteria)
    End Function

    Friend Shared Function GetByProductIdItemIdListPriceNameChild(ByVal productId As System.String, ByVal itemId As System.String, ByVal listPrice As System.Nullable(Of System.Decimal), ByVal name As System.String) As Item 
        Dim criteria As New ItemCriteria ()
        criteria.ProductId = productId
        criteria.ItemId = itemId
        criteria.ListPrice = listPrice
        criteria.Name = name

        Return DataPortal.FetchChild(Of Item)(criteria)
    End Function

    Friend Shared Function GetByProductIdChild(ByVal productId As System.String) As Item 
        Dim criteria As New ItemCriteria ()
        criteria.ProductId = productId

        Return DataPortal.FetchChild(Of Item)(criteria)
    End Function

    Friend Shared Function GetBySupplierChild(ByVal supplier As System.Nullable(Of System.Int32)) As Item 
        Dim criteria As New ItemCriteria ()
        criteria.Supplier = supplier

        Return DataPortal.FetchChild(Of Item)(criteria)
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As ItemCriteria ) As Boolean
        Return ExistsCommand.Execute(criteria)
    End Function

    #End Region

        #Region "Property overrides"

        ''' <summary>
        ''' Returns true if the business object or any of its children properties are dirty.
        ''' </summary>
        Public Overloads Overrides ReadOnly Property IsDirty() As Boolean
            Get
                If MyBase.IsDirty Then
                    Return True
                End If

                If ProductMember.IsDirty Then
                    Return True
                End If
                If SupplierMember.IsDirty Then
                    Return True
                End If
                Return False
            End Get
        End Property

        #End Region


End Class