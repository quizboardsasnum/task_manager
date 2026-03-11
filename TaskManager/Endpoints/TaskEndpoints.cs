using TaskManager.Api.DTOs;

public static class TaskEndpoints
{
    public static void MapTaskEndpoints(this WebApplication app)
    {
        app.MapGet("/tasks", async (ITaskService service) =>
        {
            return await service.GetTasksAsync();
        });

        app.MapPost("/tasks", async (CreateTaskDto dto, ITaskService service) =>
        {
            return await service.CreateTaskAsync(dto);
        });
    }
}