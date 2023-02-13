using MediatR;

namespace MinimalApi.Application.TodoItems.Commands.CreateTodoItem;

public class CreateTodoItemCommand : IRequest<int>
{
    public required string Title { get; init; }
}

public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, int>
{
    public Task<int> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
    {
        // Create TodoItem

        return Task.FromResult(1);
    }
}
