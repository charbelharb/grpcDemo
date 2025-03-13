// See https://aka.ms/new-console-template for more information

using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using GrpcServiceShared;

Console.WriteLine("Hello, World!");
using var c = GrpcChannel.ForAddress("https://localhost:7060");
var client = new BuildTemplateDemoYo.BuildTemplateDemoYoClient(c);
Console.ReadKey();
client.BTOne(new SendMeSomethingToProcessYo
{
    Id = 1,
    Name = "gRPC yo",
    SnakeCaseLol = "I'm a snake https://www.youtube.com/watch?v=Ti4sqG85FU4",
    ICanHaveNestedMessages = new SomethingInsideTheMessage
    {
        Name = "Nested!!",
        WhatHowWhen = Timestamp.FromDateTime(DateTime.UtcNow)
    }
});
client.BTTwo(new SendMeAnotherThingToProcessYo
{
    Id = 2,
    Name = "gRPC yo"
});
client.BTTwo(new SendMeAnotherThingToProcessYo
{
    Id = 3,
    Name = "gRPC yo",
    ThinkOfMeAsNullable = 3
});
var tt = new List<int> {1, 2, 3, 4,};
var dataType = new DataType
{
    Duh = 1,
    Duh2 = -566,
    Duh3 = 1.1f,
    Duh4 = 33.3333338,
    Duh6 = "I'm a string",
    EnumDuh = DataType.Types.iAmAnEnum.Rpm,
    Duh7 = ByteString.FromBase64("data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAAgAAAAIAQMAAAD+wSzIAAAABlBMVEX///+/v7+jQ3Y5AAAADklEQVQI12P4AIX8EAgALgAD/aNpbtEAAAAASUVORK5CYII"),
    ListOfDuh = {tt},
    DictionaryOfDuh = { new Dictionary<int, string>() { { 1, "one" }, { 2, "two" } } },
    UnsignedInt = 1,
    UnsignedLong = 1,
    SignedInt = -12,
    SignedLong = -12,
    FixedInt = int.MaxValue,
    FixedLong = long.MaxValue,
    SignedFixedInt = -int.MaxValue,
    SignedFixedLong = -long.MaxValue
};