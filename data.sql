create table Countries
(
    Id   int identity
        constraint PK_Countries
            primary key,
    Name nvarchar(max)
)
go

create table Transactions
(
    Id           int identity
        constraint PK_Transactions
            primary key,
    BookId       int       not null,
    UserId       int       not null,
    PurchaseDate datetime2 not null,
    DeliveryDate datetime2 not null,
    PenaltyPoint int       not null
)
go

