
drop function split_string
go
drop function SplitDelimiterString
go




ALTER DATABASE [eifcrm] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; 

GO 

ALTER DATABASE [eifcrm] COLLATE   Arabic_CI_AS_KS_WS; 

GO 

ALTER DATABASE [eifcrm] SET MULTI_USER; 

GO 




create  FUNCTION [dbo].[split_string]
(
    @in_string VARCHAR(MAX),
    @delimeter VARCHAR(1)
)
RETURNS @list TABLE(tuple VARCHAR(100))
AS
BEGIN
        WHILE LEN(@in_string) > 0
        BEGIN
            INSERT INTO @list(tuple)
            SELECT left(@in_string, charindex(@delimeter, @in_string+',') -1) as tuple
    
            SET @in_string = stuff(@in_string, 1, charindex(@delimeter, @in_string + @delimeter), '')
        end
    RETURN 
END

go 
create FUNCTION [dbo].[SplitDelimiterString] (@StringWithDelimiter VARCHAR(8000), @Delimiter VARCHAR(8))

RETURNS @ItemTable TABLE (Item VARCHAR(8000))

AS
BEGIN
    DECLARE @StartingPosition INT;
    DECLARE @ItemInString VARCHAR(8000);

    SELECT @StartingPosition = 1;
    --Return if string is null or empty
    IF LEN(@StringWithDelimiter) = 0 OR @StringWithDelimiter IS NULL RETURN; 
    
    WHILE @StartingPosition > 0
    BEGIN
        --Get starting index of delimiter .. If string
        --doesn't contain any delimiter than it will returl 0 
        SET @StartingPosition = CHARINDEX(@Delimiter,@StringWithDelimiter); 
        
        --Get item from string        
        IF @StartingPosition > 0                
            SET @ItemInString = SUBSTRING(@StringWithDelimiter,0,@StartingPosition)
        ELSE
            SET @ItemInString = @StringWithDelimiter;
        --If item isn't empty than add to return table    
        IF( LEN(@ItemInString) > 0)
            INSERT INTO @ItemTable(Item) VALUES (@ItemInString);            
        
        --Remove inserted item from string
        SET @StringWithDelimiter = SUBSTRING(@StringWithDelimiter,@StartingPosition + 
                     LEN(@Delimiter),LEN(@StringWithDelimiter) - @StartingPosition)
        
        --Break loop if string is empty
        IF LEN(@StringWithDelimiter) = 0 BREAK;
    END
     
    RETURN
END



