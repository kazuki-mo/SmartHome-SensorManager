﻿//------------------------------------------------------------------------------
// <auto-generated>
//    このコードはテンプレートから生成されました。
//
//    このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//    このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartHome_SensorManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SensorConditionEntities : DbContext
    {
        public SensorConditionEntities()
            : base("name=SensorConditionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DoorSensor> DoorSensors { get; set; }
        public DbSet<EnvironmentSensor> EnvironmentSensors { get; set; }
        public DbSet<PositionSensor> PositionSensors { get; set; }
        public DbSet<PowerSensor> PowerSensors { get; set; }
    }
}
