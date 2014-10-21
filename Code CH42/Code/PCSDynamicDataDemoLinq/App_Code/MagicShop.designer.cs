﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.21006.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MagicShop")]
public partial class MagicShopDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCustomer(Customer instance);
  partial void UpdateCustomer(Customer instance);
  partial void DeleteCustomer(Customer instance);
  partial void InsertProduct(Product instance);
  partial void UpdateProduct(Product instance);
  partial void DeleteProduct(Product instance);
  partial void InsertOrder(Order instance);
  partial void UpdateOrder(Order instance);
  partial void DeleteOrder(Order instance);
  partial void InsertOrderItem(OrderItem instance);
  partial void UpdateOrderItem(OrderItem instance);
  partial void DeleteOrderItem(OrderItem instance);
  #endregion
	
	public MagicShopDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["MagicShopConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public MagicShopDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MagicShopDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MagicShopDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public MagicShopDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Customer> Customers
	{
		get
		{
			return this.GetTable<Customer>();
		}
	}
	
	public System.Data.Linq.Table<Product> Products
	{
		get
		{
			return this.GetTable<Product>();
		}
	}
	
	public System.Data.Linq.Table<Order> Orders
	{
		get
		{
			return this.GetTable<Order>();
		}
	}
	
	public System.Data.Linq.Table<OrderItem> OrderItems
	{
		get
		{
			return this.GetTable<OrderItem>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CustomerId;
	
	private string _Name;
	
	private string _Address;
	
	private EntitySet<Order> _Orders;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIdChanging(int value);
    partial void OnCustomerIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    #endregion
	
	public Customer()
	{
		this._Orders = new EntitySet<Order>(new Action<Order>(this.attach_Orders), new Action<Order>(this.detach_Orders));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int CustomerId
	{
		get
		{
			return this._CustomerId;
		}
		set
		{
			if ((this._CustomerId != value))
			{
				this.OnCustomerIdChanging(value);
				this.SendPropertyChanging();
				this._CustomerId = value;
				this.SendPropertyChanged("CustomerId");
				this.OnCustomerIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="Text", UpdateCheck=UpdateCheck.Never)]
	public string Address
	{
		get
		{
			return this._Address;
		}
		set
		{
			if ((this._Address != value))
			{
				this.OnAddressChanging(value);
				this.SendPropertyChanging();
				this._Address = value;
				this.SendPropertyChanged("Address");
				this.OnAddressChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Orders", ThisKey="CustomerId", OtherKey="CustomerId")]
	public EntitySet<Order> Orders
	{
		get
		{
			return this._Orders;
		}
		set
		{
			this._Orders.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Orders(Order entity)
	{
		this.SendPropertyChanging();
		entity.Customer = this;
	}
	
	private void detach_Orders(Order entity)
	{
		this.SendPropertyChanging();
		entity.Customer = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ProductId;
	
	private string _Name;
	
	private string _Description;
	
	private decimal _Cost;
	
	private EntitySet<OrderItem> _OrderItems;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnCostChanging(decimal value);
    partial void OnCostChanged();
    #endregion
	
	public Product()
	{
		this._OrderItems = new EntitySet<OrderItem>(new Action<OrderItem>(this.attach_OrderItems), new Action<OrderItem>(this.detach_OrderItems));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ProductId
	{
		get
		{
			return this._ProductId;
		}
		set
		{
			if ((this._ProductId != value))
			{
				this.OnProductIdChanging(value);
				this.SendPropertyChanging();
				this._ProductId = value;
				this.SendPropertyChanged("ProductId");
				this.OnProductIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="Text", UpdateCheck=UpdateCheck.Never)]
	public string Description
	{
		get
		{
			return this._Description;
		}
		set
		{
			if ((this._Description != value))
			{
				this.OnDescriptionChanging(value);
				this.SendPropertyChanging();
				this._Description = value;
				this.SendPropertyChanged("Description");
				this.OnDescriptionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Decimal(10,2) NOT NULL")]
	public decimal Cost
	{
		get
		{
			return this._Cost;
		}
		set
		{
			if ((this._Cost != value))
			{
				this.OnCostChanging(value);
				this.SendPropertyChanging();
				this._Cost = value;
				this.SendPropertyChanged("Cost");
				this.OnCostChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderItem", Storage="_OrderItems", ThisKey="ProductId", OtherKey="ProductId")]
	public EntitySet<OrderItem> OrderItems
	{
		get
		{
			return this._OrderItems;
		}
		set
		{
			this._OrderItems.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_OrderItems(OrderItem entity)
	{
		this.SendPropertyChanging();
		entity.Product = this;
	}
	
	private void detach_OrderItems(OrderItem entity)
	{
		this.SendPropertyChanging();
		entity.Product = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _OrderId;
	
	private int _CustomerId;
	
	private System.DateTime _OrderDate;
	
	private EntitySet<OrderItem> _OrderItems;
	
	private EntityRef<Customer> _Customer;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnCustomerIdChanging(int value);
    partial void OnCustomerIdChanged();
    partial void OnOrderDateChanging(System.DateTime value);
    partial void OnOrderDateChanged();
    #endregion
	
	public Order()
	{
		this._OrderItems = new EntitySet<OrderItem>(new Action<OrderItem>(this.attach_OrderItems), new Action<OrderItem>(this.detach_OrderItems));
		this._Customer = default(EntityRef<Customer>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int OrderId
	{
		get
		{
			return this._OrderId;
		}
		set
		{
			if ((this._OrderId != value))
			{
				this.OnOrderIdChanging(value);
				this.SendPropertyChanging();
				this._OrderId = value;
				this.SendPropertyChanged("OrderId");
				this.OnOrderIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", DbType="Int NOT NULL")]
	public int CustomerId
	{
		get
		{
			return this._CustomerId;
		}
		set
		{
			if ((this._CustomerId != value))
			{
				if (this._Customer.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCustomerIdChanging(value);
				this.SendPropertyChanging();
				this._CustomerId = value;
				this.SendPropertyChanged("CustomerId");
				this.OnCustomerIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderDate", DbType="DateTime2 NOT NULL")]
	public System.DateTime OrderDate
	{
		get
		{
			return this._OrderDate;
		}
		set
		{
			if ((this._OrderDate != value))
			{
				this.OnOrderDateChanging(value);
				this.SendPropertyChanging();
				this._OrderDate = value;
				this.SendPropertyChanged("OrderDate");
				this.OnOrderDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderItem", Storage="_OrderItems", ThisKey="OrderId", OtherKey="OrderId")]
	public EntitySet<OrderItem> OrderItems
	{
		get
		{
			return this._OrderItems;
		}
		set
		{
			this._OrderItems.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_Order", Storage="_Customer", ThisKey="CustomerId", OtherKey="CustomerId", IsForeignKey=true)]
	public Customer Customer
	{
		get
		{
			return this._Customer.Entity;
		}
		set
		{
			Customer previousValue = this._Customer.Entity;
			if (((previousValue != value) 
						|| (this._Customer.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Customer.Entity = null;
					previousValue.Orders.Remove(this);
				}
				this._Customer.Entity = value;
				if ((value != null))
				{
					value.Orders.Add(this);
					this._CustomerId = value.CustomerId;
				}
				else
				{
					this._CustomerId = default(int);
				}
				this.SendPropertyChanged("Customer");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_OrderItems(OrderItem entity)
	{
		this.SendPropertyChanging();
		entity.Order = this;
	}
	
	private void detach_OrderItems(OrderItem entity)
	{
		this.SendPropertyChanging();
		entity.Order = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OrderItem")]
public partial class OrderItem : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _OrderItemId;
	
	private int _OrderId;
	
	private int _ProductId;
	
	private int _Quantity;
	
	private EntityRef<Order> _Order;
	
	private EntityRef<Product> _Product;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderItemIdChanging(int value);
    partial void OnOrderItemIdChanged();
    partial void OnOrderIdChanging(int value);
    partial void OnOrderIdChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnQuantityChanging(int value);
    partial void OnQuantityChanged();
    #endregion
	
	public OrderItem()
	{
		this._Order = default(EntityRef<Order>);
		this._Product = default(EntityRef<Product>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderItemId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int OrderItemId
	{
		get
		{
			return this._OrderItemId;
		}
		set
		{
			if ((this._OrderItemId != value))
			{
				this.OnOrderItemIdChanging(value);
				this.SendPropertyChanging();
				this._OrderItemId = value;
				this.SendPropertyChanged("OrderItemId");
				this.OnOrderItemIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OrderId", DbType="Int NOT NULL")]
	public int OrderId
	{
		get
		{
			return this._OrderId;
		}
		set
		{
			if ((this._OrderId != value))
			{
				if (this._Order.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnOrderIdChanging(value);
				this.SendPropertyChanging();
				this._OrderId = value;
				this.SendPropertyChanged("OrderId");
				this.OnOrderIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL")]
	public int ProductId
	{
		get
		{
			return this._ProductId;
		}
		set
		{
			if ((this._ProductId != value))
			{
				if (this._Product.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnProductIdChanging(value);
				this.SendPropertyChanging();
				this._ProductId = value;
				this.SendPropertyChanged("ProductId");
				this.OnProductIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int NOT NULL")]
	public int Quantity
	{
		get
		{
			return this._Quantity;
		}
		set
		{
			if ((this._Quantity != value))
			{
				this.OnQuantityChanging(value);
				this.SendPropertyChanging();
				this._Quantity = value;
				this.SendPropertyChanged("Quantity");
				this.OnQuantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Order_OrderItem", Storage="_Order", ThisKey="OrderId", OtherKey="OrderId", IsForeignKey=true)]
	public Order Order
	{
		get
		{
			return this._Order.Entity;
		}
		set
		{
			Order previousValue = this._Order.Entity;
			if (((previousValue != value) 
						|| (this._Order.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Order.Entity = null;
					previousValue.OrderItems.Remove(this);
				}
				this._Order.Entity = value;
				if ((value != null))
				{
					value.OrderItems.Add(this);
					this._OrderId = value.OrderId;
				}
				else
				{
					this._OrderId = default(int);
				}
				this.SendPropertyChanged("Order");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_OrderItem", Storage="_Product", ThisKey="ProductId", OtherKey="ProductId", IsForeignKey=true)]
	public Product Product
	{
		get
		{
			return this._Product.Entity;
		}
		set
		{
			Product previousValue = this._Product.Entity;
			if (((previousValue != value) 
						|| (this._Product.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Product.Entity = null;
					previousValue.OrderItems.Remove(this);
				}
				this._Product.Entity = value;
				if ((value != null))
				{
					value.OrderItems.Add(this);
					this._ProductId = value.ProductId;
				}
				else
				{
					this._ProductId = default(int);
				}
				this.SendPropertyChanged("Product");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
#pragma warning restore 1591