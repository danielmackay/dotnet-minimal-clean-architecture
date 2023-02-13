using MediatR;

namespace MinimalApi.Application.TodoItems.Queries.GetTodoItems;

public class GetTodoItemsQuery : IRequest<List<TodoItemDto>> { }

public class GetTodoItemsHandler : IRequestHandler<GetTodoItemsQuery, List<TodoItemDto>>
{
    public Task<List<TodoItemDto>> Handle(GetTodoItemsQuery request, CancellationToken cancellationToken)
    {
        var todoItems = new List<TodoItemDto>
        {
            new TodoItemDto
            {
                Id = 1,
                Title = "Todo Item 1",
                IsCompleted = false
            },
            new TodoItemDto

            {
                Id = 2,
                Title = "Todo Item 2",
                IsCompleted = false
            },
            new TodoItemDto

            {
                Id = 3,
                Title = "Todo Item 3",
                IsCompleted = false
            }
        };

        return Task.FromResult(todoItems);
    }
}
