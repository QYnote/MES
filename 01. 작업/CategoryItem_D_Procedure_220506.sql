CREATE DEFINER=`Developer`@`%` PROCEDURE `Info_CategoryItem_D`(
pGroupCode VARCHAR(15),
pItemCode VARCHAR(4)
)
BEGIN

    DELETE FROM Info_CategoryItem
    WHERE GroupCode = pGroupCode
    AND ItemCode = pItemCode;

END