using MediatR;

namespace MinimalApi.Application.TodoItems.Commands.UpdateTodoItem;

public class UpdateTodoItemCommand : IRequest
{
    public required int Id { get; set; }
    public required string Name { get; init; }
    public required bool IsComplete { get; init; }
}

public class UpdateTodoItemCommandHandler : IRequestHandler<UpdateTodoItemCommand>
{
    public Task<Unit> Handle(UpdateTodoItemCommand request, CancellationToken cancellationToken)
    {
        // Update TodoItem

        return Unit.Task;
    }
}
