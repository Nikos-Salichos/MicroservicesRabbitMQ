.NET 6 Project with  microservices and RabbitMQ.

It contains an example with 2 APIs that communicate through RabbitMQ.

EF Core guidelines to create the 2 databases:

- BankingDb
1) Set MicroRabbit.Banking.Api as Startup Project
2) Open Package Manager Console , set default project: MicroRabbit.Banking.Data and type:
3) Add-Migration "Initial Migration" -Context BankingDbContext
4) Update-Database "Initial Migration" -Context BankingDbContext


- TransferDb
1) Set MicroRabbit.Transfer.Api as Startup Project
2) Open Package Manager Console , set default project: MicroRabbit.Transfer.Data and type:
3) Add-Migration "Initial Migration" -Context TransferDbContext
4) Update-Database "Initial Migration" -Context TransferDbContext
