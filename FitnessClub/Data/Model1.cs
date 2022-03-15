using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FitnessClub.Data
{
    public partial class Model1 : DbContext
    {
        private static Model1 Instance;
        public static Model1 Init()
        {
            if (Instance == null)
                Instance = new Model1();
            return Instance;
        }
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Rewiew> Rewiews { get; set; }
        public virtual DbSet<ServiceGroup> ServiceGroups { get; set; }
        public virtual DbSet<ServiceImage> ServiceImages { get; set; }
        public virtual DbSet<ServiceOrder> ServiceOrders { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.ClientFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientMiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Rewiews)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.Client_ClientId);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Subscriptions)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.SubscriptionClient_ClientId);

            modelBuilder.Entity<Hall>()
                .Property(e => e.HallName)
                .IsUnicode(false);

            modelBuilder.Entity<Hall>()
                .Property(e => e.HallPhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<Hall>()
                .HasMany(e => e.Subscriptions)
                .WithRequired(e => e.Hall)
                .HasForeignKey(e => e.Hall_HallId);

            modelBuilder.Entity<Rewiew>()
                .Property(e => e.RewiewText)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceGroup>()
                .Property(e => e.ServiceGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceGroup>()
                .HasMany(e => e.ServiceOrders)
                .WithRequired(e => e.ServiceGroup)
                .HasForeignKey(e => e.ServiceGroup_ServiceGroupId);

            modelBuilder.Entity<ServiceImage>()
                .Property(e => e.ServiceImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.ServiceDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .Property(e => e.ServicePhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Rewiews)
                .WithRequired(e => e.Service)
                .HasForeignKey(e => e.RewiewService_ServiceId);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ServiceGroups)
                .WithRequired(e => e.Service)
                .HasForeignKey(e => e.Service_ServiceId);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ServiceImages)
                .WithOptional(e => e.Service)
                .HasForeignKey(e => e.Service_ServiceId);

            modelBuilder.Entity<ServiceType>()
                .Property(e => e.ServiceTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceType>()
                .HasMany(e => e.Services)
                .WithRequired(e => e.ServiceType)
                .HasForeignKey(e => e.ServiceType_ServiceTypeId);

            modelBuilder.Entity<Subscription>()
                .HasMany(e => e.ServiceOrders)
                .WithRequired(e => e.Subscription)
                .HasForeignKey(e => e.Subscription_SubscriptionId);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.TrainerFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.TrainerLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.TrainerMiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.TrainerDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.TrainerPhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .HasMany(e => e.Subscriptions)
                .WithOptional(e => e.Trainer)
                .HasForeignKey(e => e.Trainer_TrainerId);
        }
    }
}
