# Databasestruktur til VoresWebshop

### Tabel BRUGER

Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**BrugerID** | Int | Ja | Autogenereret
**Brugerrolle** | int | Ja | Tal 1 .. ? 
**Fornavn** | Tekst | Ja | 
**Efternavn** | Tekst | ja | 
**Adresse** | Tekst | Ja | 
**Postnummer** | Int | Ja | 4 cifre 
**By** | Tekst | Ja | 
**Telefon** | Tekst | | Mindst 8
**E-post** | Tekst | Ja | RegEx til format: ^[A-Z0-9._%+-]+@(?:[A-Z0-9-]+\.)+[A-Z]{2,}$
**Oprettet** | Dato | Ja | Autogenereret

### Tabel PRODUKT
Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**ProduktID** | Int | Ja | Autogenereret
**Navn** | Tekst | Ja | 
**Pris** | Decimal | | RegEx til decimalformat:  [0-9]+(\.[0-9][0-9]?)?
**Kort beskrivelse** | Tekst | Ja |
**Beskrivelse** | Tekst | Ja | 
**Antal** | Int | Ja | Lagerstand
**Billede** | Byte[] | | 
**Oprettet** | Dato | | Sidste ændring

### Tabel ORDRE
Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**OrdreID** | Int | Ja | Autogenereret
**BrugerID** | Int | Ja | Fremmed nøgle
**Oprettet** | Dato | Ja | Autogenereret
**Godkendt** | Dato ||
**Afsendt** | Dato ||
**Afsluttet** | Dato ||

### Tabel ORDRE_PRODUKT
Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**OrdreProduktID** | int | Ja | Autogenereret
**OrdreID** | Int | Ja | Fremmed nøgle
**ProduktID** | Int | Ja | Fremmed nøgle
**Oprettet** | Dato | Ja | Autogenereret
**Antal** | UInt | ja | 
**Stykpris**  | Decimal | Ja | På bestillingstidspunktet
