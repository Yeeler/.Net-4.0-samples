﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace Wrox.ProCSharp.EntityFramework
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PaymentsEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PaymentsEntities object using the connection string found in the 'PaymentsEntities' section of the application configuration file.
        /// </summary>
        public PaymentsEntities() : base("name=PaymentsEntities", "PaymentsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PaymentsEntities object.
        /// </summary>
        public PaymentsEntities(string connectionString) : base(connectionString, "PaymentsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PaymentsEntities object.
        /// </summary>
        public PaymentsEntities(EntityConnection connection) : base(connection, "PaymentsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Payment> Payments
        {
            get
            {
                if ((_Payments == null))
                {
                    _Payments = base.CreateObjectSet<Payment>("Payments");
                }
                return _Payments;
            }
        }
        private ObjectSet<Payment> _Payments;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Payments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPayments(Payment payment)
        {
            base.AddObject("Payments", payment);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PaymentsModel", Name="CashPayment")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CashPayment : Payment
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CashPayment object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="amount">Initial value of the Amount property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static CashPayment CreateCashPayment(global::System.Int32 id, global::System.Decimal amount, global::System.String name)
        {
            CashPayment cashPayment = new CashPayment();
            cashPayment.Id = id;
            cashPayment.Amount = amount;
            cashPayment.Name = name;
            return cashPayment;
        }

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PaymentsModel", Name="CreditCardPayment")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CreditCardPayment : Payment
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CreditCardPayment object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="amount">Initial value of the Amount property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="creditCard">Initial value of the CreditCard property.</param>
        public static CreditCardPayment CreateCreditCardPayment(global::System.Int32 id, global::System.Decimal amount, global::System.String name, global::System.String creditCard)
        {
            CreditCardPayment creditCardPayment = new CreditCardPayment();
            creditCardPayment.Id = id;
            creditCardPayment.Amount = amount;
            creditCardPayment.Name = name;
            creditCardPayment.CreditCard = creditCard;
            return creditCardPayment;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CreditCard
        {
            get
            {
                return _CreditCard;
            }
            set
            {
                OnCreditCardChanging(value);
                ReportPropertyChanging("CreditCard");
                _CreditCard = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CreditCard");
                OnCreditCardChanged();
            }
        }
        private global::System.String _CreditCard;
        partial void OnCreditCardChanging(global::System.String value);
        partial void OnCreditCardChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="PaymentsModel", Name="Payment")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    [KnownTypeAttribute(typeof(CreditCardPayment))]
    [KnownTypeAttribute(typeof(CashPayment))]
    public abstract partial class Payment : EntityObject
    {
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                OnAmountChanging(value);
                ReportPropertyChanging("Amount");
                _Amount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Amount");
                OnAmountChanged();
            }
        }
        private global::System.Decimal _Amount;
        partial void OnAmountChanging(global::System.Decimal value);
        partial void OnAmountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
    }

    #endregion
    
}