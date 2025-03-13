using System.Text.Json;
using Grpc.Core;
using GrpcServiceShared;

namespace GrpcServiceDemo.Services;

public class BuildTemplateService : BuildTemplateDemoYo.BuildTemplateDemoYoBase
{
    public override async Task<TakeSomethingBackYo> BTOne(SendMeSomethingToProcessYo request, ServerCallContext context)
    {
        return await Task.Run(() =>
        {
            var someRandomStruct = new
            {
                request.Id,
                request.Name,
                request.SnakeCaseLol,
                NestedName = request.ICanHaveNestedMessages.Name,
                someDate = request.ICanHaveNestedMessages.WhatHowWhen.ToDateTime()
            };
            Console.WriteLine(JsonSerializer.Serialize(someRandomStruct));
            return new TakeSomethingBackYo
            {
                Success = true
            };
        });
    }
    
    public override async Task<TakeSomethingElseBackYo> BTTwo(SendMeAnotherThingToProcessYo request, ServerCallContext context)
    {
        return await Task.Run(() =>
        {
            var someRandomStruct = new
            {
                request.Id,
                request.Name
            };
            Console.WriteLine(JsonSerializer.Serialize(someRandomStruct));
            return new TakeSomethingElseBackYo
            {
                Success = true
            };
        });
    }
}