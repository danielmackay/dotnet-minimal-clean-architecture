using MediatR;

namespace MinimalApi.Application.TodoItems.Queries.GetTodoItem;

public class GetTodoItemQuery : IRequest<TodoItemDto>
{
    public required int Id { get; init; }
}

public class GetTodoItemHandler : IRequestHandler<GetTodoItemQuery, TodoItemDto>
{
    public Task<TodoItemDto> Handle(GetTodoItemQuery request, CancellationToken cancellationToken)
    {
        var todoItem = new TodoItemDto
        {
            Id = 1,
            Title = "Todo Item 1",
            IsCompleted = false
        };

        return Task.FromResult(todoItem);
    }
}
