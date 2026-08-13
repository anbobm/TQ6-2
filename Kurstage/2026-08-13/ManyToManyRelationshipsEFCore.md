# Konventionen für many to many relationships in EF Core

Wenn man eine *many to many relationship* in einer Datenbank abbilden möchte, dann braucht man eine Zwischentabelle. Auf der OOP-Seite ist es nicht nötig, diese Zwischentabelle explizit abzubilden. Wenn man sich an folgende *Konventionen* hält, passiert alles automatisch, und es reicht bei beiden Entitäten eine collection navigation property einzufügen:

* Die Zwischentabelle heißt so wie die an der Relationship beteiligten Klassen: `Buch` & `Rubrik` => `BuchRubrik`
* Primary Key in Zwischentabelle ist (Foreign Key `Buch`, Foreign Key `Rubrik`)
* Spalten der Foreign Keys heißen wie die referenzierte Tabelle heißt + `Id`, also z.B. `BücherId`