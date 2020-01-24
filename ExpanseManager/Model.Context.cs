﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpanseManager
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Expanses : DbContext
    {
        public Expanses()
            : base("name=Expanses")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<moneyTransaction> moneyTransaction { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<Userr> Userr { get; set; }
    
        public virtual int SetBalance(Nullable<int> acc_id, Nullable<float> newBalance)
        {
            var acc_idParameter = acc_id.HasValue ?
                new ObjectParameter("acc_id", acc_id) :
                new ObjectParameter("acc_id", typeof(int));
    
            var newBalanceParameter = newBalance.HasValue ?
                new ObjectParameter("newBalance", newBalance) :
                new ObjectParameter("newBalance", typeof(float));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SetBalance", acc_idParameter, newBalanceParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> GetBalance(Nullable<int> acc_id)
        {
            var acc_idParameter = acc_id.HasValue ?
                new ObjectParameter("acc_id", acc_id) :
                new ObjectParameter("acc_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("GetBalance", acc_idParameter);
        }
    }
}
