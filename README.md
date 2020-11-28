# PetesCodeSpike

Here's the SQL code executed for the query...

``` sql
   SELECT TOP(@__p_2) [g].[message_id], [g].[last_contact]
      FROM [GEMMessages] AS [g]
      WHERE ([g].[last_contact] >= @__startDate_0) AND ([g].[last_contact] <= @__endDate_1)
      ORDER BY [g].[message_id] DESC

```

This uses LocalDB and seeds some data as part of the configuration in `ApplicationDbContext`
