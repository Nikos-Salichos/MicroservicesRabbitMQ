.NET 6 Project with  microservices and RabbitMQ.

It contains an example with 2 APIs that communicate through RabbitMQ.

EF Core guidelines to create the 2 databases:
1) Set MicroRabbit.Transfer.Api as Startup Project
2) Open Package Manager Console and type:
3) Add-Migration "Initial Migration" -Context TransferDbContext
4) Update-Database "Initial Migration" -Context TransferDbContext
