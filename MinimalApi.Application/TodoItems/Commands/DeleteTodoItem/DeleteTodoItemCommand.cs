using MediatR;

namespace MinimalApi.Application.TodoItems.Commands.DeleteTodoItem;

public class DeleteTodoItemCommand : IRequest
{
    public required int Id { get; set; }
}

public class DeleteTodoItemCommandHandler : IRequestHandler<DeleteTodoItemCommand>
{
    public Task<Unit> Handle(DeleteTodoItemCommand request, CancellationToken cancellationToken)
    {
        // Delete TodoItem

        return Unit.Task;
    }
}
