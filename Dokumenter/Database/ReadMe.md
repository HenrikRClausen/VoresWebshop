# Om Databasen til VoresWebshop
[Flere noter her]

## Databasens struktur

### Tabel BRUGER

Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**BrugerID** | Int | Ja | Autogenereret
**Brugerrolle** | int | Ja | Tal 1 .. ? 
**Fornavn** | Tekst | Ja | 
**Efternavn** | Tekst | ja | 
**Adresse** | Tekst | Ja | RegEx til tal + bogstaver
**Postnummer** | Int | Ja | 4 cifre 
**By** | Tekst | Ja | 
**Telefon** | Tekst | | Mindst 8
**E-post** | Tekst | Ja | RegEx til format
**Oprettet** | Dato | Ja | Autogenereret

### Tabel PRODUKT
Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**ProduktID** | Int | Ja | Autogenereret
**Navn** | Tekst | Ja | 
**Pris** | Decimal | | RegEx til decimalformat?
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
**OrdreProduktID** | int | Ja | Audogenereret
**OrdreID** | Int | Ja | Fremmed nøgle
**ProduktID** | Int | Ja | Fremmed nøgle
**Oprettet** | Dato | Ja | Autogenereret
**Antal** | UInt | ja | 
**Stykpris**  | Decimal | Ja | På bestillingstidspunktet
