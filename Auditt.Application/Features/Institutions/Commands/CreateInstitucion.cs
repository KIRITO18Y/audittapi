﻿using Carter;
using Carter.ModelBinding;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Auditt.Application.Domain.Entities;
using Auditt.Application.Infrastructure.Sqlite;
using Auditt.Domain.Shared;


namespace Auditt.Application.Features.Institutions;

public class CreateInstitucion: ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/institutions", async (HttpRequest req, IMediator mediator, CreateInstitucionCommand command) =>
        {
            return await mediator.Send(command);
        })
        .WithName(nameof(CreateInstitucion))
        .WithTags(nameof(Institution))
        .ProducesValidationProblem()
        .Produces<CreateInstitucionResponse>(StatusCodes.Status201Created);
    }

    public record CreateInstitucionCommand : IRequest<IResult>
    {
        public string Name { get; init; } = string.Empty;
        public string Abbreviation { get; init; } = string.Empty;
        public string Nit { get; init; } = string.Empty;
        public string City { get; init; } = string.Empty;
    }

    public record CreateInstitucionResponse(string Name, string Abbreviation, string Nit, string City);

    public class CreateInstitucionHandler(AppDbContext context, IValidator<CreateInstitucionCommand> validator) : IRequestHandler<CreateInstitucionCommand, IResult>
    {
        public async Task<IResult> Handle(CreateInstitucionCommand request, CancellationToken cancellationToken)
        {
            var result = validator.Validate(request);
            if (!result.IsValid)
            {
                return Results.Ok(Result<IResult>.Failure(Results.ValidationProblem(result.GetValidationProblems()), new Error("Login.ErrorValidation", "Se presentaron errores de validación")));
            }
            var newInstitucion = Institution.Create(0, request.Name, request.Abbreviation, request.Nit, request.City);
            context.Add(newInstitucion);
            var resCount = await context.SaveChangesAsync();
            if (resCount > 0)
            {
                var resModel = new CreateInstitucionResponse(newInstitucion.Name, newInstitucion.Abbreviation, newInstitucion.Nit, newInstitucion.City);
                return Results.Ok(Result<Institution>.Success(newInstitucion, "Institución creada correctamente"));
            }
            else
            {
                return Results.Ok(Result.Failure(new Error("Login.ErrorCreateInstitucion", "Error al crear la institución")));
            }
        }
    }

    public class CreateInstitucionValidator : AbstractValidator<CreateInstitucionCommand>
    {
        public CreateInstitucionValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("El nombre de la institución es requerido")
                .MinimumLength(3).WithMessage("El nombre de la institución debe tener al menos 3 caracteres");
            RuleFor(x => x.Abbreviation)
                .NotEmpty().WithMessage("La abreviatura de la institución es requerida")
                .MinimumLength(2).WithMessage("La abreviatura de la institución debe tener al menos 2 caracteres");
            RuleFor(x => x.Nit)
                .NotEmpty().WithMessage("El NIT de la institución es requerido")
                .Matches(@"^\d{1,3}(\.\d{3}){2}-\d$").WithMessage("El NIT de la institución no es válido");
            RuleFor(x => x.City)
                .NotEmpty().WithMessage("La ciudad de la institución es requerida")
                .MinimumLength(3).WithMessage("La ciudad de la institución debe tener al menos 3 caracteres");
        }
    }
}

