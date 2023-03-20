using Microsoft.EntityFrameworkCore;
using WF.Engine.DbModels.EngineModels.ExtendModels;
using WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Data;
using WF.Engine.DbModels.EngineModels.PostgreSQL.CSharp.Models;

namespace WF.Engine.DbModels.EngineModels
{
    public class EngineDbContext : EngineTemplateDbContext<EngineDbContext>
    {
        public EngineDbContext(DbContextOptions<EngineDbContext> options)
            : base(options)
        {

        }


        /// <summary>
        /// 业务表单
        /// </summary>
        public DbSet<BusinessForm> BusinessForms { get; set; }



        /// <summary>
        /// 表单附件
        /// </summary>
        public DbSet<FormAttachment> FormAttachments { get; set; }



        /// <summary>
        /// 意见类型表
        /// </summary>
        public DbSet<OpinionType> OpinionTypes { get; set; }

        /// <summary>
        /// 意见表
        /// </summary>
        public DbSet<Opinion> Opinions { get; set; }


        /// <summary>
        /// 最新的已完成的任务
        /// </summary>
        public DbSet<NewestCompletedTask> NewestCompletedTasks { get; set; }


        /// <summary>
        /// 最新的已完成的任务
        /// </summary>
        public DbSet<ExNewestCompletedTask> ExNewestCompletedTasks { get; set; }


        /// <summary>
        /// (历史)已完成的任务
        /// </summary>
        public DbSet<HistoryCompletedTask> HistoryCompletedTasks { get; set; }

        /// <summary>
        /// 用户任务授权表
        /// </summary>
        public DbSet<UserTaskDelegate> UserTaskDelegates { get; set; }

        /// <summary>
        /// 用户任务声明
        /// </summary>
        public DbSet<UserTaskClaim> UserTaskClaims { get; set; }


        public DbSet<CompletedUserTask> CompletedUserTasks { get; set; }


        public DbSet<TodoCcUserTask> TodoCcUserTasks { get; set; }
        public DbSet<HisCcUserTask> HisCcUserTasks { get; set; }

        public DbSet<OpinionTracking> OpinionTrackings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ActRuTask>().Property(e => e.Enabled).HasDefaultValue(false);

            modelBuilder.Entity<BusinessForm>().HasIndex(e => e.BusinessKey).IsUnique();

            //附件 BusinessKey 索引加快查询
            modelBuilder.Entity<FormAttachment>().HasIndex(e => e.BusinessKey);
            modelBuilder.Entity<FormAttachment>().Property(e => e.Order).HasDefaultValue(0);

            modelBuilder.Entity<ActIdInfo>().Property(e => e.Value).HasColumnType("text");

            modelBuilder.Entity<OpinionType>().HasIndex(e => new { e.ProcessDefKey, e.Name }).IsUnique();
            modelBuilder.Entity<Opinion>().HasIndex(e => e.BusinessKey);

            modelBuilder.Entity<OpinionTracking>().HasIndex(e => e.BusinessKey);

            //已完成任务 TaskId唯一
            modelBuilder.Entity<HistoryCompletedTask>().HasIndex(e => new { e.TaskId, e.DisposeName }).IsUnique();
            modelBuilder.Entity<HistoryCompletedTask>().HasIndex(e => e.BusinessKey);
            modelBuilder.Entity<HistoryCompletedTask>().HasIndex(e => e.ProcInstId);
            modelBuilder.Entity<HistoryCompletedTask>().HasIndex(e => e.ExecutionId);
            modelBuilder.Entity<HistoryCompletedTask>().HasIndex(e => e.ActivityId);
            modelBuilder.Entity<HistoryCompletedTask>().HasIndex(e => e.ActivityName);

            //已完成任务 TaskId唯一
            modelBuilder.Entity<NewestCompletedTask>().HasIndex(e => new { e.TaskId, e.DisposeName }).IsUnique();
            //已完成任务 所有者索引
            modelBuilder.Entity<NewestCompletedTask>().HasIndex(e => e.OwnerUserName);
            modelBuilder.Entity<NewestCompletedTask>().HasIndex(e => e.BusinessKey);
            modelBuilder.Entity<NewestCompletedTask>().HasIndex(e => e.ProcessDefKey);


            //已完成任务 TaskId唯一
            modelBuilder.Entity<ExNewestCompletedTask>().HasIndex(e => new { e.TaskId, e.DisposeName }).IsUnique();
            //已完成任务 所有者索引
            modelBuilder.Entity<ExNewestCompletedTask>().HasIndex(e => e.OwnerUserName);
            modelBuilder.Entity<ExNewestCompletedTask>().HasIndex(e => e.BusinessKey);
            modelBuilder.Entity<ExNewestCompletedTask>().HasIndex(e => e.ProcessDefKey);

            modelBuilder.Entity<UserTaskDelegate>(entity =>
            {
                entity.ToTable("user_task_delegate");

                entity.HasIndex(e => e.FromUserName, "idx7iiygw67wxgd3jgydd6slqcac");

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("id");

                entity.Property(e => e.EndDate).HasColumnName("end_date");

                entity.Property(e => e.FromUserName)
                    .HasMaxLength(255)
                    .HasColumnName("from_user_name");

                entity.Property(e => e.IsCopySendToSource).HasColumnName("is_copy_send_to_source");

                entity.Property(e => e.StartDate).HasColumnName("start_date");

                entity.Property(e => e.ToUserName)
                    .HasMaxLength(255)
                    .HasColumnName("to_user_name");
            });

            modelBuilder.Entity<UserTaskClaim>().HasIndex(e => new { e.UserName, e.BusinessKey, e.ClaimType }).IsUnique();



            //抄送用户任务
            modelBuilder.Entity<TodoCcUserTask>().HasIndex(e => e.UserName);
            modelBuilder.Entity<TodoCcUserTask>().HasIndex(e => e.BusinessKey);
            modelBuilder.Entity<TodoCcUserTask>().HasIndex(e => e.ProcessDefKey);
            modelBuilder.Entity<TodoCcUserTask>().HasIndex(e => e.CreateDateTime);

            modelBuilder.Entity<HisCcUserTask>().HasIndex(e => e.UserName);
            modelBuilder.Entity<HisCcUserTask>().HasIndex(e => e.BusinessKey);
            modelBuilder.Entity<HisCcUserTask>().HasIndex(e => e.ProcessDefKey);
            modelBuilder.Entity<HisCcUserTask>().HasIndex(e => e.CreateDateTime);
        }
    }
}
