USE [Student]
BEGIN TRANSACTION
INSERT INTO [dbo].[Student]
([StudentId],
[LastName],
[FirstName],
[Address],
[City],
[State],
[ZipCode],
[SchoolCode])
VALUES
(99400001, 'Abbott', 'Allan', '1118 Glenview Lane', 'Eagle Rock', 'CA', 99999, 994),
(99400011, 'Abrahamson', 'Arnold', '1126 E Walton Rd.', 'Eagle Rock', 'CA', 99999, 994),
(99400012, 'Abrego', 'Alice', '115 W Norgate St', 'Eagle Rock', 'CA', 99999, 994),
(99400013, 'Abrego', 'Ivette', '13642 Green Valley B', 'Eagle Rock', 'CA', 99999, 994),
(99400014, 'AbuJohn', 'Edgar', '1123 N Barston Ave', 'Eagle Rock', 'CA', 99999, 994),
(99400015, 'Aceves', 'Steven', '1110 Avenida Loma Vista', 'Eagle Rock', 'CA', 99999, 994)

INSERT INTO [dbo].[Contact]
([StudentId],
[LastName],
[FirstName],
[Relationship],
[EmailAddress],
[Mobile],
[Address],
[City],
[State],
[ZipCode]
)
VALUES
(99400001, 'Abbott', 'Sara', 'Mother', 'sara@example.com', '949-123-4567', '1118 Glenview Lane', 'Eagle Rock', 'CA', 99999),
(99400001, 'Abbott', 'Adam', 'Father', 'adam@example.com', '949-123-4568', '1118 Glenview Lane', 'Eagle Rock', 'CA', 99999),
(99400011, 'Abrahamson', 'Jonathan', 'Uncle', 'jonathan@example.com', '949-234-4567', '1126 E Walton Rd.', 'Eagle Rock', 'CA', 99999),
(99400012, 'Acosta', 'Christine', 'Mother', 'christine@example.com', '949-345-6789', '115 W Norgate St', 'Eagle Rock', 'CA', 99999),
(99400013, 'Abrego', 'Rezvan', 'Father', 'Rezvan@example.com', '949-456-7891', '13642 Green Valley B', 'Eagle Rock', 'CA', 99999),
(99400014, 'AbuJohn', 'Selena', 'Mother', 'Selena@example.com', '949-567-8912', '1123 N Barston Ave', 'Eagle Rock', 'CA', 99999),
(99400015, 'Aceves', 'Jacob', 'Father', 'jacob@example.com', '949-678-9123', '1110 Avenida Loma Vista', 'Eagle Rock', 'CA', 99999)
COMMIT TRANSACTION