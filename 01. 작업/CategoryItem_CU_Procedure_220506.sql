CREATE DEFINER=`Developer`@`%` PROCEDURE `Info_CategoryItem_CU`(
pGroupCode VARCHAR(100),
pItemCode VARCHAR(10),
pItemValue VARCHAR(100),
pRemark VARCHAR(500),
pClientName VARCHAR(100),
pClientIP VARCHAR(15)
)
BEGIN

	IF (EXISTS(
			   SELECT GroupCode, ItemCode
			   FROM Info_CategoryItem
               WHERE GroupCode = pGroupCode
               AND ItemCode = pItemCode
               )
		)
        
	THEN       
        UPDATE Info_CategoryItem 
        SET ItemValue = pItemValue,
			Remark = pRemark,
            
            ModDt = NOW(),
            ModID = pClientName,
            ModIP = pClientIP
		WHERE GroupCode = pGroupCode
		AND ItemCode = pItemCode ;
        
	ELSE /*Insert*/
		
		/*아이템코드 증가시켜 입력*/
		IF (EXISTS(
				SELECT GroupCode, ItemCode
				FROM Info_CategoryItem
				WHERE GroupCode = pGroupCode
				)
			)
			
		THEN /*해당그룹코드에 아이템이 있으면 + 1*/
        
			SELECT LPAD( /*2자리수 표현*/ 
						CONV(/*10진수 -> 16진수 변환*/
							CONV( /*16진수 -> 10진수 변환후 + 1*/
								SUBSTR( /*뒤에 2자리만 추출*/
										ItemCode, -2
									), 
								16, 10) + 1,
							10, 16),
						2, '0') AS HighNum
			INTO pItemCode
			
			FROM Info_CategoryItem 
			WHERE GroupCode = pGroupCode
			ORDER BY ItemCode DESC
			LIMIT 1;
		ELSE /*해당 그룹코드 아이템 신규등록*/
			SET pItemCode = '01';
		END IF;
    
		/*데이터 입력*/
		INSERT INTO Info_CategoryItem (GroupCode, ItemCode, ItemValue, Remark,
									   UseYn, CreDt, CreID, CreIP)
        VALUES (pGroupCode,
				CONCAT('CI', pItemCode),
				pItemValue,
				pRemark,
                
                'Y',
                NOW(),
				pClientName,
				pClientIP);
    
    END IF;
        
END