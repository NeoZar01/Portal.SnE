﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoE.Lsm.Data.Repositories.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PortalSnE : DbContext
    {
        public PortalSnE()
            : base("name=PortalSnE")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<WIProcessStep> WIProcessSteps { get; set; }
        public virtual DbSet<WIProcessStepInstance> WIProcessStepInstances { get; set; }
        public virtual DbSet<WIProcess> WIProcesses { get; set; }
        public virtual DbSet<WIProcessInstance> WIProcessInstances { get; set; }
        public virtual DbSet<WIProcessStepInstance_Snapshots> WIProcessStepInstance_Snapshots { get; set; }
        public virtual DbSet<ExtractSchedulerQueue> ExtractSchedulerQueues { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<DataExtract> DataExtracts { get; set; }
        public virtual DbSet<WIOutcome> WIOutcomes { get; set; }
        public virtual DbSet<C_Errors> C_Errors { get; set; }
        public virtual DbSet<WILock> WILocks { get; set; }
    
        public virtual int sp_MigrateData_Merge(string tempTable_PK, string extractName, string surveyKey, string consoriumGroupName, string entityId, string memberId, string stagingTable, string dATA_001, string dATA_002, string dATA_003, string dATA_004, string dATA_005, string dATA_006, string dATA_007, string dATA_008, string dATA_009, string dATA_010)
        {
            var tempTable_PKParameter = tempTable_PK != null ?
                new ObjectParameter("TempTable_PK", tempTable_PK) :
                new ObjectParameter("TempTable_PK", typeof(string));
    
            var extractNameParameter = extractName != null ?
                new ObjectParameter("ExtractName", extractName) :
                new ObjectParameter("ExtractName", typeof(string));
    
            var surveyKeyParameter = surveyKey != null ?
                new ObjectParameter("SurveyKey", surveyKey) :
                new ObjectParameter("SurveyKey", typeof(string));
    
            var consoriumGroupNameParameter = consoriumGroupName != null ?
                new ObjectParameter("ConsoriumGroupName", consoriumGroupName) :
                new ObjectParameter("ConsoriumGroupName", typeof(string));
    
            var entityIdParameter = entityId != null ?
                new ObjectParameter("EntityId", entityId) :
                new ObjectParameter("EntityId", typeof(string));
    
            var memberIdParameter = memberId != null ?
                new ObjectParameter("MemberId", memberId) :
                new ObjectParameter("MemberId", typeof(string));
    
            var stagingTableParameter = stagingTable != null ?
                new ObjectParameter("StagingTable", stagingTable) :
                new ObjectParameter("StagingTable", typeof(string));
    
            var dATA_001Parameter = dATA_001 != null ?
                new ObjectParameter("DATA_001", dATA_001) :
                new ObjectParameter("DATA_001", typeof(string));
    
            var dATA_002Parameter = dATA_002 != null ?
                new ObjectParameter("DATA_002", dATA_002) :
                new ObjectParameter("DATA_002", typeof(string));
    
            var dATA_003Parameter = dATA_003 != null ?
                new ObjectParameter("DATA_003", dATA_003) :
                new ObjectParameter("DATA_003", typeof(string));
    
            var dATA_004Parameter = dATA_004 != null ?
                new ObjectParameter("DATA_004", dATA_004) :
                new ObjectParameter("DATA_004", typeof(string));
    
            var dATA_005Parameter = dATA_005 != null ?
                new ObjectParameter("DATA_005", dATA_005) :
                new ObjectParameter("DATA_005", typeof(string));
    
            var dATA_006Parameter = dATA_006 != null ?
                new ObjectParameter("DATA_006", dATA_006) :
                new ObjectParameter("DATA_006", typeof(string));
    
            var dATA_007Parameter = dATA_007 != null ?
                new ObjectParameter("DATA_007", dATA_007) :
                new ObjectParameter("DATA_007", typeof(string));
    
            var dATA_008Parameter = dATA_008 != null ?
                new ObjectParameter("DATA_008", dATA_008) :
                new ObjectParameter("DATA_008", typeof(string));
    
            var dATA_009Parameter = dATA_009 != null ?
                new ObjectParameter("DATA_009", dATA_009) :
                new ObjectParameter("DATA_009", typeof(string));
    
            var dATA_010Parameter = dATA_010 != null ?
                new ObjectParameter("DATA_010", dATA_010) :
                new ObjectParameter("DATA_010", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_MigrateData_Merge", tempTable_PKParameter, extractNameParameter, surveyKeyParameter, consoriumGroupNameParameter, entityIdParameter, memberIdParameter, stagingTableParameter, dATA_001Parameter, dATA_002Parameter, dATA_003Parameter, dATA_004Parameter, dATA_005Parameter, dATA_006Parameter, dATA_007Parameter, dATA_008Parameter, dATA_009Parameter, dATA_010Parameter);
        }
    }
}
