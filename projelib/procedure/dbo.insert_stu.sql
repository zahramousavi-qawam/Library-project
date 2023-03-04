CREATE PROCEDURE [dbo].[insert_stu]

    @stu_number nvarchar(50),
	@stu_name nvarchar(50),
	@stu_lname nvarchar(50), 
	@stu_study nvarchar(50),
	@stu_birth nvarchar(50),
	@stu_sex nvarchar(50),
	@stu_status nvarchar(50),
	@stu_address nvarchar(50),
	@stu_phone nvarchar(50),
	@stu_membership nvarchar(50),
	@stu_favorite nvarchar(50),
	@stu_reason nvarchar(50),
	@stu_owned nvarchar(50),
    @stu_borrowed nvarchar(50)

     AS

   insert into tbl_student 
   (stu_number , stu_name , stu_lname , stu_study , stu_birth , stu_sex , stu_status , stu_address ,  stu_phone , stu_membership  , stu_favorite , stu_reason , stu_owned , stu_borrowed)
   values (@stu_number , @stu_name , @stu_lname , @stu_study , @stu_birth , @stu_sex , @stu_status , @stu_address , @stu_phone , @stu_membership , @stu_favorite , @stu_reason , @stu_owned , @stu_borrowed)