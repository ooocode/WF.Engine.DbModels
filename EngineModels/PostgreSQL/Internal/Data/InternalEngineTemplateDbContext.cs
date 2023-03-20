using Microsoft.EntityFrameworkCore;
using WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Models;

namespace WF.Engine.DbModels.EngineModels.PostgreSQL.Internal.Data;

public class InternalEngineTemplateDbContext : DbContext
{
    public virtual DbSet<act_ge_bytearray> act_ge_bytearrays { get; set; }

    public virtual DbSet<act_ge_property> act_ge_properties { get; set; }

    public virtual DbSet<act_ge_schema_log> act_ge_schema_logs { get; set; }

    public virtual DbSet<act_hi_actinst> act_hi_actinsts { get; set; }

    public virtual DbSet<act_hi_attachment> act_hi_attachments { get; set; }

    public virtual DbSet<act_hi_batch> act_hi_batches { get; set; }

    public virtual DbSet<act_hi_caseactinst> act_hi_caseactinsts { get; set; }

    public virtual DbSet<act_hi_caseinst> act_hi_caseinsts { get; set; }

    public virtual DbSet<act_hi_comment> act_hi_comments { get; set; }

    public virtual DbSet<act_hi_dec_in> act_hi_dec_ins { get; set; }

    public virtual DbSet<act_hi_dec_out> act_hi_dec_outs { get; set; }

    public virtual DbSet<act_hi_decinst> act_hi_decinsts { get; set; }

    public virtual DbSet<act_hi_detail> act_hi_details { get; set; }

    public virtual DbSet<act_hi_ext_task_log> act_hi_ext_task_logs { get; set; }

    public virtual DbSet<act_hi_identitylink> act_hi_identitylinks { get; set; }

    public virtual DbSet<act_hi_incident> act_hi_incidents { get; set; }

    public virtual DbSet<act_hi_job_log> act_hi_job_logs { get; set; }

    public virtual DbSet<act_hi_op_log> act_hi_op_logs { get; set; }

    public virtual DbSet<act_hi_procinst> act_hi_procinsts { get; set; }

    public virtual DbSet<act_hi_taskinst> act_hi_taskinsts { get; set; }

    public virtual DbSet<act_hi_varinst> act_hi_varinsts { get; set; }

    public virtual DbSet<act_id_group> act_id_groups { get; set; }

    public virtual DbSet<act_id_info> act_id_infos { get; set; }

    public virtual DbSet<act_id_tenant> act_id_tenants { get; set; }

    public virtual DbSet<act_id_tenant_member> act_id_tenant_members { get; set; }

    public virtual DbSet<act_id_user> act_id_users { get; set; }

    public virtual DbSet<act_re_camformdef> act_re_camformdefs { get; set; }

    public virtual DbSet<act_re_case_def> act_re_case_defs { get; set; }

    public virtual DbSet<act_re_decision_def> act_re_decision_defs { get; set; }

    public virtual DbSet<act_re_decision_req_def> act_re_decision_req_defs { get; set; }

    public virtual DbSet<act_re_deployment> act_re_deployments { get; set; }

    public virtual DbSet<act_re_procdef> act_re_procdefs { get; set; }

    public virtual DbSet<act_ru_authorization> act_ru_authorizations { get; set; }

    public virtual DbSet<act_ru_batch> act_ru_batches { get; set; }

    public virtual DbSet<act_ru_case_execution> act_ru_case_executions { get; set; }

    public virtual DbSet<act_ru_case_sentry_part> act_ru_case_sentry_parts { get; set; }

    public virtual DbSet<act_ru_event_subscr> act_ru_event_subscrs { get; set; }

    public virtual DbSet<act_ru_execution> act_ru_executions { get; set; }

    public virtual DbSet<act_ru_ext_task> act_ru_ext_tasks { get; set; }

    public virtual DbSet<act_ru_filter> act_ru_filters { get; set; }

    public virtual DbSet<act_ru_identitylink> act_ru_identitylinks { get; set; }

    public virtual DbSet<act_ru_incident> act_ru_incidents { get; set; }

    public virtual DbSet<act_ru_job> act_ru_jobs { get; set; }

    public virtual DbSet<act_ru_jobdef> act_ru_jobdefs { get; set; }

    public virtual DbSet<act_ru_meter_log> act_ru_meter_logs { get; set; }

    public virtual DbSet<act_ru_task> act_ru_tasks { get; set; }

    public virtual DbSet<act_ru_task_meter_log> act_ru_task_meter_logs { get; set; }

    public virtual DbSet<act_ru_variable> act_ru_variables { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<act_ge_bytearray>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ge_bytearray_pkey");

            entity.ToTable("act_ge_bytearray");

            entity.HasIndex(e => e.deployment_id_, "act_idx_bytear_depl");

            entity.HasIndex(e => e.name_, "act_idx_bytearray_name");

            entity.HasIndex(e => e.removal_time_, "act_idx_bytearray_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_bytearray_root_pi");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.create_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.deployment_id_).HasMaxLength(64);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);

            entity.HasOne(d => d.deployment_id_Navigation).WithMany(p => p.act_ge_bytearrays)
                .HasForeignKey(d => d.deployment_id_)
                .HasConstraintName("act_fk_bytearr_depl");
        });

        modelBuilder.Entity<act_ge_property>(entity =>
        {
            entity.HasKey(e => e.name_).HasName("act_ge_property_pkey");

            entity.ToTable("act_ge_property");

            entity.Property(e => e.name_).HasMaxLength(64);
            entity.Property(e => e.value_).HasMaxLength(300);
        });

        modelBuilder.Entity<act_ge_schema_log>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ge_schema_log_pkey");

            entity.ToTable("act_ge_schema_log");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.timestamp_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.version_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_hi_actinst>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_actinst_pkey");

            entity.ToTable("act_hi_actinst");

            entity.HasIndex(e => new { e.execution_id_, e.act_id_, e.end_time_, e.id_ }, "act_idx_hi_act_inst_comp");

            entity.HasIndex(e => e.end_time_, "act_idx_hi_act_inst_end");

            entity.HasIndex(e => e.proc_def_key_, "act_idx_hi_act_inst_proc_def_key");

            entity.HasIndex(e => new { e.proc_inst_id_, e.act_id_ }, "act_idx_hi_act_inst_procinst");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_act_inst_rm_time");

            entity.HasIndex(e => new { e.start_time_, e.end_time_ }, "act_idx_hi_act_inst_start_end");

            entity.HasIndex(e => new { e.proc_def_id_, e.proc_inst_id_, e.act_id_, e.end_time_, e.act_inst_state_ }, "act_idx_hi_act_inst_stats");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_act_inst_tenant_id");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_actinst_root_pi");

            entity.HasIndex(e => new { e.proc_def_id_, e.end_time_ }, "act_idx_hi_ai_pdefid_end_time");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_id_).HasMaxLength(255);
            entity.Property(e => e.act_name_).HasMaxLength(255);
            entity.Property(e => e.act_type_).HasMaxLength(255);
            entity.Property(e => e.assignee_).HasMaxLength(255);
            entity.Property(e => e.call_case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.call_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.end_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.parent_act_inst_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.start_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.task_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_hi_attachment>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_attachment_pkey");

            entity.ToTable("act_hi_attachment");

            entity.HasIndex(e => e.content_id_, "act_idx_hi_attachment_content");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_hi_attachment_procinst");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_attachment_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_attachment_root_pi");

            entity.HasIndex(e => e.task_id_, "act_idx_hi_attachment_task");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.content_id_).HasMaxLength(64);
            entity.Property(e => e.create_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.description_).HasMaxLength(4000);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.task_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.type_).HasMaxLength(255);
            entity.Property(e => e.url_).HasMaxLength(4000);
            entity.Property(e => e.user_id_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_hi_batch>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_batch_pkey");

            entity.ToTable("act_hi_batch");

            entity.HasIndex(e => e.removal_time_, "act_hi_bat_rm_time");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.batch_job_def_id_).HasMaxLength(64);
            entity.Property(e => e.create_user_id_).HasMaxLength(255);
            entity.Property(e => e.end_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.monitor_job_def_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.seed_job_def_id_).HasMaxLength(64);
            entity.Property(e => e.start_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.type_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_hi_caseactinst>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_caseactinst_pkey");

            entity.ToTable("act_hi_caseactinst");

            entity.HasIndex(e => new { e.case_act_id_, e.end_time_, e.id_ }, "act_idx_hi_cas_a_i_comp");

            entity.HasIndex(e => e.create_time_, "act_idx_hi_cas_a_i_create");

            entity.HasIndex(e => e.end_time_, "act_idx_hi_cas_a_i_end");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_cas_a_i_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.call_case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.call_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.case_act_id_).HasMaxLength(255);
            entity.Property(e => e.case_act_name_).HasMaxLength(255);
            entity.Property(e => e.case_act_type_).HasMaxLength(255);
            entity.Property(e => e.case_def_id_).HasMaxLength(64);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.create_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.end_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.parent_act_inst_id_).HasMaxLength(64);
            entity.Property(e => e.task_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_hi_caseinst>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_caseinst_pkey");

            entity.ToTable("act_hi_caseinst");

            entity.HasIndex(e => e.case_inst_id_, "act_hi_caseinst_case_inst_id__key").IsUnique();

            entity.HasIndex(e => e.business_key_, "act_idx_hi_cas_i_buskey");

            entity.HasIndex(e => e.close_time_, "act_idx_hi_cas_i_close");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_cas_i_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.business_key_).HasMaxLength(255);
            entity.Property(e => e.case_def_id_).HasMaxLength(64);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.close_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.create_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.create_user_id_).HasMaxLength(255);
            entity.Property(e => e.super_case_instance_id_).HasMaxLength(64);
            entity.Property(e => e.super_process_instance_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_hi_comment>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_comment_pkey");

            entity.ToTable("act_hi_comment");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_hi_comment_procinst");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_comment_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_comment_root_pi");

            entity.HasIndex(e => e.task_id_, "act_idx_hi_comment_task");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.action_).HasMaxLength(255);
            entity.Property(e => e.message_).HasMaxLength(4000);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.task_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.type_).HasMaxLength(255);
            entity.Property(e => e.user_id_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_hi_dec_in>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_dec_in_pkey");

            entity.ToTable("act_hi_dec_in");

            entity.HasIndex(e => new { e.dec_inst_id_, e.clause_id_ }, "act_idx_hi_dec_in_clause");

            entity.HasIndex(e => e.dec_inst_id_, "act_idx_hi_dec_in_inst");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_dec_in_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_dec_in_root_pi");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.bytearray_id_).HasMaxLength(64);
            entity.Property(e => e.clause_id_).HasMaxLength(64);
            entity.Property(e => e.clause_name_).HasMaxLength(255);
            entity.Property(e => e.create_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.dec_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.text2_).HasMaxLength(4000);
            entity.Property(e => e.text_).HasMaxLength(4000);
            entity.Property(e => e.var_type_).HasMaxLength(100);
        });

        modelBuilder.Entity<act_hi_dec_out>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_dec_out_pkey");

            entity.ToTable("act_hi_dec_out");

            entity.HasIndex(e => e.dec_inst_id_, "act_idx_hi_dec_out_inst");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_dec_out_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_dec_out_root_pi");

            entity.HasIndex(e => new { e.rule_order_, e.clause_id_ }, "act_idx_hi_dec_out_rule");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.bytearray_id_).HasMaxLength(64);
            entity.Property(e => e.clause_id_).HasMaxLength(64);
            entity.Property(e => e.clause_name_).HasMaxLength(255);
            entity.Property(e => e.create_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.dec_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.rule_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.text2_).HasMaxLength(4000);
            entity.Property(e => e.text_).HasMaxLength(4000);
            entity.Property(e => e.var_name_).HasMaxLength(255);
            entity.Property(e => e.var_type_).HasMaxLength(100);
        });

        modelBuilder.Entity<act_hi_decinst>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_decinst_pkey");

            entity.ToTable("act_hi_decinst");

            entity.HasIndex(e => e.act_id_, "act_idx_hi_dec_inst_act");

            entity.HasIndex(e => e.act_inst_id_, "act_idx_hi_dec_inst_act_inst");

            entity.HasIndex(e => e.case_inst_id_, "act_idx_hi_dec_inst_ci");

            entity.HasIndex(e => e.dec_def_id_, "act_idx_hi_dec_inst_id");

            entity.HasIndex(e => e.dec_def_key_, "act_idx_hi_dec_inst_key");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_hi_dec_inst_pi");

            entity.HasIndex(e => e.dec_req_id_, "act_idx_hi_dec_inst_req_id");

            entity.HasIndex(e => e.dec_req_key_, "act_idx_hi_dec_inst_req_key");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_dec_inst_rm_time");

            entity.HasIndex(e => e.root_dec_inst_id_, "act_idx_hi_dec_inst_root_id");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_dec_inst_root_pi");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_dec_inst_tenant_id");

            entity.HasIndex(e => e.eval_time_, "act_idx_hi_dec_inst_time");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_id_).HasMaxLength(255);
            entity.Property(e => e.act_inst_id_).HasMaxLength(64);
            entity.Property(e => e.case_def_id_).HasMaxLength(64);
            entity.Property(e => e.case_def_key_).HasMaxLength(255);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.dec_def_id_).HasMaxLength(64);
            entity.Property(e => e.dec_def_key_).HasMaxLength(255);
            entity.Property(e => e.dec_def_name_).HasMaxLength(255);
            entity.Property(e => e.dec_req_id_).HasMaxLength(64);
            entity.Property(e => e.dec_req_key_).HasMaxLength(255);
            entity.Property(e => e.eval_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_dec_inst_id_).HasMaxLength(64);
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.user_id_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_hi_detail>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_detail_pkey");

            entity.ToTable("act_hi_detail");

            entity.HasIndex(e => e.act_inst_id_, "act_idx_hi_detail_act_inst");

            entity.HasIndex(e => e.bytearray_id_, "act_idx_hi_detail_bytear");

            entity.HasIndex(e => e.case_execution_id_, "act_idx_hi_detail_case_exec");

            entity.HasIndex(e => e.case_inst_id_, "act_idx_hi_detail_case_inst");

            entity.HasIndex(e => e.name_, "act_idx_hi_detail_name");

            entity.HasIndex(e => e.proc_def_key_, "act_idx_hi_detail_proc_def_key");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_hi_detail_proc_inst");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_detail_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_detail_root_pi");

            entity.HasIndex(e => new { e.bytearray_id_, e.task_id_ }, "act_idx_hi_detail_task_bytear");

            entity.HasIndex(e => e.task_id_, "act_idx_hi_detail_task_id");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_detail_tenant_id");

            entity.HasIndex(e => e.time_, "act_idx_hi_detail_time");

            entity.HasIndex(e => e.var_inst_id_, "act_idx_hi_detail_var_inst_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_inst_id_).HasMaxLength(64);
            entity.Property(e => e.bytearray_id_).HasMaxLength(64);
            entity.Property(e => e.case_def_id_).HasMaxLength(64);
            entity.Property(e => e.case_def_key_).HasMaxLength(255);
            entity.Property(e => e.case_execution_id_).HasMaxLength(64);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.operation_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.task_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.text2_).HasMaxLength(4000);
            entity.Property(e => e.text_).HasMaxLength(4000);
            entity.Property(e => e.time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.type_).HasMaxLength(255);
            entity.Property(e => e.var_inst_id_).HasMaxLength(64);
            entity.Property(e => e.var_type_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_hi_ext_task_log>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_ext_task_log_pkey");

            entity.ToTable("act_hi_ext_task_log");

            entity.HasIndex(e => e.proc_def_key_, "act_hi_ext_task_log_proc_def_key");

            entity.HasIndex(e => e.proc_def_id_, "act_hi_ext_task_log_procdef");

            entity.HasIndex(e => e.proc_inst_id_, "act_hi_ext_task_log_procinst");

            entity.HasIndex(e => e.removal_time_, "act_hi_ext_task_log_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_hi_ext_task_log_root_pi");

            entity.HasIndex(e => e.tenant_id_, "act_hi_ext_task_log_tenant_id");

            entity.HasIndex(e => e.error_details_id_, "act_idx_hi_exttasklog_errordet");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_id_).HasMaxLength(255);
            entity.Property(e => e.act_inst_id_).HasMaxLength(64);
            entity.Property(e => e.error_details_id_).HasMaxLength(64);
            entity.Property(e => e.error_msg_).HasMaxLength(4000);
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.ext_task_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.timestamp_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.topic_name_).HasMaxLength(255);
            entity.Property(e => e.worker_id_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_hi_identitylink>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_identitylink_pkey");

            entity.ToTable("act_hi_identitylink");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_ident_link_rm_time");

            entity.HasIndex(e => e.task_id_, "act_idx_hi_ident_link_task");

            entity.HasIndex(e => e.group_id_, "act_idx_hi_ident_lnk_group");

            entity.HasIndex(e => e.proc_def_key_, "act_idx_hi_ident_lnk_proc_def_key");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_ident_lnk_root_pi");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_ident_lnk_tenant_id");

            entity.HasIndex(e => e.timestamp_, "act_idx_hi_ident_lnk_timestamp");

            entity.HasIndex(e => e.user_id_, "act_idx_hi_ident_lnk_user");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.assigner_id_).HasMaxLength(64);
            entity.Property(e => e.group_id_).HasMaxLength(255);
            entity.Property(e => e.operation_type_).HasMaxLength(64);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.task_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.timestamp_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.type_).HasMaxLength(255);
            entity.Property(e => e.user_id_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_hi_incident>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_incident_pkey");

            entity.ToTable("act_hi_incident");

            entity.HasIndex(e => e.create_time_, "act_idx_hi_incident_create_time");

            entity.HasIndex(e => e.end_time_, "act_idx_hi_incident_end_time");

            entity.HasIndex(e => e.proc_def_key_, "act_idx_hi_incident_proc_def_key");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_hi_incident_procinst");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_incident_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_incident_root_pi");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_incident_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.activity_id_).HasMaxLength(255);
            entity.Property(e => e.annotation_).HasMaxLength(4000);
            entity.Property(e => e.cause_incident_id_).HasMaxLength(64);
            entity.Property(e => e.configuration_).HasMaxLength(255);
            entity.Property(e => e.create_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.end_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.failed_activity_id_).HasMaxLength(255);
            entity.Property(e => e.history_configuration_).HasMaxLength(255);
            entity.Property(e => e.incident_msg_).HasMaxLength(4000);
            entity.Property(e => e.incident_type_).HasMaxLength(255);
            entity.Property(e => e.job_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_cause_incident_id_).HasMaxLength(64);
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_hi_job_log>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_job_log_pkey");

            entity.ToTable("act_hi_job_log");

            entity.HasIndex(e => e.job_exception_stack_id_, "act_idx_hi_job_log_ex_stack");

            entity.HasIndex(e => e.job_def_configuration_, "act_idx_hi_job_log_job_conf");

            entity.HasIndex(e => e.job_def_id_, "act_idx_hi_job_log_job_def_id");

            entity.HasIndex(e => e.process_def_key_, "act_idx_hi_job_log_proc_def_key");

            entity.HasIndex(e => e.process_def_id_, "act_idx_hi_job_log_procdef");

            entity.HasIndex(e => e.process_instance_id_, "act_idx_hi_job_log_procinst");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_job_log_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_job_log_root_pi");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_job_log_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_id_).HasMaxLength(255);
            entity.Property(e => e.deployment_id_).HasMaxLength(64);
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.failed_act_id_).HasMaxLength(255);
            entity.Property(e => e.hostname_).HasMaxLength(255);
            entity.Property(e => e.job_def_configuration_).HasMaxLength(255);
            entity.Property(e => e.job_def_id_).HasMaxLength(64);
            entity.Property(e => e.job_def_type_).HasMaxLength(255);
            entity.Property(e => e.job_duedate_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.job_exception_msg_).HasMaxLength(4000);
            entity.Property(e => e.job_exception_stack_id_).HasMaxLength(64);
            entity.Property(e => e.job_id_).HasMaxLength(64);
            entity.Property(e => e.process_def_id_).HasMaxLength(64);
            entity.Property(e => e.process_def_key_).HasMaxLength(255);
            entity.Property(e => e.process_instance_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.timestamp_).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<act_hi_op_log>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_op_log_pkey");

            entity.ToTable("act_hi_op_log");

            entity.HasIndex(e => e.entity_type_, "act_idx_hi_op_log_entity_type");

            entity.HasIndex(e => e.operation_type_, "act_idx_hi_op_log_op_type");

            entity.HasIndex(e => e.proc_def_id_, "act_idx_hi_op_log_procdef");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_hi_op_log_procinst");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_op_log_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_op_log_root_pi");

            entity.HasIndex(e => e.task_id_, "act_idx_hi_op_log_task");

            entity.HasIndex(e => e.timestamp_, "act_idx_hi_op_log_timestamp");

            entity.HasIndex(e => e.user_id_, "act_idx_hi_op_log_user_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.annotation_).HasMaxLength(4000);
            entity.Property(e => e.batch_id_).HasMaxLength(64);
            entity.Property(e => e.case_def_id_).HasMaxLength(64);
            entity.Property(e => e.case_execution_id_).HasMaxLength(64);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.category_).HasMaxLength(64);
            entity.Property(e => e.deployment_id_).HasMaxLength(64);
            entity.Property(e => e.entity_type_).HasMaxLength(30);
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.external_task_id_).HasMaxLength(64);
            entity.Property(e => e.job_def_id_).HasMaxLength(64);
            entity.Property(e => e.job_id_).HasMaxLength(64);
            entity.Property(e => e.new_value_).HasMaxLength(4000);
            entity.Property(e => e.operation_id_).HasMaxLength(64);
            entity.Property(e => e.operation_type_).HasMaxLength(64);
            entity.Property(e => e.org_value_).HasMaxLength(4000);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.property_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.task_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.timestamp_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.user_id_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_hi_procinst>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_procinst_pkey");

            entity.ToTable("act_hi_procinst");

            entity.HasIndex(e => e.proc_inst_id_, "act_hi_procinst_proc_inst_id__key").IsUnique();

            entity.HasIndex(e => new { e.proc_def_id_, e.end_time_ }, "act_idx_hi_pi_pdefid_end_time");

            entity.HasIndex(e => e.business_key_, "act_idx_hi_pro_i_buskey");

            entity.HasIndex(e => e.end_time_, "act_idx_hi_pro_inst_end");

            entity.HasIndex(e => e.proc_def_key_, "act_idx_hi_pro_inst_proc_def_key");

            entity.HasIndex(e => new { e.start_time_, e.end_time_ }, "act_idx_hi_pro_inst_proc_time");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_pro_inst_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_pro_inst_root_pi");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_pro_inst_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.business_key_).HasMaxLength(255);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.delete_reason_).HasMaxLength(4000);
            entity.Property(e => e.end_act_id_).HasMaxLength(255);
            entity.Property(e => e.end_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.start_act_id_).HasMaxLength(255);
            entity.Property(e => e.start_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.start_user_id_).HasMaxLength(255);
            entity.Property(e => e.state_).HasMaxLength(255);
            entity.Property(e => e.super_case_instance_id_).HasMaxLength(64);
            entity.Property(e => e.super_process_instance_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_hi_taskinst>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_taskinst_pkey");

            entity.ToTable("act_hi_taskinst");

            entity.HasIndex(e => e.end_time_, "act_idx_hi_task_inst_end");

            entity.HasIndex(e => e.proc_def_key_, "act_idx_hi_task_inst_proc_def_key");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_task_inst_rm_time");

            entity.HasIndex(e => e.start_time_, "act_idx_hi_task_inst_start");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_task_inst_tenant_id");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_hi_taskinst_procinst");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_taskinst_root_pi");

            entity.HasIndex(e => new { e.id_, e.proc_inst_id_ }, "act_idx_hi_taskinstid_procinst");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_inst_id_).HasMaxLength(64);
            entity.Property(e => e.assignee_).HasMaxLength(255);
            entity.Property(e => e.case_def_id_).HasMaxLength(64);
            entity.Property(e => e.case_def_key_).HasMaxLength(255);
            entity.Property(e => e.case_execution_id_).HasMaxLength(64);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.delete_reason_).HasMaxLength(4000);
            entity.Property(e => e.description_).HasMaxLength(4000);
            entity.Property(e => e.due_date_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.end_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.follow_up_date_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.owner_).HasMaxLength(255);
            entity.Property(e => e.parent_task_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.start_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.task_def_key_).HasMaxLength(255);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_hi_varinst>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_hi_varinst_pkey");

            entity.ToTable("act_hi_varinst");

            entity.HasIndex(e => e.case_inst_id_, "act_idx_hi_casevar_case_inst");

            entity.HasIndex(e => new { e.name_, e.var_type_ }, "act_idx_hi_procvar_name_type");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_hi_procvar_proc_inst");

            entity.HasIndex(e => e.proc_def_key_, "act_idx_hi_var_inst_proc_def_key");

            entity.HasIndex(e => e.tenant_id_, "act_idx_hi_var_inst_tenant_id");

            entity.HasIndex(e => new { e.proc_inst_id_, e.name_, e.var_type_ }, "act_idx_hi_var_pi_name_type");

            entity.HasIndex(e => e.act_inst_id_, "act_idx_hi_varinst_act_inst_id");

            entity.HasIndex(e => e.bytearray_id_, "act_idx_hi_varinst_bytear");

            entity.HasIndex(e => e.name_, "act_idx_hi_varinst_name");

            entity.HasIndex(e => e.removal_time_, "act_idx_hi_varinst_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_hi_varinst_root_pi");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_inst_id_).HasMaxLength(64);
            entity.Property(e => e.bytearray_id_).HasMaxLength(64);
            entity.Property(e => e.case_def_id_).HasMaxLength(64);
            entity.Property(e => e.case_def_key_).HasMaxLength(255);
            entity.Property(e => e.case_execution_id_).HasMaxLength(64);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.create_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.state_).HasMaxLength(20);
            entity.Property(e => e.task_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.text2_).HasMaxLength(4000);
            entity.Property(e => e.text_).HasMaxLength(4000);
            entity.Property(e => e.var_type_).HasMaxLength(100);
        });

        modelBuilder.Entity<act_id_group>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_id_group_pkey");

            entity.ToTable("act_id_group");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.type_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_id_info>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_id_info_pkey");

            entity.ToTable("act_id_info");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.key_).HasMaxLength(255);
            entity.Property(e => e.parent_id_).HasMaxLength(255);
            entity.Property(e => e.type_).HasMaxLength(64);
            entity.Property(e => e.user_id_).HasMaxLength(64);
            entity.Property(e => e.value_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_id_tenant>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_id_tenant_pkey");

            entity.ToTable("act_id_tenant");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.name_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_id_tenant_member>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_id_tenant_member_pkey");

            entity.ToTable("act_id_tenant_member");

            entity.HasIndex(e => e.tenant_id_, "act_idx_tenant_memb");

            entity.HasIndex(e => e.group_id_, "act_idx_tenant_memb_group");

            entity.HasIndex(e => e.user_id_, "act_idx_tenant_memb_user");

            entity.HasIndex(e => new { e.tenant_id_, e.group_id_ }, "act_uniq_tenant_memb_group").IsUnique();

            entity.HasIndex(e => new { e.tenant_id_, e.user_id_ }, "act_uniq_tenant_memb_user").IsUnique();

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.group_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.user_id_).HasMaxLength(64);

            entity.HasOne(d => d.group_id_Navigation).WithMany(p => p.act_id_tenant_members)
                .HasForeignKey(d => d.group_id_)
                .HasConstraintName("act_fk_tenant_memb_group");

            entity.HasOne(d => d.tenant_id_Navigation).WithMany(p => p.act_id_tenant_members)
                .HasForeignKey(d => d.tenant_id_)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("act_fk_tenant_memb");

            entity.HasOne(d => d.user_id_Navigation).WithMany(p => p.act_id_tenant_members)
                .HasForeignKey(d => d.user_id_)
                .HasConstraintName("act_fk_tenant_memb_user");
        });

        modelBuilder.Entity<act_id_user>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_id_user_pkey");

            entity.ToTable("act_id_user");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.email_).HasMaxLength(255);
            entity.Property(e => e.first_).HasMaxLength(255);
            entity.Property(e => e.last_).HasMaxLength(255);
            entity.Property(e => e.lock_exp_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.picture_id_).HasMaxLength(64);
            entity.Property(e => e.pwd_).HasMaxLength(255);
            entity.Property(e => e.salt_).HasMaxLength(255);

            entity.HasMany(d => d.group_id_s).WithMany(p => p.user_id_s)
                .UsingEntity<Dictionary<string, object>>(
                    "act_id_membership",
                    r => r.HasOne<act_id_group>().WithMany()
                        .HasForeignKey("group_id_")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("act_fk_memb_group"),
                    l => l.HasOne<act_id_user>().WithMany()
                        .HasForeignKey("user_id_")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("act_fk_memb_user"),
                    j =>
                    {
                        j.HasKey("user_id_", "group_id_").HasName("act_id_membership_pkey");
                        j.ToTable("act_id_membership");
                        j.HasIndex(new[] { "group_id_" }, "act_idx_memb_group");
                        j.HasIndex(new[] { "user_id_" }, "act_idx_memb_user");
                    });
        });

        modelBuilder.Entity<act_re_camformdef>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_re_camformdef_pkey");

            entity.ToTable("act_re_camformdef");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.deployment_id_).HasMaxLength(64);
            entity.Property(e => e.key_).HasMaxLength(255);
            entity.Property(e => e.resource_name_).HasMaxLength(4000);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_re_case_def>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_re_case_def_pkey");

            entity.ToTable("act_re_case_def");

            entity.HasIndex(e => e.tenant_id_, "act_idx_case_def_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.category_).HasMaxLength(255);
            entity.Property(e => e.deployment_id_).HasMaxLength(64);
            entity.Property(e => e.dgrm_resource_name_).HasMaxLength(4000);
            entity.Property(e => e.key_).HasMaxLength(255);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.resource_name_).HasMaxLength(4000);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_re_decision_def>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_re_decision_def_pkey");

            entity.ToTable("act_re_decision_def");

            entity.HasIndex(e => e.dec_req_id_, "act_idx_dec_def_req_id");

            entity.HasIndex(e => e.tenant_id_, "act_idx_dec_def_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.category_).HasMaxLength(255);
            entity.Property(e => e.dec_req_id_).HasMaxLength(64);
            entity.Property(e => e.dec_req_key_).HasMaxLength(255);
            entity.Property(e => e.deployment_id_).HasMaxLength(64);
            entity.Property(e => e.dgrm_resource_name_).HasMaxLength(4000);
            entity.Property(e => e.key_).HasMaxLength(255);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.resource_name_).HasMaxLength(4000);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.version_tag_).HasMaxLength(64);

            entity.HasOne(d => d.dec_req_id_Navigation).WithMany(p => p.act_re_decision_defs)
                .HasForeignKey(d => d.dec_req_id_)
                .HasConstraintName("act_fk_dec_req");
        });

        modelBuilder.Entity<act_re_decision_req_def>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_re_decision_req_def_pkey");

            entity.ToTable("act_re_decision_req_def");

            entity.HasIndex(e => e.tenant_id_, "act_idx_dec_req_def_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.category_).HasMaxLength(255);
            entity.Property(e => e.deployment_id_).HasMaxLength(64);
            entity.Property(e => e.dgrm_resource_name_).HasMaxLength(4000);
            entity.Property(e => e.key_).HasMaxLength(255);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.resource_name_).HasMaxLength(4000);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_re_deployment>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_re_deployment_pkey");

            entity.ToTable("act_re_deployment");

            entity.HasIndex(e => e.name_, "act_idx_deployment_name");

            entity.HasIndex(e => e.tenant_id_, "act_idx_deployment_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.deploy_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.source_).HasMaxLength(255);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_re_procdef>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_re_procdef_pkey");

            entity.ToTable("act_re_procdef");

            entity.HasIndex(e => e.deployment_id_, "act_idx_procdef_deployment_id");

            entity.HasIndex(e => e.tenant_id_, "act_idx_procdef_tenant_id");

            entity.HasIndex(e => e.version_tag_, "act_idx_procdef_ver_tag");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.category_).HasMaxLength(255);
            entity.Property(e => e.deployment_id_).HasMaxLength(64);
            entity.Property(e => e.dgrm_resource_name_).HasMaxLength(4000);
            entity.Property(e => e.key_).HasMaxLength(255);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.resource_name_).HasMaxLength(4000);
            entity.Property(e => e.startable_)
                .IsRequired()
                .HasDefaultValueSql("true");
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.version_tag_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_ru_authorization>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_authorization_pkey");

            entity.ToTable("act_ru_authorization");

            entity.HasIndex(e => e.group_id_, "act_idx_auth_group_id");

            entity.HasIndex(e => e.resource_id_, "act_idx_auth_resource_id");

            entity.HasIndex(e => e.removal_time_, "act_idx_auth_rm_time");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_auth_root_pi");

            entity.HasIndex(e => new { e.type_, e.group_id_, e.resource_type_, e.resource_id_ }, "act_uniq_auth_group").IsUnique();

            entity.HasIndex(e => new { e.type_, e.user_id_, e.resource_type_, e.resource_id_ }, "act_uniq_auth_user").IsUnique();

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.group_id_).HasMaxLength(255);
            entity.Property(e => e.removal_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.resource_id_).HasMaxLength(255);
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.user_id_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_ru_batch>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_batch_pkey");

            entity.ToTable("act_ru_batch");

            entity.HasIndex(e => e.batch_job_def_id_, "act_idx_batch_job_def");

            entity.HasIndex(e => e.monitor_job_def_id_, "act_idx_batch_monitor_job_def");

            entity.HasIndex(e => e.seed_job_def_id_, "act_idx_batch_seed_job_def");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.batch_job_def_id_).HasMaxLength(64);
            entity.Property(e => e.configuration_).HasMaxLength(255);
            entity.Property(e => e.create_user_id_).HasMaxLength(255);
            entity.Property(e => e.monitor_job_def_id_).HasMaxLength(64);
            entity.Property(e => e.seed_job_def_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.type_).HasMaxLength(255);

            entity.HasOne(d => d.batch_job_def_id_Navigation).WithMany(p => p.act_ru_batchbatch_job_def_id_Navigations)
                .HasForeignKey(d => d.batch_job_def_id_)
                .HasConstraintName("act_fk_batch_job_def");

            entity.HasOne(d => d.monitor_job_def_id_Navigation).WithMany(p => p.act_ru_batchmonitor_job_def_id_Navigations)
                .HasForeignKey(d => d.monitor_job_def_id_)
                .HasConstraintName("act_fk_batch_monitor_job_def");

            entity.HasOne(d => d.seed_job_def_id_Navigation).WithMany(p => p.act_ru_batchseed_job_def_id_Navigations)
                .HasForeignKey(d => d.seed_job_def_id_)
                .HasConstraintName("act_fk_batch_seed_job_def");
        });

        modelBuilder.Entity<act_ru_case_execution>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_case_execution_pkey");

            entity.ToTable("act_ru_case_execution");

            entity.HasIndex(e => e.case_def_id_, "act_idx_case_exe_case_def");

            entity.HasIndex(e => e.case_inst_id_, "act_idx_case_exe_case_inst");

            entity.HasIndex(e => e.parent_id_, "act_idx_case_exe_parent");

            entity.HasIndex(e => e.business_key_, "act_idx_case_exec_buskey");

            entity.HasIndex(e => e.tenant_id_, "act_idx_case_exec_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_id_).HasMaxLength(255);
            entity.Property(e => e.business_key_).HasMaxLength(255);
            entity.Property(e => e.case_def_id_).HasMaxLength(64);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.parent_id_).HasMaxLength(64);
            entity.Property(e => e.super_case_exec_).HasMaxLength(64);
            entity.Property(e => e.super_exec_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);

            entity.HasOne(d => d.case_def_id_Navigation).WithMany(p => p.act_ru_case_executions)
                .HasForeignKey(d => d.case_def_id_)
                .HasConstraintName("act_fk_case_exe_case_def");

            entity.HasOne(d => d.case_inst_id_Navigation).WithMany(p => p.Inversecase_inst_id_Navigation)
                .HasForeignKey(d => d.case_inst_id_)
                .HasConstraintName("act_fk_case_exe_case_inst");

            entity.HasOne(d => d.parent_id_Navigation).WithMany(p => p.Inverseparent_id_Navigation)
                .HasForeignKey(d => d.parent_id_)
                .HasConstraintName("act_fk_case_exe_parent");
        });

        modelBuilder.Entity<act_ru_case_sentry_part>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_case_sentry_part_pkey");

            entity.ToTable("act_ru_case_sentry_part");

            entity.HasIndex(e => e.case_exec_id_, "act_idx_case_sentry_case_exec");

            entity.HasIndex(e => e.case_inst_id_, "act_idx_case_sentry_case_inst");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.case_exec_id_).HasMaxLength(64);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.sentry_id_).HasMaxLength(255);
            entity.Property(e => e.source_).HasMaxLength(255);
            entity.Property(e => e.source_case_exec_id_).HasMaxLength(64);
            entity.Property(e => e.standard_event_).HasMaxLength(255);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.type_).HasMaxLength(255);
            entity.Property(e => e.variable_event_).HasMaxLength(255);
            entity.Property(e => e.variable_name_).HasMaxLength(255);

            entity.HasOne(d => d.case_exec_id_Navigation).WithMany(p => p.act_ru_case_sentry_partcase_exec_id_Navigations)
                .HasForeignKey(d => d.case_exec_id_)
                .HasConstraintName("act_fk_case_sentry_case_exec");

            entity.HasOne(d => d.case_inst_id_Navigation).WithMany(p => p.act_ru_case_sentry_partcase_inst_id_Navigations)
                .HasForeignKey(d => d.case_inst_id_)
                .HasConstraintName("act_fk_case_sentry_case_inst");
        });

        modelBuilder.Entity<act_ru_event_subscr>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_event_subscr_pkey");

            entity.ToTable("act_ru_event_subscr");

            entity.HasIndex(e => e.execution_id_, "act_idx_event_subscr");

            entity.HasIndex(e => e.configuration_, "act_idx_event_subscr_config_");

            entity.HasIndex(e => e.event_name_, "act_idx_event_subscr_evt_name");

            entity.HasIndex(e => e.tenant_id_, "act_idx_event_subscr_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.activity_id_).HasMaxLength(255);
            entity.Property(e => e.configuration_).HasMaxLength(255);
            entity.Property(e => e.created_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.event_name_).HasMaxLength(255);
            entity.Property(e => e.event_type_).HasMaxLength(255);
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);

            entity.HasOne(d => d.execution_id_Navigation).WithMany(p => p.act_ru_event_subscrs)
                .HasForeignKey(d => d.execution_id_)
                .HasConstraintName("act_fk_event_exec");
        });

        modelBuilder.Entity<act_ru_execution>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_execution_pkey");

            entity.ToTable("act_ru_execution");

            entity.HasIndex(e => e.parent_id_, "act_idx_exe_parent");

            entity.HasIndex(e => e.proc_def_id_, "act_idx_exe_procdef");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_exe_procinst");

            entity.HasIndex(e => e.root_proc_inst_id_, "act_idx_exe_root_pi");

            entity.HasIndex(e => e.super_exec_, "act_idx_exe_super");

            entity.HasIndex(e => e.business_key_, "act_idx_exec_buskey");

            entity.HasIndex(e => e.tenant_id_, "act_idx_exec_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_id_).HasMaxLength(255);
            entity.Property(e => e.act_inst_id_).HasMaxLength(64);
            entity.Property(e => e.business_key_).HasMaxLength(255);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.parent_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.root_proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.super_case_exec_).HasMaxLength(64);
            entity.Property(e => e.super_exec_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);

            entity.HasOne(d => d.parent_id_Navigation).WithMany(p => p.Inverseparent_id_Navigation)
                .HasForeignKey(d => d.parent_id_)
                .HasConstraintName("act_fk_exe_parent");

            entity.HasOne(d => d.proc_def_id_Navigation).WithMany(p => p.act_ru_executions)
                .HasForeignKey(d => d.proc_def_id_)
                .HasConstraintName("act_fk_exe_procdef");

            entity.HasOne(d => d.proc_inst_id_Navigation).WithMany(p => p.Inverseproc_inst_id_Navigation)
                .HasForeignKey(d => d.proc_inst_id_)
                .HasConstraintName("act_fk_exe_procinst");

            entity.HasOne(d => d.super_exec_Navigation).WithMany(p => p.Inversesuper_exec_Navigation)
                .HasForeignKey(d => d.super_exec_)
                .HasConstraintName("act_fk_exe_super");
        });

        modelBuilder.Entity<act_ru_ext_task>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_ext_task_pkey");

            entity.ToTable("act_ru_ext_task");

            entity.HasIndex(e => e.error_details_id_, "act_idx_ext_task_err_details");

            entity.HasIndex(e => e.execution_id_, "act_idx_ext_task_exec");

            entity.HasIndex(e => e.priority_, "act_idx_ext_task_priority");

            entity.HasIndex(e => e.tenant_id_, "act_idx_ext_task_tenant_id");

            entity.HasIndex(e => e.topic_name_, "act_idx_ext_task_topic");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_id_).HasMaxLength(255);
            entity.Property(e => e.act_inst_id_).HasMaxLength(64);
            entity.Property(e => e.error_details_id_).HasMaxLength(64);
            entity.Property(e => e.error_msg_).HasMaxLength(4000);
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.last_failure_log_id_).HasMaxLength(64);
            entity.Property(e => e.lock_exp_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.topic_name_).HasMaxLength(255);
            entity.Property(e => e.worker_id_).HasMaxLength(255);

            entity.HasOne(d => d.error_details_id_Navigation).WithMany(p => p.act_ru_ext_tasks)
                .HasForeignKey(d => d.error_details_id_)
                .HasConstraintName("act_fk_ext_task_error_details");

            entity.HasOne(d => d.execution_id_Navigation).WithMany(p => p.act_ru_ext_tasks)
                .HasForeignKey(d => d.execution_id_)
                .HasConstraintName("act_fk_ext_task_exe");
        });

        modelBuilder.Entity<act_ru_filter>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_filter_pkey");

            entity.ToTable("act_ru_filter");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.owner_).HasMaxLength(255);
            entity.Property(e => e.resource_type_).HasMaxLength(255);
        });

        modelBuilder.Entity<act_ru_identitylink>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_identitylink_pkey");

            entity.ToTable("act_ru_identitylink");

            entity.HasIndex(e => e.proc_def_id_, "act_idx_athrz_procedef");

            entity.HasIndex(e => e.group_id_, "act_idx_ident_lnk_group");

            entity.HasIndex(e => e.user_id_, "act_idx_ident_lnk_user");

            entity.HasIndex(e => e.task_id_, "act_idx_tskass_task");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.group_id_).HasMaxLength(255);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.task_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.type_).HasMaxLength(255);
            entity.Property(e => e.user_id_).HasMaxLength(255);

            entity.HasOne(d => d.proc_def_id_Navigation).WithMany(p => p.act_ru_identitylinks)
                .HasForeignKey(d => d.proc_def_id_)
                .HasConstraintName("act_fk_athrz_procedef");

            entity.HasOne(d => d.task_id_Navigation).WithMany(p => p.act_ru_identitylinks)
                .HasForeignKey(d => d.task_id_)
                .HasConstraintName("act_fk_tskass_task");
        });

        modelBuilder.Entity<act_ru_incident>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_incident_pkey");

            entity.ToTable("act_ru_incident");

            entity.HasIndex(e => e.cause_incident_id_, "act_idx_inc_causeincid");

            entity.HasIndex(e => e.configuration_, "act_idx_inc_configuration");

            entity.HasIndex(e => e.execution_id_, "act_idx_inc_exid");

            entity.HasIndex(e => e.job_def_id_, "act_idx_inc_job_def");

            entity.HasIndex(e => e.proc_def_id_, "act_idx_inc_procdefid");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_inc_procinstid");

            entity.HasIndex(e => e.root_cause_incident_id_, "act_idx_inc_rootcauseincid");

            entity.HasIndex(e => e.tenant_id_, "act_idx_inc_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.activity_id_).HasMaxLength(255);
            entity.Property(e => e.annotation_).HasMaxLength(4000);
            entity.Property(e => e.cause_incident_id_).HasMaxLength(64);
            entity.Property(e => e.configuration_).HasMaxLength(255);
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.failed_activity_id_).HasMaxLength(255);
            entity.Property(e => e.incident_msg_).HasMaxLength(4000);
            entity.Property(e => e.incident_timestamp_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.incident_type_).HasMaxLength(255);
            entity.Property(e => e.job_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.root_cause_incident_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);

            entity.HasOne(d => d.cause_incident_id_Navigation).WithMany(p => p.Inversecause_incident_id_Navigation)
                .HasForeignKey(d => d.cause_incident_id_)
                .HasConstraintName("act_fk_inc_cause");

            entity.HasOne(d => d.execution_id_Navigation).WithMany(p => p.act_ru_incidentexecution_id_Navigations)
                .HasForeignKey(d => d.execution_id_)
                .HasConstraintName("act_fk_inc_exe");

            entity.HasOne(d => d.job_def_id_Navigation).WithMany(p => p.act_ru_incidents)
                .HasForeignKey(d => d.job_def_id_)
                .HasConstraintName("act_fk_inc_job_def");

            entity.HasOne(d => d.proc_def_id_Navigation).WithMany(p => p.act_ru_incidents)
                .HasForeignKey(d => d.proc_def_id_)
                .HasConstraintName("act_fk_inc_procdef");

            entity.HasOne(d => d.proc_inst_id_Navigation).WithMany(p => p.act_ru_incidentproc_inst_id_Navigations)
                .HasForeignKey(d => d.proc_inst_id_)
                .HasConstraintName("act_fk_inc_procinst");

            entity.HasOne(d => d.root_cause_incident_id_Navigation).WithMany(p => p.Inverseroot_cause_incident_id_Navigation)
                .HasForeignKey(d => d.root_cause_incident_id_)
                .HasConstraintName("act_fk_inc_rcause");
        });

        modelBuilder.Entity<act_ru_job>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_job_pkey");

            entity.ToTable("act_ru_job");

            entity.HasIndex(e => e.exception_stack_id_, "act_idx_job_exception");

            entity.HasIndex(e => e.execution_id_, "act_idx_job_execution_id");

            entity.HasIndex(e => new { e.handler_type_, e.handler_cfg_ }, "act_idx_job_handler");

            entity.HasIndex(e => e.handler_type_, "act_idx_job_handler_type");

            entity.HasIndex(e => e.job_def_id_, "act_idx_job_job_def_id");

            entity.HasIndex(e => e.process_instance_id_, "act_idx_job_procinst");

            entity.HasIndex(e => e.tenant_id_, "act_idx_job_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.create_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.deployment_id_).HasMaxLength(64);
            entity.Property(e => e.duedate_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.exception_msg_).HasMaxLength(4000);
            entity.Property(e => e.exception_stack_id_).HasMaxLength(64);
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.failed_act_id_).HasMaxLength(255);
            entity.Property(e => e.handler_cfg_).HasMaxLength(4000);
            entity.Property(e => e.handler_type_).HasMaxLength(255);
            entity.Property(e => e.job_def_id_).HasMaxLength(64);
            entity.Property(e => e.last_failure_log_id_).HasMaxLength(64);
            entity.Property(e => e.lock_exp_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.lock_owner_).HasMaxLength(255);
            entity.Property(e => e.process_def_id_).HasMaxLength(64);
            entity.Property(e => e.process_def_key_).HasMaxLength(255);
            entity.Property(e => e.process_instance_id_).HasMaxLength(64);
            entity.Property(e => e.repeat_).HasMaxLength(255);
            entity.Property(e => e.repeat_offset_).HasDefaultValueSql("0");
            entity.Property(e => e.suspension_state_).HasDefaultValueSql("1");
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.type_).HasMaxLength(255);

            entity.HasOne(d => d.exception_stack_id_Navigation).WithMany(p => p.act_ru_jobs)
                .HasForeignKey(d => d.exception_stack_id_)
                .HasConstraintName("act_fk_job_exception");
        });

        modelBuilder.Entity<act_ru_jobdef>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_jobdef_pkey");

            entity.ToTable("act_ru_jobdef");

            entity.HasIndex(e => e.proc_def_id_, "act_idx_jobdef_proc_def_id");

            entity.HasIndex(e => e.tenant_id_, "act_idx_jobdef_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.act_id_).HasMaxLength(255);
            entity.Property(e => e.deployment_id_).HasMaxLength(64);
            entity.Property(e => e.job_configuration_).HasMaxLength(255);
            entity.Property(e => e.job_type_).HasMaxLength(255);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_key_).HasMaxLength(255);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
        });

        modelBuilder.Entity<act_ru_meter_log>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_meter_log_pkey");

            entity.ToTable("act_ru_meter_log");

            entity.HasIndex(e => new { e.name_, e.timestamp_ }, "act_idx_meter_log");

            entity.HasIndex(e => e.milliseconds_, "act_idx_meter_log_ms");

            entity.HasIndex(e => new { e.name_, e.milliseconds_ }, "act_idx_meter_log_name_ms");

            entity.HasIndex(e => new { e.name_, e.reporter_, e.milliseconds_ }, "act_idx_meter_log_report");

            entity.HasIndex(e => e.timestamp_, "act_idx_meter_log_time");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.milliseconds_).HasDefaultValueSql("0");
            entity.Property(e => e.name_).HasMaxLength(64);
            entity.Property(e => e.reporter_).HasMaxLength(255);
            entity.Property(e => e.timestamp_).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<act_ru_task>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_task_pkey");

            entity.ToTable("act_ru_task");

            entity.HasIndex(e => e.assignee_, "act_idx_task_assignee");

            entity.HasIndex(e => e.case_def_id_, "act_idx_task_case_def_id");

            entity.HasIndex(e => e.case_execution_id_, "act_idx_task_case_exec");

            entity.HasIndex(e => e.create_time_, "act_idx_task_create");

            entity.HasIndex(e => e.execution_id_, "act_idx_task_exec");

            entity.HasIndex(e => e.owner_, "act_idx_task_owner");

            entity.HasIndex(e => e.proc_def_id_, "act_idx_task_procdef");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_task_procinst");

            entity.HasIndex(e => e.tenant_id_, "act_idx_task_tenant_id");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.assignee_).HasMaxLength(255);
            entity.Property(e => e.case_def_id_).HasMaxLength(64);
            entity.Property(e => e.case_execution_id_).HasMaxLength(64);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.create_time_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.delegation_).HasMaxLength(64);
            entity.Property(e => e.description_).HasMaxLength(4000);
            entity.Property(e => e.due_date_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.follow_up_date_).HasColumnType("timestamp without time zone");
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.owner_).HasMaxLength(255);
            entity.Property(e => e.parent_task_id_).HasMaxLength(64);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.task_def_key_).HasMaxLength(255);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);

            entity.HasOne(d => d.case_def_id_Navigation).WithMany(p => p.act_ru_tasks)
                .HasForeignKey(d => d.case_def_id_)
                .HasConstraintName("act_fk_task_case_def");

            entity.HasOne(d => d.case_execution_id_Navigation).WithMany(p => p.act_ru_tasks)
                .HasForeignKey(d => d.case_execution_id_)
                .HasConstraintName("act_fk_task_case_exe");

            entity.HasOne(d => d.execution_id_Navigation).WithMany(p => p.act_ru_taskexecution_id_Navigations)
                .HasForeignKey(d => d.execution_id_)
                .HasConstraintName("act_fk_task_exe");

            entity.HasOne(d => d.proc_def_id_Navigation).WithMany(p => p.act_ru_tasks)
                .HasForeignKey(d => d.proc_def_id_)
                .HasConstraintName("act_fk_task_procdef");

            entity.HasOne(d => d.proc_inst_id_Navigation).WithMany(p => p.act_ru_taskproc_inst_id_Navigations)
                .HasForeignKey(d => d.proc_inst_id_)
                .HasConstraintName("act_fk_task_procinst");
        });

        modelBuilder.Entity<act_ru_task_meter_log>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_task_meter_log_pkey");

            entity.ToTable("act_ru_task_meter_log");

            entity.HasIndex(e => e.timestamp_, "act_idx_task_meter_log_time");

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.timestamp_).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<act_ru_variable>(entity =>
        {
            entity.HasKey(e => e.id_).HasName("act_ru_variable_pkey");

            entity.ToTable("act_ru_variable");

            entity.HasIndex(e => e.batch_id_, "act_idx_batch_id");

            entity.HasIndex(e => e.bytearray_id_, "act_idx_var_bytearray");

            entity.HasIndex(e => e.case_execution_id_, "act_idx_var_case_exe");

            entity.HasIndex(e => e.case_inst_id_, "act_idx_var_case_inst_id");

            entity.HasIndex(e => e.execution_id_, "act_idx_var_exe");

            entity.HasIndex(e => e.proc_inst_id_, "act_idx_var_procinst");

            entity.HasIndex(e => e.task_id_, "act_idx_variable_task_id");

            entity.HasIndex(e => new { e.task_id_, e.name_, e.type_ }, "act_idx_variable_task_name_type");

            entity.HasIndex(e => e.tenant_id_, "act_idx_variable_tenant_id");

            entity.HasIndex(e => new { e.var_scope_, e.name_ }, "act_uniq_variable").IsUnique();

            entity.Property(e => e.id_).HasMaxLength(64);
            entity.Property(e => e.batch_id_).HasMaxLength(64);
            entity.Property(e => e.bytearray_id_).HasMaxLength(64);
            entity.Property(e => e.case_execution_id_).HasMaxLength(64);
            entity.Property(e => e.case_inst_id_).HasMaxLength(64);
            entity.Property(e => e.execution_id_).HasMaxLength(64);
            entity.Property(e => e.name_).HasMaxLength(255);
            entity.Property(e => e.proc_def_id_).HasMaxLength(64);
            entity.Property(e => e.proc_inst_id_).HasMaxLength(64);
            entity.Property(e => e.task_id_).HasMaxLength(64);
            entity.Property(e => e.tenant_id_).HasMaxLength(64);
            entity.Property(e => e.text2_).HasMaxLength(4000);
            entity.Property(e => e.text_).HasMaxLength(4000);
            entity.Property(e => e.type_).HasMaxLength(255);
            entity.Property(e => e.var_scope_).HasMaxLength(64);

            entity.HasOne(d => d.batch_id_Navigation).WithMany(p => p.act_ru_variables)
                .HasForeignKey(d => d.batch_id_)
                .HasConstraintName("act_fk_var_batch");

            entity.HasOne(d => d.bytearray_id_Navigation).WithMany(p => p.act_ru_variables)
                .HasForeignKey(d => d.bytearray_id_)
                .HasConstraintName("act_fk_var_bytearray");

            entity.HasOne(d => d.case_execution_id_Navigation).WithMany(p => p.act_ru_variablecase_execution_id_Navigations)
                .HasForeignKey(d => d.case_execution_id_)
                .HasConstraintName("act_fk_var_case_exe");

            entity.HasOne(d => d.case_inst_id_Navigation).WithMany(p => p.act_ru_variablecase_inst_id_Navigations)
                .HasForeignKey(d => d.case_inst_id_)
                .HasConstraintName("act_fk_var_case_inst");

            entity.HasOne(d => d.execution_id_Navigation).WithMany(p => p.act_ru_variableexecution_id_Navigations)
                .HasForeignKey(d => d.execution_id_)
                .HasConstraintName("act_fk_var_exe");

            entity.HasOne(d => d.proc_inst_id_Navigation).WithMany(p => p.act_ru_variableproc_inst_id_Navigations)
                .HasForeignKey(d => d.proc_inst_id_)
                .HasConstraintName("act_fk_var_procinst");
        });
    }
}
