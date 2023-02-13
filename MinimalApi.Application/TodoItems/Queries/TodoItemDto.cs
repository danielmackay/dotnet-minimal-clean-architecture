namespace MinimalApi.Application.TodoItems.Queries;

public class TodoItemDto
{
    public int Id { get; init; }
    public required string Title { get; init; }
    public bool IsCompleted { get; init; }
}
