DELIMITER //
CREATE PROCEDURE Sales_Get_OrderDetail(
IN HighLotNo VARCHAR(10)
)
BEGIN

	SELECT sd.LotSeq, sd.ProductCode, mt.MaterialName, mt.MaterialAlias, mt.MaterialSpec, sd.OrderQty, ci.CateValue, sd.Remark
	FROM Sales_OrderDetail sd
	INNER JOIN Info_Material mt ON mt.MaterialCode = sd.ProductCOde
	INNER JOIN Info_CategoryItem ci ON ci.CateCode = mt.UnitCode
	WHERE sd.HighLotNo = HighLotNo
;
END //

DELIMITER ;


CALL Sales_Get_OrderDetail('test')