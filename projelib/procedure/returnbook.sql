CREATE PROCEDURE back_book_borrowed
    @stu_code nvarchar(50),
	@bk_code nvarchar(50),
	@date_back nvarchar(50)
AS
 Insert into tbl_borrowed
	(stu_code ,bk_code ,date_back )
	values(@stu_code,@bk_code,@date_back)
