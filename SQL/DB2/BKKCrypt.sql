CREATE FUNCTION BKK_CRYPT (PASSWORD VARCHAR(4000))
	RETURNS VARCHAR(4000)
	LANGUAGE SQL
	CONTAINS SQL
	NO EXTERNAL ACTION
	DETERMINISTIC

	RETURN PASSWORD;
END