﻿namespace Auditt.Domain.Shared;

public class Result
{
    protected internal Result(bool isSuccess, string? message, int? count = 0)
    {
        IsSuccess = isSuccess;
        Message = message;
        Count = count ?? 0;
    }

    protected internal Result(bool isSuccess, Error? error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }
    public bool IsSuccess { get; }
    public string? Message { get; }

    public bool IsFailure => !IsSuccess;

    public Error? Error { get; }

    public int Count { get; }

    public static Result Success(string message) => new(true, message);

    public static Result Failure(Error error) => new(false, error);


}



