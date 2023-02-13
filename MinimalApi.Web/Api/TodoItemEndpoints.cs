using MediatR;
using MinimalApi.Application.TodoItems.Commands.CreateTodoItem;
using MinimalApi.Application.TodoItems.Commands.DeleteTodoItem;
using MinimalApi.Application.TodoItems.Commands.UpdateTodoItem;
using MinimalApi.Application.TodoItems.Queries;
using MinimalApi.Application.TodoItems.Queries.GetTodoItem;
using MinimalApi.Application.TodoItems.Queries.GetTodoItems;
using MinimalApi.Web.Extensions;

namespace MinimalApi.Web.Api;

public static class TodoItemEndpoints
{
    public static void MapTodoItemEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("todoitems")
            .WithTags("TodoItems")
            .WithOpenApi();

        group.MapGet("/", (IMediator mediator) => mediator.Send(new GetTodoItemsQuery()))
            .WithName("GetTodoItems")
            .ProducesGet<TodoItemDto[]>();

        group.MapGet("/{id:int}", (int id, IMediator mediator) => mediator.Send(new GetTodoItemQuery { Id = id }))
            .WithName("GetTodoItem")
            .ProducesGet<TodoItemDto>();

        group.MapPost("/", (CreateTodoItemCommand command, IMediator mediator) => mediator.Send(command))
            .WithName("CreateTodoItem")
            .ProducesPost();

        group.MapPut("/{id:int}", (int id, UpdateTodoItemCommand command, IMediator mediator) =>
            {
                command.Id = id;
                return mediator.Send(command);
            })
            .WithName("UpdateTodoItem")
            .ProducesPut();

        group.MapDelete("/{id:int}", (int id, DeleteTodoItemCommand command, IMediator mediator) => mediator.Send(new DeleteTodoItemCommand { Id = id }))
            .WithName("DeleteTodoItem")
            .ProducesDelete();
    }
}
