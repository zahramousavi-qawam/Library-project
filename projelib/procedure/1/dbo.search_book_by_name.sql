CREATE PROCEDURE search_book_by_name
	@bkname nvarchar(50),
	@bkwriter nvarchar(50)
AS
    select *from Tbl_book
	where bk_name & bk_writer  like( '%'+@bkname+'%'&'%'+@bkwriter +'%')