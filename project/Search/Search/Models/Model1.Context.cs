﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Search.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CustomerEntities : DbContext
    {
        public CustomerEntities()
            : base("name=CustomerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CountryName> CountryNames { get; set; }
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<user> users { get; set; }
    
        public virtual ObjectResult<string> ChangeStatus(Nullable<int> customerId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("CustomerId", customerId) :
                new ObjectParameter("CustomerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ChangeStatus", customerIdParameter);
        }
    
        public virtual int CountryEntry(string countryName)
        {
            var countryNameParameter = countryName != null ?
                new ObjectParameter("CountryName", countryName) :
                new ObjectParameter("CountryName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CountryEntry", countryNameParameter);
        }
    
        public virtual ObjectResult<CountryFetch_Result> CountryFetch()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CountryFetch_Result>("CountryFetch");
        }
    
        public virtual int CustomerDeletion(Nullable<int> customerID, string name)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CustomerDeletion", customerIDParameter, nameParameter);
        }
    
        public virtual ObjectResult<CustomerEntry_Result> CustomerEntry(string name, string phNo, string email, Nullable<int> countryID, Nullable<int> stateID, string remarks, string createdDate, string gSTEnable, Nullable<int> status)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var phNoParameter = phNo != null ?
                new ObjectParameter("PhNo", phNo) :
                new ObjectParameter("PhNo", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var countryIDParameter = countryID.HasValue ?
                new ObjectParameter("CountryID", countryID) :
                new ObjectParameter("CountryID", typeof(int));
    
            var stateIDParameter = stateID.HasValue ?
                new ObjectParameter("StateID", stateID) :
                new ObjectParameter("StateID", typeof(int));
    
            var remarksParameter = remarks != null ?
                new ObjectParameter("Remarks", remarks) :
                new ObjectParameter("Remarks", typeof(string));
    
            var createdDateParameter = createdDate != null ?
                new ObjectParameter("CreatedDate", createdDate) :
                new ObjectParameter("CreatedDate", typeof(string));
    
            var gSTEnableParameter = gSTEnable != null ?
                new ObjectParameter("GSTEnable", gSTEnable) :
                new ObjectParameter("GSTEnable", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerEntry_Result>("CustomerEntry", nameParameter, phNoParameter, emailParameter, countryIDParameter, stateIDParameter, remarksParameter, createdDateParameter, gSTEnableParameter, statusParameter);
        }
    
        public virtual ObjectResult<CustomerFetch_Result> CustomerFetch()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerFetch_Result>("CustomerFetch");
        }
    
        public virtual int CustomerSearch(string name, string phNo, string email)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var phNoParameter = phNo != null ?
                new ObjectParameter("PhNo", phNo) :
                new ObjectParameter("PhNo", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CustomerSearch", nameParameter, phNoParameter, emailParameter);
        }
    
        public virtual ObjectResult<CustomerSearchDate_Result> CustomerSearchDate(Nullable<System.DateTime> fromdate, Nullable<System.DateTime> todate)
        {
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("Fromdate", fromdate) :
                new ObjectParameter("Fromdate", typeof(System.DateTime));
    
            var todateParameter = todate.HasValue ?
                new ObjectParameter("Todate", todate) :
                new ObjectParameter("Todate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerSearchDate_Result>("CustomerSearchDate", fromdateParameter, todateParameter);
        }
    
        public virtual ObjectResult<CustomerUpdate_Result> CustomerUpdate(Nullable<int> customerID, string name, string phNo, string email, Nullable<int> countryID, Nullable<int> stateID, string remarks, string createdDate, string gSTEnable)
        {
            var customerIDParameter = customerID.HasValue ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var phNoParameter = phNo != null ?
                new ObjectParameter("PhNo", phNo) :
                new ObjectParameter("PhNo", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var countryIDParameter = countryID.HasValue ?
                new ObjectParameter("CountryID", countryID) :
                new ObjectParameter("CountryID", typeof(int));
    
            var stateIDParameter = stateID.HasValue ?
                new ObjectParameter("StateID", stateID) :
                new ObjectParameter("StateID", typeof(int));
    
            var remarksParameter = remarks != null ?
                new ObjectParameter("Remarks", remarks) :
                new ObjectParameter("Remarks", typeof(string));
    
            var createdDateParameter = createdDate != null ?
                new ObjectParameter("CreatedDate", createdDate) :
                new ObjectParameter("CreatedDate", typeof(string));
    
            var gSTEnableParameter = gSTEnable != null ?
                new ObjectParameter("GSTEnable", gSTEnable) :
                new ObjectParameter("GSTEnable", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustomerUpdate_Result>("CustomerUpdate", customerIDParameter, nameParameter, phNoParameter, emailParameter, countryIDParameter, stateIDParameter, remarksParameter, createdDateParameter, gSTEnableParameter);
        }
    
        public virtual int LoginEntry(string userName, string passWord, string name, Nullable<int> createdUserID, Nullable<System.DateTime> createdDate, Nullable<System.DateTime> createdDateTime, Nullable<byte> status)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("PassWord", passWord) :
                new ObjectParameter("PassWord", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var createdUserIDParameter = createdUserID.HasValue ?
                new ObjectParameter("CreatedUserID", createdUserID) :
                new ObjectParameter("CreatedUserID", typeof(int));
    
            var createdDateParameter = createdDate.HasValue ?
                new ObjectParameter("CreatedDate", createdDate) :
                new ObjectParameter("CreatedDate", typeof(System.DateTime));
    
            var createdDateTimeParameter = createdDateTime.HasValue ?
                new ObjectParameter("CreatedDateTime", createdDateTime) :
                new ObjectParameter("CreatedDateTime", typeof(System.DateTime));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LoginEntry", userNameParameter, passWordParameter, nameParameter, createdUserIDParameter, createdDateParameter, createdDateTimeParameter, statusParameter);
        }
    
        public virtual int LoginValidation(string userName, string passWord)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("PassWord", passWord) :
                new ObjectParameter("PassWord", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LoginValidation", userNameParameter, passWordParameter);
        }
    
        public virtual int StateEntry(string stateName)
        {
            var stateNameParameter = stateName != null ?
                new ObjectParameter("StateName", stateName) :
                new ObjectParameter("StateName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StateEntry", stateNameParameter);
        }
    
        public virtual ObjectResult<StateFetch_Result> StateFetch()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StateFetch_Result>("StateFetch");
        }
    
        public virtual int StatusChange(Nullable<int> customerId, Nullable<byte> status)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("CustomerId", customerId) :
                new ObjectParameter("CustomerId", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("StatusChange", customerIdParameter, statusParameter);
        }
    }
}