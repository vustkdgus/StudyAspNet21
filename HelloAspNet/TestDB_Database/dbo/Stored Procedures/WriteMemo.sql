
CREATE Procedure [dbo].[WriteMemo]
(
	@Name NVarChar(25),
	@Email NVarChar(100),
	@Title NVarChar(150),
	@PostDate Datetime,
	@PostIP NVarChar(15)
)
As
	Insert Memos(Name, Email, Title, PostDate, PostIP)
	Values(@Name, @Email, @Title, @PostDate, @PostIP)
