﻿using Auditt.Application.Domain.Entities;
using Auditt.Application.Infrastructure.Sqlite;
using Auditt.Domain.Shared;
using Carter;
using Carter.ModelBinding;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

namespace Auditt.Application.Features.Roles;

public class GetRoles : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("api/roles", async (IMediator mediator) =>
        {
            return await mediator.Send(new GetRolesCommand());
        })
        .WithName(nameof(GetRoles))
        .WithTags(nameof(Role))
        .ProducesValidationProblem()
        .Produces<List<GetRolesResponse>>(StatusCodes.Status200OK);
    }
    public record GetRolesCommand() : IRequest<IResult>;
    public record GetRolesResponse(int Id, string Name, string Description);

    public class GetRolesHandler(AppDbContext context) : IRequestHandler<GetRolesCommand, IResult>
    {
        public async Task<IResult> Handle(GetRolesCommand request, CancellationToken cancellationToken)
        {

            var roles = await context.Roles.ToListAsync(cancellationToken);
            if (roles == null || roles.Count == 0)
            {
                return Results.NotFound(new { Message = "No se encontraron roles" });
            }
            var resModel = roles.Select(role => new GetRolesResponse(role.Id, role.Name, role.Description)).ToList();
            return Results.Ok(Result<List<GetRolesResponse>>.Success(resModel, "Roles encontrados correctamente"));
        }
    }
}