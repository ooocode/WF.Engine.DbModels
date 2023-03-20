using Microsoft.EntityFrameworkCore;
using WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

namespace WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Data;

public partial class EngineTemplateDbContext<T> : DbContext where T : DbContext
{
    public EngineTemplateDbContext(DbContextOptions<T> options)
        : base(options)
    {
    }

    public virtual DbSet<ActGeBytearray> ActGeBytearrays { get; set; }

    public virtual DbSet<ActGeProperty> ActGeProperties { get; set; }

    public virtual DbSet<ActGeSchemaLog> ActGeSchemaLogs { get; set; }

    public virtual DbSet<ActHiActinst> ActHiActinsts { get; set; }

    public virtual DbSet<ActHiAttachment> ActHiAttachments { get; set; }

    public virtual DbSet<ActHiBatch> ActHiBatches { get; set; }

    public virtual DbSet<ActHiCaseactinst> ActHiCaseactinsts { get; set; }

    public virtual DbSet<ActHiCaseinst> ActHiCaseinsts { get; set; }

    public virtual DbSet<ActHiComment> ActHiComments { get; set; }

    public virtual DbSet<ActHiDecIn> ActHiDecIns { get; set; }

    public virtual DbSet<ActHiDecOut> ActHiDecOuts { get; set; }

    public virtual DbSet<ActHiDecinst> ActHiDecinsts { get; set; }

    public virtual DbSet<ActHiDetail> ActHiDetails { get; set; }

    public virtual DbSet<ActHiExtTaskLog> ActHiExtTaskLogs { get; set; }

    public virtual DbSet<ActHiIdentitylink> ActHiIdentitylinks { get; set; }

    public virtual DbSet<ActHiIncident> ActHiIncidents { get; set; }

    public virtual DbSet<ActHiJobLog> ActHiJobLogs { get; set; }

    public virtual DbSet<ActHiOpLog> ActHiOpLogs { get; set; }

    public virtual DbSet<ActHiProcinst> ActHiProcinsts { get; set; }

    public virtual DbSet<ActHiTaskinst> ActHiTaskinsts { get; set; }

    public virtual DbSet<ActHiVarinst> ActHiVarinsts { get; set; }

    public virtual DbSet<ActIdGroup> ActIdGroups { get; set; }

    public virtual DbSet<ActIdInfo> ActIdInfos { get; set; }

    public virtual DbSet<ActIdTenant> ActIdTenants { get; set; }

    public virtual DbSet<ActIdTenantMember> ActIdTenantMembers { get; set; }

    public virtual DbSet<ActIdUser> ActIdUsers { get; set; }

    public virtual DbSet<ActReCamformdef> ActReCamformdefs { get; set; }

    public virtual DbSet<ActReCaseDef> ActReCaseDefs { get; set; }

    public virtual DbSet<ActReDecisionDef> ActReDecisionDefs { get; set; }

    public virtual DbSet<ActReDecisionReqDef> ActReDecisionReqDefs { get; set; }

    public virtual DbSet<ActReDeployment> ActReDeployments { get; set; }

    public virtual DbSet<ActReProcdef> ActReProcdefs { get; set; }

    public virtual DbSet<ActRuAuthorization> ActRuAuthorizations { get; set; }

    public virtual DbSet<ActRuBatch> ActRuBatches { get; set; }

    public virtual DbSet<ActRuCaseExecution> ActRuCaseExecutions { get; set; }

    public virtual DbSet<ActRuCaseSentryPart> ActRuCaseSentryParts { get; set; }

    public virtual DbSet<ActRuEventSubscr> ActRuEventSubscrs { get; set; }

    public virtual DbSet<ActRuExecution> ActRuExecutions { get; set; }

    public virtual DbSet<ActRuExtTask> ActRuExtTasks { get; set; }

    public virtual DbSet<ActRuFilter> ActRuFilters { get; set; }

    public virtual DbSet<ActRuIdentitylink> ActRuIdentitylinks { get; set; }

    public virtual DbSet<ActRuIncident> ActRuIncidents { get; set; }

    public virtual DbSet<ActRuJob> ActRuJobs { get; set; }

    public virtual DbSet<ActRuJobdef> ActRuJobdefs { get; set; }

    public virtual DbSet<ActRuMeterLog> ActRuMeterLogs { get; set; }

    public virtual DbSet<ActRuTask> ActRuTasks { get; set; }

    public virtual DbSet<ActRuTaskMeterLog> ActRuTaskMeterLogs { get; set; }

    public virtual DbSet<ActRuVariable> ActRuVariables { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActGeBytearray>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ge_bytearray_pkey");

            entity.ToTable("act_ge_bytearray");

            entity.HasIndex(e => e.DeploymentId, "act_idx_bytear_depl");

            entity.HasIndex(e => e.Name, "act_idx_bytearray_name");

            entity.HasIndex(e => e.RemovalTime, "act_idx_bytearray_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_bytearray_root_pi");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Bytes).HasColumnName("bytes_");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time_");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(64)
                .HasColumnName("deployment_id_");
            entity.Property(e => e.Generated).HasColumnName("generated_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Type).HasColumnName("type_");

            entity.HasOne(d => d.Deployment).WithMany(p => p.ActGeBytearrays)
                .HasForeignKey(d => d.DeploymentId)
                .HasConstraintName("act_fk_bytearr_depl");
        });

        modelBuilder.Entity<ActGeProperty>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("act_ge_property_pkey");

            entity.ToTable("act_ge_property");

            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.Value)
                .HasMaxLength(300)
                .HasColumnName("value_");
        });

        modelBuilder.Entity<ActGeSchemaLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ge_schema_log_pkey");

            entity.ToTable("act_ge_schema_log");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Timestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp_");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasColumnName("version_");
        });

        modelBuilder.Entity<ActHiActinst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_actinst_pkey");

            entity.ToTable("act_hi_actinst");

            entity.HasIndex(e => new { e.ExecutionId, e.ActId, e.EndTime, e.Id }, "act_idx_hi_act_inst_comp");

            entity.HasIndex(e => e.EndTime, "act_idx_hi_act_inst_end");

            entity.HasIndex(e => e.ProcDefKey, "act_idx_hi_act_inst_proc_def_key");

            entity.HasIndex(e => new { e.ProcInstId, e.ActId }, "act_idx_hi_act_inst_procinst");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_act_inst_rm_time");

            entity.HasIndex(e => new { e.StartTime, e.EndTime }, "act_idx_hi_act_inst_start_end");

            entity.HasIndex(e => new { e.ProcDefId, e.ProcInstId, e.ActId, e.EndTime, e.ActInstState }, "act_idx_hi_act_inst_stats");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_act_inst_tenant_id");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_actinst_root_pi");

            entity.HasIndex(e => new { e.ProcDefId, e.EndTime }, "act_idx_hi_ai_pdefid_end_time");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActId)
                .HasMaxLength(255)
                .HasColumnName("act_id_");
            entity.Property(e => e.ActInstState).HasColumnName("act_inst_state_");
            entity.Property(e => e.ActName)
                .HasMaxLength(255)
                .HasColumnName("act_name_");
            entity.Property(e => e.ActType)
                .HasMaxLength(255)
                .HasColumnName("act_type_");
            entity.Property(e => e.Assignee)
                .HasMaxLength(255)
                .HasColumnName("assignee_");
            entity.Property(e => e.CallCaseInstId)
                .HasMaxLength(64)
                .HasColumnName("call_case_inst_id_");
            entity.Property(e => e.CallProcInstId)
                .HasMaxLength(64)
                .HasColumnName("call_proc_inst_id_");
            entity.Property(e => e.Duration).HasColumnName("duration_");
            entity.Property(e => e.EndTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_time_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.ParentActInstId)
                .HasMaxLength(64)
                .HasColumnName("parent_act_inst_id_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.SequenceCounter).HasColumnName("sequence_counter_");
            entity.Property(e => e.StartTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_time_");
            entity.Property(e => e.TaskId)
                .HasMaxLength(64)
                .HasColumnName("task_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
        });

        modelBuilder.Entity<ActHiAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_attachment_pkey");

            entity.ToTable("act_hi_attachment");

            entity.HasIndex(e => e.ContentId, "act_idx_hi_attachment_content");

            entity.HasIndex(e => e.ProcInstId, "act_idx_hi_attachment_procinst");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_attachment_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_attachment_root_pi");

            entity.HasIndex(e => e.TaskId, "act_idx_hi_attachment_task");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ContentId)
                .HasMaxLength(64)
                .HasColumnName("content_id_");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time_");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("description_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.TaskId)
                .HasMaxLength(64)
                .HasColumnName("task_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");
            entity.Property(e => e.Url)
                .HasMaxLength(4000)
                .HasColumnName("url_");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id_");
        });

        modelBuilder.Entity<ActHiBatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_batch_pkey");

            entity.ToTable("act_hi_batch");

            entity.HasIndex(e => e.RemovalTime, "act_hi_bat_rm_time");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.BatchJobDefId)
                .HasMaxLength(64)
                .HasColumnName("batch_job_def_id_");
            entity.Property(e => e.CreateUserId)
                .HasMaxLength(255)
                .HasColumnName("create_user_id_");
            entity.Property(e => e.EndTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_time_");
            entity.Property(e => e.InvocationsPerJob).HasColumnName("invocations_per_job_");
            entity.Property(e => e.JobsPerSeed).HasColumnName("jobs_per_seed_");
            entity.Property(e => e.MonitorJobDefId)
                .HasMaxLength(64)
                .HasColumnName("monitor_job_def_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.SeedJobDefId)
                .HasMaxLength(64)
                .HasColumnName("seed_job_def_id_");
            entity.Property(e => e.StartTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_time_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.TotalJobs).HasColumnName("total_jobs_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");
        });

        modelBuilder.Entity<ActHiCaseactinst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_caseactinst_pkey");

            entity.ToTable("act_hi_caseactinst");

            entity.HasIndex(e => new { e.CaseActId, e.EndTime, e.Id }, "act_idx_hi_cas_a_i_comp");

            entity.HasIndex(e => e.CreateTime, "act_idx_hi_cas_a_i_create");

            entity.HasIndex(e => e.EndTime, "act_idx_hi_cas_a_i_end");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_cas_a_i_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.CallCaseInstId)
                .HasMaxLength(64)
                .HasColumnName("call_case_inst_id_");
            entity.Property(e => e.CallProcInstId)
                .HasMaxLength(64)
                .HasColumnName("call_proc_inst_id_");
            entity.Property(e => e.CaseActId)
                .HasMaxLength(255)
                .HasColumnName("case_act_id_");
            entity.Property(e => e.CaseActName)
                .HasMaxLength(255)
                .HasColumnName("case_act_name_");
            entity.Property(e => e.CaseActType)
                .HasMaxLength(255)
                .HasColumnName("case_act_type_");
            entity.Property(e => e.CaseDefId)
                .HasMaxLength(64)
                .HasColumnName("case_def_id_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time_");
            entity.Property(e => e.Duration).HasColumnName("duration_");
            entity.Property(e => e.EndTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_time_");
            entity.Property(e => e.ParentActInstId)
                .HasMaxLength(64)
                .HasColumnName("parent_act_inst_id_");
            entity.Property(e => e.Required).HasColumnName("required_");
            entity.Property(e => e.State).HasColumnName("state_");
            entity.Property(e => e.TaskId)
                .HasMaxLength(64)
                .HasColumnName("task_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
        });

        modelBuilder.Entity<ActHiCaseinst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_caseinst_pkey");

            entity.ToTable("act_hi_caseinst");

            entity.HasIndex(e => e.CaseInstId, "act_hi_caseinst_case_inst_id__key").IsUnique();

            entity.HasIndex(e => e.BusinessKey, "act_idx_hi_cas_i_buskey");

            entity.HasIndex(e => e.CloseTime, "act_idx_hi_cas_i_close");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_cas_i_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.BusinessKey)
                .HasMaxLength(255)
                .HasColumnName("business_key_");
            entity.Property(e => e.CaseDefId)
                .HasMaxLength(64)
                .HasColumnName("case_def_id_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.CloseTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("close_time_");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time_");
            entity.Property(e => e.CreateUserId)
                .HasMaxLength(255)
                .HasColumnName("create_user_id_");
            entity.Property(e => e.Duration).HasColumnName("duration_");
            entity.Property(e => e.State).HasColumnName("state_");
            entity.Property(e => e.SuperCaseInstanceId)
                .HasMaxLength(64)
                .HasColumnName("super_case_instance_id_");
            entity.Property(e => e.SuperProcessInstanceId)
                .HasMaxLength(64)
                .HasColumnName("super_process_instance_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
        });

        modelBuilder.Entity<ActHiComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_comment_pkey");

            entity.ToTable("act_hi_comment");

            entity.HasIndex(e => e.ProcInstId, "act_idx_hi_comment_procinst");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_comment_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_comment_root_pi");

            entity.HasIndex(e => e.TaskId, "act_idx_hi_comment_task");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action_");
            entity.Property(e => e.FullMsg).HasColumnName("full_msg_");
            entity.Property(e => e.Message)
                .HasMaxLength(4000)
                .HasColumnName("message_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.TaskId)
                .HasMaxLength(64)
                .HasColumnName("task_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Time)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("time_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id_");
        });

        modelBuilder.Entity<ActHiDecIn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_dec_in_pkey");

            entity.ToTable("act_hi_dec_in");

            entity.HasIndex(e => new { e.DecInstId, e.ClauseId }, "act_idx_hi_dec_in_clause");

            entity.HasIndex(e => e.DecInstId, "act_idx_hi_dec_in_inst");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_dec_in_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_dec_in_root_pi");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.BytearrayId)
                .HasMaxLength(64)
                .HasColumnName("bytearray_id_");
            entity.Property(e => e.ClauseId)
                .HasMaxLength(64)
                .HasColumnName("clause_id_");
            entity.Property(e => e.ClauseName)
                .HasMaxLength(255)
                .HasColumnName("clause_name_");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time_");
            entity.Property(e => e.DecInstId)
                .HasMaxLength(64)
                .HasColumnName("dec_inst_id_");
            entity.Property(e => e.Double).HasColumnName("double_");
            entity.Property(e => e.Long).HasColumnName("long_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Text)
                .HasMaxLength(4000)
                .HasColumnName("text_");
            entity.Property(e => e.Text2)
                .HasMaxLength(4000)
                .HasColumnName("text2_");
            entity.Property(e => e.VarType)
                .HasMaxLength(100)
                .HasColumnName("var_type_");
        });

        modelBuilder.Entity<ActHiDecOut>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_dec_out_pkey");

            entity.ToTable("act_hi_dec_out");

            entity.HasIndex(e => e.DecInstId, "act_idx_hi_dec_out_inst");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_dec_out_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_dec_out_root_pi");

            entity.HasIndex(e => new { e.RuleOrder, e.ClauseId }, "act_idx_hi_dec_out_rule");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.BytearrayId)
                .HasMaxLength(64)
                .HasColumnName("bytearray_id_");
            entity.Property(e => e.ClauseId)
                .HasMaxLength(64)
                .HasColumnName("clause_id_");
            entity.Property(e => e.ClauseName)
                .HasMaxLength(255)
                .HasColumnName("clause_name_");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time_");
            entity.Property(e => e.DecInstId)
                .HasMaxLength(64)
                .HasColumnName("dec_inst_id_");
            entity.Property(e => e.Double).HasColumnName("double_");
            entity.Property(e => e.Long).HasColumnName("long_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.RuleId)
                .HasMaxLength(64)
                .HasColumnName("rule_id_");
            entity.Property(e => e.RuleOrder).HasColumnName("rule_order_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Text)
                .HasMaxLength(4000)
                .HasColumnName("text_");
            entity.Property(e => e.Text2)
                .HasMaxLength(4000)
                .HasColumnName("text2_");
            entity.Property(e => e.VarName)
                .HasMaxLength(255)
                .HasColumnName("var_name_");
            entity.Property(e => e.VarType)
                .HasMaxLength(100)
                .HasColumnName("var_type_");
        });

        modelBuilder.Entity<ActHiDecinst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_decinst_pkey");

            entity.ToTable("act_hi_decinst");

            entity.HasIndex(e => e.ActId, "act_idx_hi_dec_inst_act");

            entity.HasIndex(e => e.ActInstId, "act_idx_hi_dec_inst_act_inst");

            entity.HasIndex(e => e.CaseInstId, "act_idx_hi_dec_inst_ci");

            entity.HasIndex(e => e.DecDefId, "act_idx_hi_dec_inst_id");

            entity.HasIndex(e => e.DecDefKey, "act_idx_hi_dec_inst_key");

            entity.HasIndex(e => e.ProcInstId, "act_idx_hi_dec_inst_pi");

            entity.HasIndex(e => e.DecReqId, "act_idx_hi_dec_inst_req_id");

            entity.HasIndex(e => e.DecReqKey, "act_idx_hi_dec_inst_req_key");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_dec_inst_rm_time");

            entity.HasIndex(e => e.RootDecInstId, "act_idx_hi_dec_inst_root_id");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_dec_inst_root_pi");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_dec_inst_tenant_id");

            entity.HasIndex(e => e.EvalTime, "act_idx_hi_dec_inst_time");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActId)
                .HasMaxLength(255)
                .HasColumnName("act_id_");
            entity.Property(e => e.ActInstId)
                .HasMaxLength(64)
                .HasColumnName("act_inst_id_");
            entity.Property(e => e.CaseDefId)
                .HasMaxLength(64)
                .HasColumnName("case_def_id_");
            entity.Property(e => e.CaseDefKey)
                .HasMaxLength(255)
                .HasColumnName("case_def_key_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.CollectValue).HasColumnName("collect_value_");
            entity.Property(e => e.DecDefId)
                .HasMaxLength(64)
                .HasColumnName("dec_def_id_");
            entity.Property(e => e.DecDefKey)
                .HasMaxLength(255)
                .HasColumnName("dec_def_key_");
            entity.Property(e => e.DecDefName)
                .HasMaxLength(255)
                .HasColumnName("dec_def_name_");
            entity.Property(e => e.DecReqId)
                .HasMaxLength(64)
                .HasColumnName("dec_req_id_");
            entity.Property(e => e.DecReqKey)
                .HasMaxLength(255)
                .HasColumnName("dec_req_key_");
            entity.Property(e => e.EvalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("eval_time_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootDecInstId)
                .HasMaxLength(64)
                .HasColumnName("root_dec_inst_id_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id_");
        });

        modelBuilder.Entity<ActHiDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_detail_pkey");

            entity.ToTable("act_hi_detail");

            entity.HasIndex(e => e.ActInstId, "act_idx_hi_detail_act_inst");

            entity.HasIndex(e => e.BytearrayId, "act_idx_hi_detail_bytear");

            entity.HasIndex(e => e.CaseExecutionId, "act_idx_hi_detail_case_exec");

            entity.HasIndex(e => e.CaseInstId, "act_idx_hi_detail_case_inst");

            entity.HasIndex(e => e.Name, "act_idx_hi_detail_name");

            entity.HasIndex(e => e.ProcDefKey, "act_idx_hi_detail_proc_def_key");

            entity.HasIndex(e => e.ProcInstId, "act_idx_hi_detail_proc_inst");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_detail_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_detail_root_pi");

            entity.HasIndex(e => new { e.BytearrayId, e.TaskId }, "act_idx_hi_detail_task_bytear");

            entity.HasIndex(e => e.TaskId, "act_idx_hi_detail_task_id");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_detail_tenant_id");

            entity.HasIndex(e => e.Time, "act_idx_hi_detail_time");

            entity.HasIndex(e => e.VarInstId, "act_idx_hi_detail_var_inst_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActInstId)
                .HasMaxLength(64)
                .HasColumnName("act_inst_id_");
            entity.Property(e => e.BytearrayId)
                .HasMaxLength(64)
                .HasColumnName("bytearray_id_");
            entity.Property(e => e.CaseDefId)
                .HasMaxLength(64)
                .HasColumnName("case_def_id_");
            entity.Property(e => e.CaseDefKey)
                .HasMaxLength(255)
                .HasColumnName("case_def_key_");
            entity.Property(e => e.CaseExecutionId)
                .HasMaxLength(64)
                .HasColumnName("case_execution_id_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.Double).HasColumnName("double_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.Initial).HasColumnName("initial_");
            entity.Property(e => e.Long).HasColumnName("long_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.OperationId)
                .HasMaxLength(64)
                .HasColumnName("operation_id_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.SequenceCounter).HasColumnName("sequence_counter_");
            entity.Property(e => e.TaskId)
                .HasMaxLength(64)
                .HasColumnName("task_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Text)
                .HasMaxLength(4000)
                .HasColumnName("text_");
            entity.Property(e => e.Text2)
                .HasMaxLength(4000)
                .HasColumnName("text2_");
            entity.Property(e => e.Time)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("time_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");
            entity.Property(e => e.VarInstId)
                .HasMaxLength(64)
                .HasColumnName("var_inst_id_");
            entity.Property(e => e.VarType)
                .HasMaxLength(64)
                .HasColumnName("var_type_");
        });

        modelBuilder.Entity<ActHiExtTaskLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_ext_task_log_pkey");

            entity.ToTable("act_hi_ext_task_log");

            entity.HasIndex(e => e.ProcDefKey, "act_hi_ext_task_log_proc_def_key");

            entity.HasIndex(e => e.ProcDefId, "act_hi_ext_task_log_procdef");

            entity.HasIndex(e => e.ProcInstId, "act_hi_ext_task_log_procinst");

            entity.HasIndex(e => e.RemovalTime, "act_hi_ext_task_log_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_hi_ext_task_log_root_pi");

            entity.HasIndex(e => e.TenantId, "act_hi_ext_task_log_tenant_id");

            entity.HasIndex(e => e.ErrorDetailsId, "act_idx_hi_exttasklog_errordet");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActId)
                .HasMaxLength(255)
                .HasColumnName("act_id_");
            entity.Property(e => e.ActInstId)
                .HasMaxLength(64)
                .HasColumnName("act_inst_id_");
            entity.Property(e => e.ErrorDetailsId)
                .HasMaxLength(64)
                .HasColumnName("error_details_id_");
            entity.Property(e => e.ErrorMsg)
                .HasMaxLength(4000)
                .HasColumnName("error_msg_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.ExtTaskId)
                .HasMaxLength(64)
                .HasColumnName("ext_task_id_");
            entity.Property(e => e.Priority).HasColumnName("priority_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.Retries).HasColumnName("retries_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.State).HasColumnName("state_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Timestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp_");
            entity.Property(e => e.TopicName)
                .HasMaxLength(255)
                .HasColumnName("topic_name_");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(255)
                .HasColumnName("worker_id_");
        });

        modelBuilder.Entity<ActHiIdentitylink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_identitylink_pkey");

            entity.ToTable("act_hi_identitylink");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_ident_link_rm_time");

            entity.HasIndex(e => e.TaskId, "act_idx_hi_ident_link_task");

            entity.HasIndex(e => e.GroupId, "act_idx_hi_ident_lnk_group");

            entity.HasIndex(e => e.ProcDefKey, "act_idx_hi_ident_lnk_proc_def_key");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_ident_lnk_root_pi");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_ident_lnk_tenant_id");

            entity.HasIndex(e => e.Timestamp, "act_idx_hi_ident_lnk_timestamp");

            entity.HasIndex(e => e.UserId, "act_idx_hi_ident_lnk_user");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.AssignerId)
                .HasMaxLength(64)
                .HasColumnName("assigner_id_");
            entity.Property(e => e.GroupId)
                .HasMaxLength(255)
                .HasColumnName("group_id_");
            entity.Property(e => e.OperationType)
                .HasMaxLength(64)
                .HasColumnName("operation_type_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.TaskId)
                .HasMaxLength(64)
                .HasColumnName("task_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Timestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id_");
        });

        modelBuilder.Entity<ActHiIncident>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_incident_pkey");

            entity.ToTable("act_hi_incident");

            entity.HasIndex(e => e.CreateTime, "act_idx_hi_incident_create_time");

            entity.HasIndex(e => e.EndTime, "act_idx_hi_incident_end_time");

            entity.HasIndex(e => e.ProcDefKey, "act_idx_hi_incident_proc_def_key");

            entity.HasIndex(e => e.ProcInstId, "act_idx_hi_incident_procinst");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_incident_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_incident_root_pi");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_incident_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActivityId)
                .HasMaxLength(255)
                .HasColumnName("activity_id_");
            entity.Property(e => e.Annotation)
                .HasMaxLength(4000)
                .HasColumnName("annotation_");
            entity.Property(e => e.CauseIncidentId)
                .HasMaxLength(64)
                .HasColumnName("cause_incident_id_");
            entity.Property(e => e.Configuration)
                .HasMaxLength(255)
                .HasColumnName("configuration_");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time_");
            entity.Property(e => e.EndTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_time_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.FailedActivityId)
                .HasMaxLength(255)
                .HasColumnName("failed_activity_id_");
            entity.Property(e => e.HistoryConfiguration)
                .HasMaxLength(255)
                .HasColumnName("history_configuration_");
            entity.Property(e => e.IncidentMsg)
                .HasMaxLength(4000)
                .HasColumnName("incident_msg_");
            entity.Property(e => e.IncidentState).HasColumnName("incident_state_");
            entity.Property(e => e.IncidentType)
                .HasMaxLength(255)
                .HasColumnName("incident_type_");
            entity.Property(e => e.JobDefId)
                .HasMaxLength(64)
                .HasColumnName("job_def_id_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootCauseIncidentId)
                .HasMaxLength(64)
                .HasColumnName("root_cause_incident_id_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
        });

        modelBuilder.Entity<ActHiJobLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_job_log_pkey");

            entity.ToTable("act_hi_job_log");

            entity.HasIndex(e => e.JobExceptionStackId, "act_idx_hi_job_log_ex_stack");

            entity.HasIndex(e => e.JobDefConfiguration, "act_idx_hi_job_log_job_conf");

            entity.HasIndex(e => e.JobDefId, "act_idx_hi_job_log_job_def_id");

            entity.HasIndex(e => e.ProcessDefKey, "act_idx_hi_job_log_proc_def_key");

            entity.HasIndex(e => e.ProcessDefId, "act_idx_hi_job_log_procdef");

            entity.HasIndex(e => e.ProcessInstanceId, "act_idx_hi_job_log_procinst");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_job_log_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_job_log_root_pi");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_job_log_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActId)
                .HasMaxLength(255)
                .HasColumnName("act_id_");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(64)
                .HasColumnName("deployment_id_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.FailedActId)
                .HasMaxLength(255)
                .HasColumnName("failed_act_id_");
            entity.Property(e => e.Hostname)
                .HasMaxLength(255)
                .HasColumnName("hostname_");
            entity.Property(e => e.JobDefConfiguration)
                .HasMaxLength(255)
                .HasColumnName("job_def_configuration_");
            entity.Property(e => e.JobDefId)
                .HasMaxLength(64)
                .HasColumnName("job_def_id_");
            entity.Property(e => e.JobDefType)
                .HasMaxLength(255)
                .HasColumnName("job_def_type_");
            entity.Property(e => e.JobDuedate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("job_duedate_");
            entity.Property(e => e.JobExceptionMsg)
                .HasMaxLength(4000)
                .HasColumnName("job_exception_msg_");
            entity.Property(e => e.JobExceptionStackId)
                .HasMaxLength(64)
                .HasColumnName("job_exception_stack_id_");
            entity.Property(e => e.JobId)
                .HasMaxLength(64)
                .HasColumnName("job_id_");
            entity.Property(e => e.JobPriority).HasColumnName("job_priority_");
            entity.Property(e => e.JobRetries).HasColumnName("job_retries_");
            entity.Property(e => e.JobState).HasColumnName("job_state_");
            entity.Property(e => e.ProcessDefId)
                .HasMaxLength(64)
                .HasColumnName("process_def_id_");
            entity.Property(e => e.ProcessDefKey)
                .HasMaxLength(255)
                .HasColumnName("process_def_key_");
            entity.Property(e => e.ProcessInstanceId)
                .HasMaxLength(64)
                .HasColumnName("process_instance_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.SequenceCounter).HasColumnName("sequence_counter_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Timestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp_");
        });

        modelBuilder.Entity<ActHiOpLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_op_log_pkey");

            entity.ToTable("act_hi_op_log");

            entity.HasIndex(e => e.EntityType, "act_idx_hi_op_log_entity_type");

            entity.HasIndex(e => e.OperationType, "act_idx_hi_op_log_op_type");

            entity.HasIndex(e => e.ProcDefId, "act_idx_hi_op_log_procdef");

            entity.HasIndex(e => e.ProcInstId, "act_idx_hi_op_log_procinst");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_op_log_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_op_log_root_pi");

            entity.HasIndex(e => e.TaskId, "act_idx_hi_op_log_task");

            entity.HasIndex(e => e.Timestamp, "act_idx_hi_op_log_timestamp");

            entity.HasIndex(e => e.UserId, "act_idx_hi_op_log_user_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Annotation)
                .HasMaxLength(4000)
                .HasColumnName("annotation_");
            entity.Property(e => e.BatchId)
                .HasMaxLength(64)
                .HasColumnName("batch_id_");
            entity.Property(e => e.CaseDefId)
                .HasMaxLength(64)
                .HasColumnName("case_def_id_");
            entity.Property(e => e.CaseExecutionId)
                .HasMaxLength(64)
                .HasColumnName("case_execution_id_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.Category)
                .HasMaxLength(64)
                .HasColumnName("category_");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(64)
                .HasColumnName("deployment_id_");
            entity.Property(e => e.EntityType)
                .HasMaxLength(30)
                .HasColumnName("entity_type_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.ExternalTaskId)
                .HasMaxLength(64)
                .HasColumnName("external_task_id_");
            entity.Property(e => e.JobDefId)
                .HasMaxLength(64)
                .HasColumnName("job_def_id_");
            entity.Property(e => e.JobId)
                .HasMaxLength(64)
                .HasColumnName("job_id_");
            entity.Property(e => e.NewValue)
                .HasMaxLength(4000)
                .HasColumnName("new_value_");
            entity.Property(e => e.OperationId)
                .HasMaxLength(64)
                .HasColumnName("operation_id_");
            entity.Property(e => e.OperationType)
                .HasMaxLength(64)
                .HasColumnName("operation_type_");
            entity.Property(e => e.OrgValue)
                .HasMaxLength(4000)
                .HasColumnName("org_value_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.Property)
                .HasMaxLength(64)
                .HasColumnName("property_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.TaskId)
                .HasMaxLength(64)
                .HasColumnName("task_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Timestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp_");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id_");
        });

        modelBuilder.Entity<ActHiProcinst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_procinst_pkey");

            entity.ToTable("act_hi_procinst");

            entity.HasIndex(e => e.ProcInstId, "act_hi_procinst_proc_inst_id__key").IsUnique();

            entity.HasIndex(e => new { e.ProcDefId, e.EndTime }, "act_idx_hi_pi_pdefid_end_time");

            entity.HasIndex(e => e.BusinessKey, "act_idx_hi_pro_i_buskey");

            entity.HasIndex(e => e.EndTime, "act_idx_hi_pro_inst_end");

            entity.HasIndex(e => e.ProcDefKey, "act_idx_hi_pro_inst_proc_def_key");

            entity.HasIndex(e => new { e.StartTime, e.EndTime }, "act_idx_hi_pro_inst_proc_time");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_pro_inst_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_pro_inst_root_pi");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_pro_inst_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.BusinessKey)
                .HasMaxLength(255)
                .HasColumnName("business_key_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.DeleteReason)
                .HasMaxLength(4000)
                .HasColumnName("delete_reason_");
            entity.Property(e => e.Duration).HasColumnName("duration_");
            entity.Property(e => e.EndActId)
                .HasMaxLength(255)
                .HasColumnName("end_act_id_");
            entity.Property(e => e.EndTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_time_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.StartActId)
                .HasMaxLength(255)
                .HasColumnName("start_act_id_");
            entity.Property(e => e.StartTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_time_");
            entity.Property(e => e.StartUserId)
                .HasMaxLength(255)
                .HasColumnName("start_user_id_");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .HasColumnName("state_");
            entity.Property(e => e.SuperCaseInstanceId)
                .HasMaxLength(64)
                .HasColumnName("super_case_instance_id_");
            entity.Property(e => e.SuperProcessInstanceId)
                .HasMaxLength(64)
                .HasColumnName("super_process_instance_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
        });

        modelBuilder.Entity<ActHiTaskinst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_taskinst_pkey");

            entity.ToTable("act_hi_taskinst");

            entity.HasIndex(e => e.EndTime, "act_idx_hi_task_inst_end");

            entity.HasIndex(e => e.ProcDefKey, "act_idx_hi_task_inst_proc_def_key");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_task_inst_rm_time");

            entity.HasIndex(e => e.StartTime, "act_idx_hi_task_inst_start");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_task_inst_tenant_id");

            entity.HasIndex(e => e.ProcInstId, "act_idx_hi_taskinst_procinst");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_taskinst_root_pi");

            entity.HasIndex(e => new { e.Id, e.ProcInstId }, "act_idx_hi_taskinstid_procinst");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActInstId)
                .HasMaxLength(64)
                .HasColumnName("act_inst_id_");
            entity.Property(e => e.Assignee)
                .HasMaxLength(255)
                .HasColumnName("assignee_");
            entity.Property(e => e.CaseDefId)
                .HasMaxLength(64)
                .HasColumnName("case_def_id_");
            entity.Property(e => e.CaseDefKey)
                .HasMaxLength(255)
                .HasColumnName("case_def_key_");
            entity.Property(e => e.CaseExecutionId)
                .HasMaxLength(64)
                .HasColumnName("case_execution_id_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.DeleteReason)
                .HasMaxLength(4000)
                .HasColumnName("delete_reason_");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("description_");
            entity.Property(e => e.DueDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("due_date_");
            entity.Property(e => e.Duration).HasColumnName("duration_");
            entity.Property(e => e.EndTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_time_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.FollowUpDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("follow_up_date_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.Owner)
                .HasMaxLength(255)
                .HasColumnName("owner_");
            entity.Property(e => e.ParentTaskId)
                .HasMaxLength(64)
                .HasColumnName("parent_task_id_");
            entity.Property(e => e.Priority).HasColumnName("priority_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.StartTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_time_");
            entity.Property(e => e.TaskDefKey)
                .HasMaxLength(255)
                .HasColumnName("task_def_key_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
        });

        modelBuilder.Entity<ActHiVarinst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_hi_varinst_pkey");

            entity.ToTable("act_hi_varinst");

            entity.HasIndex(e => e.CaseInstId, "act_idx_hi_casevar_case_inst");

            entity.HasIndex(e => new { e.Name, e.VarType }, "act_idx_hi_procvar_name_type");

            entity.HasIndex(e => e.ProcInstId, "act_idx_hi_procvar_proc_inst");

            entity.HasIndex(e => e.ProcDefKey, "act_idx_hi_var_inst_proc_def_key");

            entity.HasIndex(e => e.TenantId, "act_idx_hi_var_inst_tenant_id");

            entity.HasIndex(e => new { e.ProcInstId, e.Name, e.VarType }, "act_idx_hi_var_pi_name_type");

            entity.HasIndex(e => e.ActInstId, "act_idx_hi_varinst_act_inst_id");

            entity.HasIndex(e => e.BytearrayId, "act_idx_hi_varinst_bytear");

            entity.HasIndex(e => e.Name, "act_idx_hi_varinst_name");

            entity.HasIndex(e => e.RemovalTime, "act_idx_hi_varinst_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_hi_varinst_root_pi");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActInstId)
                .HasMaxLength(64)
                .HasColumnName("act_inst_id_");
            entity.Property(e => e.BytearrayId)
                .HasMaxLength(64)
                .HasColumnName("bytearray_id_");
            entity.Property(e => e.CaseDefId)
                .HasMaxLength(64)
                .HasColumnName("case_def_id_");
            entity.Property(e => e.CaseDefKey)
                .HasMaxLength(255)
                .HasColumnName("case_def_key_");
            entity.Property(e => e.CaseExecutionId)
                .HasMaxLength(64)
                .HasColumnName("case_execution_id_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time_");
            entity.Property(e => e.Double).HasColumnName("double_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.Long).HasColumnName("long_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.State)
                .HasMaxLength(20)
                .HasColumnName("state_");
            entity.Property(e => e.TaskId)
                .HasMaxLength(64)
                .HasColumnName("task_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Text)
                .HasMaxLength(4000)
                .HasColumnName("text_");
            entity.Property(e => e.Text2)
                .HasMaxLength(4000)
                .HasColumnName("text2_");
            entity.Property(e => e.VarType)
                .HasMaxLength(100)
                .HasColumnName("var_type_");
        });

        modelBuilder.Entity<ActIdGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_id_group_pkey");

            entity.ToTable("act_id_group");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");
        });

        modelBuilder.Entity<ActIdInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_id_info_pkey");

            entity.ToTable("act_id_info");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key_");
            entity.Property(e => e.ParentId)
                .HasMaxLength(255)
                .HasColumnName("parent_id_");
            entity.Property(e => e.Password).HasColumnName("password_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.Type)
                .HasMaxLength(64)
                .HasColumnName("type_");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasColumnName("user_id_");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value_");
        });

        modelBuilder.Entity<ActIdTenant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_id_tenant_pkey");

            entity.ToTable("act_id_tenant");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
        });

        modelBuilder.Entity<ActIdTenantMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_id_tenant_member_pkey");

            entity.ToTable("act_id_tenant_member");

            entity.HasIndex(e => e.TenantId, "act_idx_tenant_memb");

            entity.HasIndex(e => e.GroupId, "act_idx_tenant_memb_group");

            entity.HasIndex(e => e.UserId, "act_idx_tenant_memb_user");

            entity.HasIndex(e => new { e.TenantId, e.GroupId }, "act_uniq_tenant_memb_group").IsUnique();

            entity.HasIndex(e => new { e.TenantId, e.UserId }, "act_uniq_tenant_memb_user").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.GroupId)
                .HasMaxLength(64)
                .HasColumnName("group_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .HasColumnName("user_id_");

            entity.HasOne(d => d.Group).WithMany(p => p.ActIdTenantMembers)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("act_fk_tenant_memb_group");

            entity.HasOne(d => d.Tenant).WithMany(p => p.ActIdTenantMembers)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("act_fk_tenant_memb");

            entity.HasOne(d => d.User).WithMany(p => p.ActIdTenantMembers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("act_fk_tenant_memb_user");
        });

        modelBuilder.Entity<ActIdUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_id_user_pkey");

            entity.ToTable("act_id_user");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Attempts).HasColumnName("attempts_");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email_");
            entity.Property(e => e.First)
                .HasMaxLength(255)
                .HasColumnName("first_");
            entity.Property(e => e.Last)
                .HasMaxLength(255)
                .HasColumnName("last_");
            entity.Property(e => e.LockExpTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lock_exp_time_");
            entity.Property(e => e.PictureId)
                .HasMaxLength(64)
                .HasColumnName("picture_id_");
            entity.Property(e => e.Pwd)
                .HasMaxLength(255)
                .HasColumnName("pwd_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.Salt)
                .HasMaxLength(255)
                .HasColumnName("salt_");

            entity.HasMany(d => d.Groups).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "ActIdMembership",
                    r => r.HasOne<ActIdGroup>().WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("act_fk_memb_group"),
                    l => l.HasOne<ActIdUser>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("act_fk_memb_user"),
                    j =>
                    {
                        j.HasKey("UserId", "GroupId").HasName("act_id_membership_pkey");
                        j.ToTable("act_id_membership");
                        j.HasIndex(new[] { "GroupId" }, "act_idx_memb_group");
                        j.HasIndex(new[] { "UserId" }, "act_idx_memb_user");
                    });
        });

        modelBuilder.Entity<ActReCamformdef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_re_camformdef_pkey");

            entity.ToTable("act_re_camformdef");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(64)
                .HasColumnName("deployment_id_");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key_");
            entity.Property(e => e.ResourceName)
                .HasMaxLength(4000)
                .HasColumnName("resource_name_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Version).HasColumnName("version_");
        });

        modelBuilder.Entity<ActReCaseDef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_re_case_def_pkey");

            entity.ToTable("act_re_case_def");

            entity.HasIndex(e => e.TenantId, "act_idx_case_def_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category_");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(64)
                .HasColumnName("deployment_id_");
            entity.Property(e => e.DgrmResourceName)
                .HasMaxLength(4000)
                .HasColumnName("dgrm_resource_name_");
            entity.Property(e => e.HistoryTtl).HasColumnName("history_ttl_");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.ResourceName)
                .HasMaxLength(4000)
                .HasColumnName("resource_name_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Version).HasColumnName("version_");
        });

        modelBuilder.Entity<ActReDecisionDef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_re_decision_def_pkey");

            entity.ToTable("act_re_decision_def");

            entity.HasIndex(e => e.DecReqId, "act_idx_dec_def_req_id");

            entity.HasIndex(e => e.TenantId, "act_idx_dec_def_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category_");
            entity.Property(e => e.DecReqId)
                .HasMaxLength(64)
                .HasColumnName("dec_req_id_");
            entity.Property(e => e.DecReqKey)
                .HasMaxLength(255)
                .HasColumnName("dec_req_key_");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(64)
                .HasColumnName("deployment_id_");
            entity.Property(e => e.DgrmResourceName)
                .HasMaxLength(4000)
                .HasColumnName("dgrm_resource_name_");
            entity.Property(e => e.HistoryTtl).HasColumnName("history_ttl_");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.ResourceName)
                .HasMaxLength(4000)
                .HasColumnName("resource_name_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Version).HasColumnName("version_");
            entity.Property(e => e.VersionTag)
                .HasMaxLength(64)
                .HasColumnName("version_tag_");

            entity.HasOne(d => d.DecReq).WithMany(p => p.ActReDecisionDefs)
                .HasForeignKey(d => d.DecReqId)
                .HasConstraintName("act_fk_dec_req");
        });

        modelBuilder.Entity<ActReDecisionReqDef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_re_decision_req_def_pkey");

            entity.ToTable("act_re_decision_req_def");

            entity.HasIndex(e => e.TenantId, "act_idx_dec_req_def_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category_");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(64)
                .HasColumnName("deployment_id_");
            entity.Property(e => e.DgrmResourceName)
                .HasMaxLength(4000)
                .HasColumnName("dgrm_resource_name_");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.ResourceName)
                .HasMaxLength(4000)
                .HasColumnName("resource_name_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Version).HasColumnName("version_");
        });

        modelBuilder.Entity<ActReDeployment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_re_deployment_pkey");

            entity.ToTable("act_re_deployment");

            entity.HasIndex(e => e.Name, "act_idx_deployment_name");

            entity.HasIndex(e => e.TenantId, "act_idx_deployment_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.DeployTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("deploy_time_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
        });

        modelBuilder.Entity<ActReProcdef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_re_procdef_pkey");

            entity.ToTable("act_re_procdef");

            entity.HasIndex(e => e.DeploymentId, "act_idx_procdef_deployment_id");

            entity.HasIndex(e => e.TenantId, "act_idx_procdef_tenant_id");

            entity.HasIndex(e => e.VersionTag, "act_idx_procdef_ver_tag");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category_");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(64)
                .HasColumnName("deployment_id_");
            entity.Property(e => e.DgrmResourceName)
                .HasMaxLength(4000)
                .HasColumnName("dgrm_resource_name_");
            entity.Property(e => e.HasStartFormKey).HasColumnName("has_start_form_key_");
            entity.Property(e => e.HistoryTtl).HasColumnName("history_ttl_");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("key_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.ResourceName)
                .HasMaxLength(4000)
                .HasColumnName("resource_name_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.Startable)
                .IsRequired()
                .HasDefaultValueSql("true")
                .HasColumnName("startable_");
            entity.Property(e => e.SuspensionState).HasColumnName("suspension_state_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Version).HasColumnName("version_");
            entity.Property(e => e.VersionTag)
                .HasMaxLength(64)
                .HasColumnName("version_tag_");
        });

        modelBuilder.Entity<ActRuAuthorization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_authorization_pkey");

            entity.ToTable("act_ru_authorization");

            entity.HasIndex(e => e.GroupId, "act_idx_auth_group_id");

            entity.HasIndex(e => e.ResourceId, "act_idx_auth_resource_id");

            entity.HasIndex(e => e.RemovalTime, "act_idx_auth_rm_time");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_auth_root_pi");

            entity.HasIndex(e => new { e.Type, e.GroupId, e.ResourceType, e.ResourceId }, "act_uniq_auth_group").IsUnique();

            entity.HasIndex(e => new { e.Type, e.UserId, e.ResourceType, e.ResourceId }, "act_uniq_auth_user").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.GroupId)
                .HasMaxLength(255)
                .HasColumnName("group_id_");
            entity.Property(e => e.Perms).HasColumnName("perms_");
            entity.Property(e => e.RemovalTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("removal_time_");
            entity.Property(e => e.ResourceId)
                .HasMaxLength(255)
                .HasColumnName("resource_id_");
            entity.Property(e => e.ResourceType).HasColumnName("resource_type_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.Type).HasColumnName("type_");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id_");
        });

        modelBuilder.Entity<ActRuBatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_batch_pkey");

            entity.ToTable("act_ru_batch");

            entity.HasIndex(e => e.BatchJobDefId, "act_idx_batch_job_def");

            entity.HasIndex(e => e.MonitorJobDefId, "act_idx_batch_monitor_job_def");

            entity.HasIndex(e => e.SeedJobDefId, "act_idx_batch_seed_job_def");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.BatchJobDefId)
                .HasMaxLength(64)
                .HasColumnName("batch_job_def_id_");
            entity.Property(e => e.Configuration)
                .HasMaxLength(255)
                .HasColumnName("configuration_");
            entity.Property(e => e.CreateUserId)
                .HasMaxLength(255)
                .HasColumnName("create_user_id_");
            entity.Property(e => e.InvocationsPerJob).HasColumnName("invocations_per_job_");
            entity.Property(e => e.JobsCreated).HasColumnName("jobs_created_");
            entity.Property(e => e.JobsPerSeed).HasColumnName("jobs_per_seed_");
            entity.Property(e => e.MonitorJobDefId)
                .HasMaxLength(64)
                .HasColumnName("monitor_job_def_id_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.SeedJobDefId)
                .HasMaxLength(64)
                .HasColumnName("seed_job_def_id_");
            entity.Property(e => e.SuspensionState).HasColumnName("suspension_state_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.TotalJobs).HasColumnName("total_jobs_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");

            entity.HasOne(d => d.BatchJobDef).WithMany(p => p.ActRuBatchBatchJobDefs)
                .HasForeignKey(d => d.BatchJobDefId)
                .HasConstraintName("act_fk_batch_job_def");

            entity.HasOne(d => d.MonitorJobDef).WithMany(p => p.ActRuBatchMonitorJobDefs)
                .HasForeignKey(d => d.MonitorJobDefId)
                .HasConstraintName("act_fk_batch_monitor_job_def");

            entity.HasOne(d => d.SeedJobDef).WithMany(p => p.ActRuBatchSeedJobDefs)
                .HasForeignKey(d => d.SeedJobDefId)
                .HasConstraintName("act_fk_batch_seed_job_def");
        });

        modelBuilder.Entity<ActRuCaseExecution>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_case_execution_pkey");

            entity.ToTable("act_ru_case_execution");

            entity.HasIndex(e => e.CaseDefId, "act_idx_case_exe_case_def");

            entity.HasIndex(e => e.CaseInstId, "act_idx_case_exe_case_inst");

            entity.HasIndex(e => e.ParentId, "act_idx_case_exe_parent");

            entity.HasIndex(e => e.BusinessKey, "act_idx_case_exec_buskey");

            entity.HasIndex(e => e.TenantId, "act_idx_case_exec_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActId)
                .HasMaxLength(255)
                .HasColumnName("act_id_");
            entity.Property(e => e.BusinessKey)
                .HasMaxLength(255)
                .HasColumnName("business_key_");
            entity.Property(e => e.CaseDefId)
                .HasMaxLength(64)
                .HasColumnName("case_def_id_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.CurrentState).HasColumnName("current_state_");
            entity.Property(e => e.ParentId)
                .HasMaxLength(64)
                .HasColumnName("parent_id_");
            entity.Property(e => e.PrevState).HasColumnName("prev_state_");
            entity.Property(e => e.Required).HasColumnName("required_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.SuperCaseExec)
                .HasMaxLength(64)
                .HasColumnName("super_case_exec_");
            entity.Property(e => e.SuperExec)
                .HasMaxLength(64)
                .HasColumnName("super_exec_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");

            entity.HasOne(d => d.CaseDef).WithMany(p => p.ActRuCaseExecutions)
                .HasForeignKey(d => d.CaseDefId)
                .HasConstraintName("act_fk_case_exe_case_def");

            entity.HasOne(d => d.CaseInst).WithMany(p => p.InverseCaseInst)
                .HasForeignKey(d => d.CaseInstId)
                .HasConstraintName("act_fk_case_exe_case_inst");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("act_fk_case_exe_parent");
        });

        modelBuilder.Entity<ActRuCaseSentryPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_case_sentry_part_pkey");

            entity.ToTable("act_ru_case_sentry_part");

            entity.HasIndex(e => e.CaseExecId, "act_idx_case_sentry_case_exec");

            entity.HasIndex(e => e.CaseInstId, "act_idx_case_sentry_case_inst");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.CaseExecId)
                .HasMaxLength(64)
                .HasColumnName("case_exec_id_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.Satisfied).HasColumnName("satisfied_");
            entity.Property(e => e.SentryId)
                .HasMaxLength(255)
                .HasColumnName("sentry_id_");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source_");
            entity.Property(e => e.SourceCaseExecId)
                .HasMaxLength(64)
                .HasColumnName("source_case_exec_id_");
            entity.Property(e => e.StandardEvent)
                .HasMaxLength(255)
                .HasColumnName("standard_event_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");
            entity.Property(e => e.VariableEvent)
                .HasMaxLength(255)
                .HasColumnName("variable_event_");
            entity.Property(e => e.VariableName)
                .HasMaxLength(255)
                .HasColumnName("variable_name_");

            entity.HasOne(d => d.CaseExec).WithMany(p => p.ActRuCaseSentryPartCaseExecs)
                .HasForeignKey(d => d.CaseExecId)
                .HasConstraintName("act_fk_case_sentry_case_exec");

            entity.HasOne(d => d.CaseInst).WithMany(p => p.ActRuCaseSentryPartCaseInsts)
                .HasForeignKey(d => d.CaseInstId)
                .HasConstraintName("act_fk_case_sentry_case_inst");
        });

        modelBuilder.Entity<ActRuEventSubscr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_event_subscr_pkey");

            entity.ToTable("act_ru_event_subscr");

            entity.HasIndex(e => e.ExecutionId, "act_idx_event_subscr");

            entity.HasIndex(e => e.Configuration, "act_idx_event_subscr_config_");

            entity.HasIndex(e => e.EventName, "act_idx_event_subscr_evt_name");

            entity.HasIndex(e => e.TenantId, "act_idx_event_subscr_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActivityId)
                .HasMaxLength(255)
                .HasColumnName("activity_id_");
            entity.Property(e => e.Configuration)
                .HasMaxLength(255)
                .HasColumnName("configuration_");
            entity.Property(e => e.Created)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_");
            entity.Property(e => e.EventName)
                .HasMaxLength(255)
                .HasColumnName("event_name_");
            entity.Property(e => e.EventType)
                .HasMaxLength(255)
                .HasColumnName("event_type_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");

            entity.HasOne(d => d.Execution).WithMany(p => p.ActRuEventSubscrs)
                .HasForeignKey(d => d.ExecutionId)
                .HasConstraintName("act_fk_event_exec");
        });

        modelBuilder.Entity<ActRuExecution>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_execution_pkey");

            entity.ToTable("act_ru_execution");

            entity.HasIndex(e => e.ParentId, "act_idx_exe_parent");

            entity.HasIndex(e => e.ProcDefId, "act_idx_exe_procdef");

            entity.HasIndex(e => e.ProcInstId, "act_idx_exe_procinst");

            entity.HasIndex(e => e.RootProcInstId, "act_idx_exe_root_pi");

            entity.HasIndex(e => e.SuperExec, "act_idx_exe_super");

            entity.HasIndex(e => e.BusinessKey, "act_idx_exec_buskey");

            entity.HasIndex(e => e.TenantId, "act_idx_exec_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActId)
                .HasMaxLength(255)
                .HasColumnName("act_id_");
            entity.Property(e => e.ActInstId)
                .HasMaxLength(64)
                .HasColumnName("act_inst_id_");
            entity.Property(e => e.BusinessKey)
                .HasMaxLength(255)
                .HasColumnName("business_key_");
            entity.Property(e => e.CachedEntState).HasColumnName("cached_ent_state_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.IsActive).HasColumnName("is_active_");
            entity.Property(e => e.IsConcurrent).HasColumnName("is_concurrent_");
            entity.Property(e => e.IsEventScope).HasColumnName("is_event_scope_");
            entity.Property(e => e.IsScope).HasColumnName("is_scope_");
            entity.Property(e => e.ParentId)
                .HasMaxLength(64)
                .HasColumnName("parent_id_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.RootProcInstId)
                .HasMaxLength(64)
                .HasColumnName("root_proc_inst_id_");
            entity.Property(e => e.SequenceCounter).HasColumnName("sequence_counter_");
            entity.Property(e => e.SuperCaseExec)
                .HasMaxLength(64)
                .HasColumnName("super_case_exec_");
            entity.Property(e => e.SuperExec)
                .HasMaxLength(64)
                .HasColumnName("super_exec_");
            entity.Property(e => e.SuspensionState).HasColumnName("suspension_state_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("act_fk_exe_parent");

            entity.HasOne(d => d.ProcDef).WithMany(p => p.ActRuExecutions)
                .HasForeignKey(d => d.ProcDefId)
                .HasConstraintName("act_fk_exe_procdef");

            entity.HasOne(d => d.ProcInst).WithMany(p => p.InverseProcInst)
                .HasForeignKey(d => d.ProcInstId)
                .HasConstraintName("act_fk_exe_procinst");

            entity.HasOne(d => d.SuperExecNavigation).WithMany(p => p.InverseSuperExecNavigation)
                .HasForeignKey(d => d.SuperExec)
                .HasConstraintName("act_fk_exe_super");
        });

        modelBuilder.Entity<ActRuExtTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_ext_task_pkey");

            entity.ToTable("act_ru_ext_task");

            entity.HasIndex(e => e.ErrorDetailsId, "act_idx_ext_task_err_details");

            entity.HasIndex(e => e.ExecutionId, "act_idx_ext_task_exec");

            entity.HasIndex(e => e.Priority, "act_idx_ext_task_priority");

            entity.HasIndex(e => e.TenantId, "act_idx_ext_task_tenant_id");

            entity.HasIndex(e => e.TopicName, "act_idx_ext_task_topic");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActId)
                .HasMaxLength(255)
                .HasColumnName("act_id_");
            entity.Property(e => e.ActInstId)
                .HasMaxLength(64)
                .HasColumnName("act_inst_id_");
            entity.Property(e => e.ErrorDetailsId)
                .HasMaxLength(64)
                .HasColumnName("error_details_id_");
            entity.Property(e => e.ErrorMsg)
                .HasMaxLength(4000)
                .HasColumnName("error_msg_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.LastFailureLogId)
                .HasMaxLength(64)
                .HasColumnName("last_failure_log_id_");
            entity.Property(e => e.LockExpTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lock_exp_time_");
            entity.Property(e => e.Priority).HasColumnName("priority_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.Retries).HasColumnName("retries_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.SuspensionState).HasColumnName("suspension_state_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.TopicName)
                .HasMaxLength(255)
                .HasColumnName("topic_name_");
            entity.Property(e => e.WorkerId)
                .HasMaxLength(255)
                .HasColumnName("worker_id_");

            entity.HasOne(d => d.ErrorDetails).WithMany(p => p.ActRuExtTasks)
                .HasForeignKey(d => d.ErrorDetailsId)
                .HasConstraintName("act_fk_ext_task_error_details");

            entity.HasOne(d => d.Execution).WithMany(p => p.ActRuExtTasks)
                .HasForeignKey(d => d.ExecutionId)
                .HasConstraintName("act_fk_ext_task_exe");
        });

        modelBuilder.Entity<ActRuFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_filter_pkey");

            entity.ToTable("act_ru_filter");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.Owner)
                .HasMaxLength(255)
                .HasColumnName("owner_");
            entity.Property(e => e.Properties).HasColumnName("properties_");
            entity.Property(e => e.Query).HasColumnName("query_");
            entity.Property(e => e.ResourceType)
                .HasMaxLength(255)
                .HasColumnName("resource_type_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
        });

        modelBuilder.Entity<ActRuIdentitylink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_identitylink_pkey");

            entity.ToTable("act_ru_identitylink");

            entity.HasIndex(e => e.ProcDefId, "act_idx_athrz_procedef");

            entity.HasIndex(e => e.GroupId, "act_idx_ident_lnk_group");

            entity.HasIndex(e => e.UserId, "act_idx_ident_lnk_user");

            entity.HasIndex(e => e.TaskId, "act_idx_tskass_task");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.GroupId)
                .HasMaxLength(255)
                .HasColumnName("group_id_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.TaskId)
                .HasMaxLength(64)
                .HasColumnName("task_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id_");

            entity.HasOne(d => d.ProcDef).WithMany(p => p.ActRuIdentitylinks)
                .HasForeignKey(d => d.ProcDefId)
                .HasConstraintName("act_fk_athrz_procedef");

            entity.HasOne(d => d.Task).WithMany(p => p.ActRuIdentitylinks)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("act_fk_tskass_task");
        });

        modelBuilder.Entity<ActRuIncident>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_incident_pkey");

            entity.ToTable("act_ru_incident");

            entity.HasIndex(e => e.CauseIncidentId, "act_idx_inc_causeincid");

            entity.HasIndex(e => e.Configuration, "act_idx_inc_configuration");

            entity.HasIndex(e => e.ExecutionId, "act_idx_inc_exid");

            entity.HasIndex(e => e.JobDefId, "act_idx_inc_job_def");

            entity.HasIndex(e => e.ProcDefId, "act_idx_inc_procdefid");

            entity.HasIndex(e => e.ProcInstId, "act_idx_inc_procinstid");

            entity.HasIndex(e => e.RootCauseIncidentId, "act_idx_inc_rootcauseincid");

            entity.HasIndex(e => e.TenantId, "act_idx_inc_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActivityId)
                .HasMaxLength(255)
                .HasColumnName("activity_id_");
            entity.Property(e => e.Annotation)
                .HasMaxLength(4000)
                .HasColumnName("annotation_");
            entity.Property(e => e.CauseIncidentId)
                .HasMaxLength(64)
                .HasColumnName("cause_incident_id_");
            entity.Property(e => e.Configuration)
                .HasMaxLength(255)
                .HasColumnName("configuration_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.FailedActivityId)
                .HasMaxLength(255)
                .HasColumnName("failed_activity_id_");
            entity.Property(e => e.IncidentMsg)
                .HasMaxLength(4000)
                .HasColumnName("incident_msg_");
            entity.Property(e => e.IncidentTimestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("incident_timestamp_");
            entity.Property(e => e.IncidentType)
                .HasMaxLength(255)
                .HasColumnName("incident_type_");
            entity.Property(e => e.JobDefId)
                .HasMaxLength(64)
                .HasColumnName("job_def_id_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.RootCauseIncidentId)
                .HasMaxLength(64)
                .HasColumnName("root_cause_incident_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");

            entity.HasOne(d => d.CauseIncident).WithMany(p => p.InverseCauseIncident)
                .HasForeignKey(d => d.CauseIncidentId)
                .HasConstraintName("act_fk_inc_cause");

            entity.HasOne(d => d.Execution).WithMany(p => p.ActRuIncidentExecutions)
                .HasForeignKey(d => d.ExecutionId)
                .HasConstraintName("act_fk_inc_exe");

            entity.HasOne(d => d.JobDef).WithMany(p => p.ActRuIncidents)
                .HasForeignKey(d => d.JobDefId)
                .HasConstraintName("act_fk_inc_job_def");

            entity.HasOne(d => d.ProcDef).WithMany(p => p.ActRuIncidents)
                .HasForeignKey(d => d.ProcDefId)
                .HasConstraintName("act_fk_inc_procdef");

            entity.HasOne(d => d.ProcInst).WithMany(p => p.ActRuIncidentProcInsts)
                .HasForeignKey(d => d.ProcInstId)
                .HasConstraintName("act_fk_inc_procinst");

            entity.HasOne(d => d.RootCauseIncident).WithMany(p => p.InverseRootCauseIncident)
                .HasForeignKey(d => d.RootCauseIncidentId)
                .HasConstraintName("act_fk_inc_rcause");
        });

        modelBuilder.Entity<ActRuJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_job_pkey");

            entity.ToTable("act_ru_job");

            entity.HasIndex(e => e.ExceptionStackId, "act_idx_job_exception");

            entity.HasIndex(e => e.ExecutionId, "act_idx_job_execution_id");

            entity.HasIndex(e => new { e.HandlerType, e.HandlerCfg }, "act_idx_job_handler");

            entity.HasIndex(e => e.HandlerType, "act_idx_job_handler_type");

            entity.HasIndex(e => e.JobDefId, "act_idx_job_job_def_id");

            entity.HasIndex(e => e.ProcessInstanceId, "act_idx_job_procinst");

            entity.HasIndex(e => e.TenantId, "act_idx_job_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time_");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(64)
                .HasColumnName("deployment_id_");
            entity.Property(e => e.Duedate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("duedate_");
            entity.Property(e => e.ExceptionMsg)
                .HasMaxLength(4000)
                .HasColumnName("exception_msg_");
            entity.Property(e => e.ExceptionStackId)
                .HasMaxLength(64)
                .HasColumnName("exception_stack_id_");
            entity.Property(e => e.Exclusive).HasColumnName("exclusive_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.FailedActId)
                .HasMaxLength(255)
                .HasColumnName("failed_act_id_");
            entity.Property(e => e.HandlerCfg)
                .HasMaxLength(4000)
                .HasColumnName("handler_cfg_");
            entity.Property(e => e.HandlerType)
                .HasMaxLength(255)
                .HasColumnName("handler_type_");
            entity.Property(e => e.JobDefId)
                .HasMaxLength(64)
                .HasColumnName("job_def_id_");
            entity.Property(e => e.LastFailureLogId)
                .HasMaxLength(64)
                .HasColumnName("last_failure_log_id_");
            entity.Property(e => e.LockExpTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lock_exp_time_");
            entity.Property(e => e.LockOwner)
                .HasMaxLength(255)
                .HasColumnName("lock_owner_");
            entity.Property(e => e.Priority).HasColumnName("priority_");
            entity.Property(e => e.ProcessDefId)
                .HasMaxLength(64)
                .HasColumnName("process_def_id_");
            entity.Property(e => e.ProcessDefKey)
                .HasMaxLength(255)
                .HasColumnName("process_def_key_");
            entity.Property(e => e.ProcessInstanceId)
                .HasMaxLength(64)
                .HasColumnName("process_instance_id_");
            entity.Property(e => e.Repeat)
                .HasMaxLength(255)
                .HasColumnName("repeat_");
            entity.Property(e => e.RepeatOffset)
                .HasDefaultValueSql("0")
                .HasColumnName("repeat_offset_");
            entity.Property(e => e.Retries).HasColumnName("retries_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.SequenceCounter).HasColumnName("sequence_counter_");
            entity.Property(e => e.SuspensionState)
                .HasDefaultValueSql("1")
                .HasColumnName("suspension_state_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");

            entity.HasOne(d => d.ExceptionStack).WithMany(p => p.ActRuJobs)
                .HasForeignKey(d => d.ExceptionStackId)
                .HasConstraintName("act_fk_job_exception");
        });

        modelBuilder.Entity<ActRuJobdef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_jobdef_pkey");

            entity.ToTable("act_ru_jobdef");

            entity.HasIndex(e => e.ProcDefId, "act_idx_jobdef_proc_def_id");

            entity.HasIndex(e => e.TenantId, "act_idx_jobdef_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.ActId)
                .HasMaxLength(255)
                .HasColumnName("act_id_");
            entity.Property(e => e.DeploymentId)
                .HasMaxLength(64)
                .HasColumnName("deployment_id_");
            entity.Property(e => e.JobConfiguration)
                .HasMaxLength(255)
                .HasColumnName("job_configuration_");
            entity.Property(e => e.JobPriority).HasColumnName("job_priority_");
            entity.Property(e => e.JobType)
                .HasMaxLength(255)
                .HasColumnName("job_type_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcDefKey)
                .HasMaxLength(255)
                .HasColumnName("proc_def_key_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.SuspensionState).HasColumnName("suspension_state_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
        });

        modelBuilder.Entity<ActRuMeterLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_meter_log_pkey");

            entity.ToTable("act_ru_meter_log");

            entity.HasIndex(e => new { e.Name, e.Timestamp }, "act_idx_meter_log");

            entity.HasIndex(e => e.Milliseconds, "act_idx_meter_log_ms");

            entity.HasIndex(e => new { e.Name, e.Milliseconds }, "act_idx_meter_log_name_ms");

            entity.HasIndex(e => new { e.Name, e.Reporter, e.Milliseconds }, "act_idx_meter_log_report");

            entity.HasIndex(e => e.Timestamp, "act_idx_meter_log_time");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Milliseconds)
                .HasDefaultValueSql("0")
                .HasColumnName("milliseconds_");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name_");
            entity.Property(e => e.Reporter)
                .HasMaxLength(255)
                .HasColumnName("reporter_");
            entity.Property(e => e.Timestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp_");
            entity.Property(e => e.Value).HasColumnName("value_");
        });

        modelBuilder.Entity<ActRuTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_task_pkey");

            entity.ToTable("act_ru_task");

            entity.HasIndex(e => e.Assignee, "act_idx_task_assignee");

            entity.HasIndex(e => e.CaseDefId, "act_idx_task_case_def_id");

            entity.HasIndex(e => e.CaseExecutionId, "act_idx_task_case_exec");

            entity.HasIndex(e => e.CreateTime, "act_idx_task_create");

            entity.HasIndex(e => e.ExecutionId, "act_idx_task_exec");

            entity.HasIndex(e => e.Owner, "act_idx_task_owner");

            entity.HasIndex(e => e.ProcDefId, "act_idx_task_procdef");

            entity.HasIndex(e => e.ProcInstId, "act_idx_task_procinst");

            entity.HasIndex(e => e.TenantId, "act_idx_task_tenant_id");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.Assignee)
                .HasMaxLength(255)
                .HasColumnName("assignee_");
            entity.Property(e => e.CaseDefId)
                .HasMaxLength(64)
                .HasColumnName("case_def_id_");
            entity.Property(e => e.CaseExecutionId)
                .HasMaxLength(64)
                .HasColumnName("case_execution_id_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.CreateTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_time_");
            entity.Property(e => e.Delegation)
                .HasMaxLength(64)
                .HasColumnName("delegation_");
            entity.Property(e => e.Description)
                .HasMaxLength(4000)
                .HasColumnName("description_");
            entity.Property(e => e.DueDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("due_date_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.FollowUpDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("follow_up_date_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.Owner)
                .HasMaxLength(255)
                .HasColumnName("owner_");
            entity.Property(e => e.ParentTaskId)
                .HasMaxLength(64)
                .HasColumnName("parent_task_id_");
            entity.Property(e => e.Priority).HasColumnName("priority_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.SuspensionState).HasColumnName("suspension_state_");
            entity.Property(e => e.TaskDefKey)
                .HasMaxLength(255)
                .HasColumnName("task_def_key_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");

            entity.HasOne(d => d.CaseDef).WithMany(p => p.ActRuTasks)
                .HasForeignKey(d => d.CaseDefId)
                .HasConstraintName("act_fk_task_case_def");

            entity.HasOne(d => d.CaseExecution).WithMany(p => p.ActRuTasks)
                .HasForeignKey(d => d.CaseExecutionId)
                .HasConstraintName("act_fk_task_case_exe");

            entity.HasOne(d => d.Execution).WithMany(p => p.ActRuTaskExecutions)
                .HasForeignKey(d => d.ExecutionId)
                .HasConstraintName("act_fk_task_exe");

            entity.HasOne(d => d.ProcDef).WithMany(p => p.ActRuTasks)
                .HasForeignKey(d => d.ProcDefId)
                .HasConstraintName("act_fk_task_procdef");

            entity.HasOne(d => d.ProcInst).WithMany(p => p.ActRuTaskProcInsts)
                .HasForeignKey(d => d.ProcInstId)
                .HasConstraintName("act_fk_task_procinst");
        });

        modelBuilder.Entity<ActRuTaskMeterLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_task_meter_log_pkey");

            entity.ToTable("act_ru_task_meter_log");

            entity.HasIndex(e => e.Timestamp, "act_idx_task_meter_log_time");

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.AssigneeHash).HasColumnName("assignee_hash_");
            entity.Property(e => e.Timestamp)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("timestamp_");
        });

        modelBuilder.Entity<ActRuVariable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("act_ru_variable_pkey");

            entity.ToTable("act_ru_variable");

            entity.HasIndex(e => e.BatchId, "act_idx_batch_id");

            entity.HasIndex(e => e.BytearrayId, "act_idx_var_bytearray");

            entity.HasIndex(e => e.CaseExecutionId, "act_idx_var_case_exe");

            entity.HasIndex(e => e.CaseInstId, "act_idx_var_case_inst_id");

            entity.HasIndex(e => e.ExecutionId, "act_idx_var_exe");

            entity.HasIndex(e => e.ProcInstId, "act_idx_var_procinst");

            entity.HasIndex(e => e.TaskId, "act_idx_variable_task_id");

            entity.HasIndex(e => new { e.TaskId, e.Name, e.Type }, "act_idx_variable_task_name_type");

            entity.HasIndex(e => e.TenantId, "act_idx_variable_tenant_id");

            entity.HasIndex(e => new { e.VarScope, e.Name }, "act_uniq_variable").IsUnique();

            entity.Property(e => e.Id)
                .HasMaxLength(64)
                .HasColumnName("id_");
            entity.Property(e => e.BatchId)
                .HasMaxLength(64)
                .HasColumnName("batch_id_");
            entity.Property(e => e.BytearrayId)
                .HasMaxLength(64)
                .HasColumnName("bytearray_id_");
            entity.Property(e => e.CaseExecutionId)
                .HasMaxLength(64)
                .HasColumnName("case_execution_id_");
            entity.Property(e => e.CaseInstId)
                .HasMaxLength(64)
                .HasColumnName("case_inst_id_");
            entity.Property(e => e.Double).HasColumnName("double_");
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(64)
                .HasColumnName("execution_id_");
            entity.Property(e => e.IsConcurrentLocal).HasColumnName("is_concurrent_local_");
            entity.Property(e => e.Long).HasColumnName("long_");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name_");
            entity.Property(e => e.ProcDefId)
                .HasMaxLength(64)
                .HasColumnName("proc_def_id_");
            entity.Property(e => e.ProcInstId)
                .HasMaxLength(64)
                .HasColumnName("proc_inst_id_");
            entity.Property(e => e.Rev).HasColumnName("rev_");
            entity.Property(e => e.SequenceCounter).HasColumnName("sequence_counter_");
            entity.Property(e => e.TaskId)
                .HasMaxLength(64)
                .HasColumnName("task_id_");
            entity.Property(e => e.TenantId)
                .HasMaxLength(64)
                .HasColumnName("tenant_id_");
            entity.Property(e => e.Text)
                .HasMaxLength(4000)
                .HasColumnName("text_");
            entity.Property(e => e.Text2)
                .HasMaxLength(4000)
                .HasColumnName("text2_");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type_");
            entity.Property(e => e.VarScope)
                .HasMaxLength(64)
                .HasColumnName("var_scope_");

            entity.HasOne(d => d.Batch).WithMany(p => p.ActRuVariables)
                .HasForeignKey(d => d.BatchId)
                .HasConstraintName("act_fk_var_batch");

            entity.HasOne(d => d.Bytearray).WithMany(p => p.ActRuVariables)
                .HasForeignKey(d => d.BytearrayId)
                .HasConstraintName("act_fk_var_bytearray");

            entity.HasOne(d => d.CaseExecution).WithMany(p => p.ActRuVariableCaseExecutions)
                .HasForeignKey(d => d.CaseExecutionId)
                .HasConstraintName("act_fk_var_case_exe");

            entity.HasOne(d => d.CaseInst).WithMany(p => p.ActRuVariableCaseInsts)
                .HasForeignKey(d => d.CaseInstId)
                .HasConstraintName("act_fk_var_case_inst");

            entity.HasOne(d => d.Execution).WithMany(p => p.ActRuVariableExecutions)
                .HasForeignKey(d => d.ExecutionId)
                .HasConstraintName("act_fk_var_exe");

            entity.HasOne(d => d.ProcInst).WithMany(p => p.ActRuVariableProcInsts)
                .HasForeignKey(d => d.ProcInstId)
                .HasConstraintName("act_fk_var_procinst");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
