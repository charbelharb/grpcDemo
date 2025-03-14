# GrpcServiceShared
A shared library where proto files reside.
## Purpose
Easily create clients that can invoke the RPC methods.
Example:
```
using var channel = GrpcChannel.ForAddress("");
var client = new NiceRpcService.BuildNiceRpcServiceClient(c);
```

# GrpcServiceDemo
Sample App where the methods are invoked - Most of the time it's a microservice; but it can be anything.

# GrpcServiceClientCallDemo
Sample client for making the RPC calls - Most of the time it's a microservice; but it can be anything.