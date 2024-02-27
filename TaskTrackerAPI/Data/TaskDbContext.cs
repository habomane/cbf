using System;
using Microsoft.EntityFrameworkCore;

namespace TaskTrackerAPI.Models;

public class TaskDbContext : DbContext 
{
	public TaskDbContext(DbContextOptions<TaskDbContext> options): base(options) {}

	public DbSet<TaskTracker> Tasks { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{ base.OnModelCreating(modelBuilder); }

}

