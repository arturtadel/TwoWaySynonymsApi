﻿CREATE VIEW [dbo].[SynonymsView]
	AS 
		WITH S1 AS (SELECT Id, value as Term, Term as Synonyms, Deleted FROM [dbo].[Synonyms]
		CROSS APPLY string_split(Synonyms, ',')
		UNION SELECT Id, Term, Synonyms, Deleted FROM [dbo].[Synonyms])
		SELECT * FROM S1

