CREATE PROCEDURE StoreFizzBuzzResult
    @Id INT,
    @Result NVARCHAR(50)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM FizzBuzzResults WHERE Id = @Id)
    BEGIN
        INSERT INTO FizzBuzzResults (Id, Result)
        VALUES (@Id, @Result);
    END
END
