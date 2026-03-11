using TaskManager.Api.DTOs;
using TaskManager.Api.Models;

public interface ITaskService
{
    Task<List<TaskItem>> GetTasksAsync();
    Task<TaskItem> CreateTaskAsync(CreateTaskDto dto);
}