SELECT *
FROM ContactDetails
WHERE IsActive = true
AND AreaCode = '012'

UPDATE ContactDetails
SET IsActive = true
WHERE [Description] LIKE '%x%'
AND [Order] <= 50

SELECT *
FROM ContactDetails
ORDER BY Id ASC

SELECT *,CONCAT(AreaCode,Telephone) AS TelephoneNumber
FROM ContactDeatils
