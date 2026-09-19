# Projekt Cichnamoni
## Autoři : Roman Svora, Ondřej Sagher 

## Stav projektu

Projekt je funkcni konzolova hra v C#.
Je rozdeleny do trid podle OOP.

## Hotove casti

- trida Utok
- trida Cichnamon
- trida Trener
- Program.cs s hlavnim menu
- vytvareni utoku
- vytvareni Cichnamonu
- vyber Cichnamona
- souboj proti protivnikovi
- zakladni utok
- specialni utok
- leceni
- kontrola zdravi
- konec souboje
- level trenera po vyhre

## Tridy

### Utok

Uklada informace o utoku.

Atributy:
- Nazev
- Poskozeni

Metody:
- VypisInfo()

### Cichnamon

Predstavuje jedno monstrum.

Atributy:
- Jmeno
- Zdravi
- MaxZdravi
- ZakladniUtok
- SpecialniUtok

Metody:
- Zautoc()
- SpecialniZautoc()
- UberZdravi()
- Uzdrav()
- JeNazivu()
- VypisInfo()

### Trener

Predstavuje hrace.

Atributy:
- Jmeno
- Level
- Cichnamoni
- Vybrany

Metody:
- PridatCichnamona()
- VyberCichnamona()
- VypisCichnamony()
- ZvysLevel()
- VypisInfo()

## Jak hra funguje

Hrac zada jmeno trenera.
Potom si vybere jednoho Cichnamona.
Souperi se vytvori nepratelsky Cichnamon.
Hrac v souboji vybira akci:
1. zakladni utok
2. specialni utok
3. leceni

Po kazde akci hrace zautoci protivnik.
Souboj konci, kdyz jeden Cichnamon nema zdravi.
Kdyz hrac vyhraje, zvysi se mu level.
