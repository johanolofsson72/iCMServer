use [iCMServer]
GO

UPDATE lgt_languagetext SET lgt_text = 'Inlagd' WHERE lgt_location LIKE 'iConsulting.iCMServer.Modules.Discussion' AND lgt_phrase LIKE 'discussion_created' AND lng_id = 2
UPDATE lgt_languagetext SET lgt_text = 'Inlagd' WHERE lgt_location LIKE 'iConsulting.iCMServer.Modules.Discussion' AND lgt_phrase LIKE 'discussion_posted' AND lng_id = 2

