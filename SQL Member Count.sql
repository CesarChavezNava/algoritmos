
SELECT ReportsTo, COUNT(ReportsTo) AS Members, ROUND(AVG(Age),0) AS AverageAge
 FROM maintable_FQMRT
  WHERE ReportsTo IS NOT NULL
  GROUP BY ReportsTo
  ORDER BY ReportsTo
