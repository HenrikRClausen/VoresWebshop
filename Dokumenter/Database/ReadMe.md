# Om Databasen til VoresWebshop
[Flere noter her]

## Databasens struktur
Dette er en kopi af Chris' oplæg.

### Tabel BRUGER

Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**BrugerID** | Int | Ja | Autogenereret
**Brugernavn** | Tekst | Ja | 
**Fornavn** | Tekst | | 
**Efternavn** | Tekst | | 
**Adresse** | Tekst | | 
**Postnummer** | Int | | 
**By** | Tekst | | 
**Telefon** | Tekst | | 
**E-post** | Tekst | | 
**Oprettet** | Dato | | 
**Redigeret** | Dato | | 

Spørgsmål: Skal brugere kunne have flere roller?

### Tabel BRUGERROLLE

Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**BrugerrolleID** | Int | Ja | Autogenereret
**Brugerrolle** | Tekst | Ja |
**Oprettet** | Dato | |
**Redigeret** | Dato | |

### Tabel PRODUKT
Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**ProduktID** | Int | Ja | Autogenereret
**Navn** | Tekst | Ja |
**Pris** | Decimal | |
**Kort beskrivelse** | Tekst | |
**Beskrivelse** | Tekst | |
**Antal** | Int | Ja | Lagerstand
**GrafikID** | Int | | Fremmed nøgle
**Redigeret** | Dato | | Sidste ændring

### Tabel GRAFIK 
Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**GrafikID** | Int | Ja | Autogenereret
**Grafik** | Blob | Ja | Selve billedet
**Oprettet** | Dato ||
**Redigeret** | Dato ||

Der findes kun én grafik til hvert produkt - er det nok?

### Tabel ORDRE
Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**OrdreID** | Int | Ja | Autogenereret
**BrugerID** | Int | Ja | Fremmed nøgle
**Oprettet** | Dato | Ja |
**Redigeret** | Dato ||
**Godkendt** | Dato ||
**Afsendt** | Dato ||
**Afsluttet** | Dato ||

### Tabel ORDRE_PRODUKT
Navn | Type | Obligatorisk | Kommentar
--- | --- | --- | ---
**OrdreID** ||| 
**ProduktID** ||| Fremmed nøgle
**Oprettet** | Dato ||
**Redigeret** | Dato ||
**Antal** | UInt | ja | 
**Stykpris**  | Decimal || På bestillingstidspunktet

Der mangler vist et ID-felt til denne tabel?
