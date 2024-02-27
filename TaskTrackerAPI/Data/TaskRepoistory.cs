using Microsoft.EntityFrameworkCore;

namespace TaskTrackerAPI.Models;

public class TaskRepoistory: ITaskRepoistory
{
    private TaskDbContext taskDbContext;

    public TaskRepoistory(TaskDbContext _taskDbContext)
    {
        taskDbContext = _taskDbContext;
    }

    public async Task<IEnumerable<TaskTracker>> GetAllTasks()
    {
        return await taskDbContext.Tasks.ToListAsync();
    }


    public async Task<TaskTracker> GetTask(int id)
    {
        var result = await taskDbContext.Tasks.FirstOrDefaultAsync(p => p.Id == id);
        return result;
    }


    public async Task<TaskTracker> AddTask(TaskTracker task)
    {
        var result = await taskDbContext.Tasks.AddAsync(task);
        await taskDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<TaskTracker> UpdateTask(int id, TaskTracker task)
    {
        var result = await taskDbContext.Tasks.FirstOrDefaultAsync(p => p.Id == id);

        if(result != null)
        {
            result.Task = task.Task;
            result.Description = task.Description;
            result.Deadline = task.Deadline;
            result.Urgent = task.Urgent;
            await taskDbContext.SaveChangesAsync();
            return result;
        }

        return null;
    }

    public async Task DeleteTask(int id)
    {
        var result = await taskDbContext.Tasks.FirstOrDefaultAsync(p => p.Id == id);
        if(result != null)
        {
            taskDbContext.Tasks.Remove(result);
            await taskDbContext.SaveChangesAsync();
            int pos = 1;
            foreach(var item in taskDbContext.Tasks)
            {
                item.Id = pos;
                pos++;
            }

        }

    }
}

