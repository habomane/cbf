using System;
namespace TaskTrackerAPI.Models;

public interface ITaskRepoistory
{
    Task<IEnumerable<TaskTracker>> GetAllTasks();

    Task<TaskTracker> GetTask(int id);

    Task<TaskTracker> AddTask(TaskTracker task);

    Task<TaskTracker> UpdateTask(int id, TaskTracker task);

    Task DeleteTask(int id);
}

