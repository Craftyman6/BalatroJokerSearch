CREATE PROC spSearchJokers
	@NameContains	NVARCHAR(30),
	@CostMin	INT,
	@CostMax	INT,
	@Rarity	NVARCHAR(20),
	@Ability	NVARCHAR(20)
AS
BEGIN
	SELECT *
	FROM Jokers
	WHERE
		Name LIKE '%' + @NameContains + '%' AND
		Cost >= @CostMin AND
		Cost <= @CostMax AND
		Rarity LIKE @Rarity + '%' AND
		Ability LIKE '%' + @Ability AND
		Ability LIKE @Ability + '%'
END;
