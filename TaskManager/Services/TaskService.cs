using TaskManager.Api.DTOs;
using TaskManager.Api.Models;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _repo;

    public TaskService(ITaskRepository repo)
    {
        _repo = repo;
    }

    public async Task<List<TaskItem>> GetTasksAsync()
        => await _repo.GetAllAsync();

    public async Task<TaskItem> CreateTaskAsync(CreateTaskDto dto)
    {
        var task = new TaskItem
        {
        
            Title = dto.Title,
            Description = dto.Description
        };

        await _repo.AddAsync(task);

        return task;
    }
}