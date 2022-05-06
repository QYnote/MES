CREATE DEFINER=`Developer`@`%` PROCEDURE `Info_CategoryGroup_C`(
pGroupName VARCHAR(100),
pLevel TINYINT,
pHighGroup VARCHAR(15),
pClientName VARCHAR(100),
pClientIP VARCHAR(15)
)
BEGIN

	DECLARE pGroupCode VARCHAR(15);
    
	/*그룹코드 증가시켜 입력*/
    IF(
		EXISTS(
				SELECT GroupCode
				FROM Info_CategoryGroup 
				WHERE HighGroup = pHighGroup
				)
		)
        
	THEN
		SELECT LPAD( /*3자리수 표현*/ 
					CONV(/*10진수 -> 16진수 변환*/
						CONV( /*16진수 -> 10진수 변환후 + 1*/
							SUBSTR( /*뒤에 3자리만 추출*/
									GroupCode, -3
								), 
							16, 10) + 1,
                        10, 16),
                    3, '0') AS HighNum
		INTO pGroupCode
		FROM Info_CategoryGroup 
		WHERE HighGroup = pHighGroup
		ORDER BY GroupCode DESC
		LIMIT 1;
	ELSE
		SET pGroupCode = '001';
	END IF;
    
	/*Info_CategoryGroup에 입력*/
	INSERT INTO Info_CategoryGroup(GroupCode, GroupName, Level, HighGroup,
									UseYn, CreDt, CreID, CreIP)
	VALUES(	CONCAT(pHighGroup, pGroupCode),
			pGroupName,
			pLevel,
			pHighGroup,
			
			'Y',
			NOW(), 
			pClientName,
			pClientIP);
END