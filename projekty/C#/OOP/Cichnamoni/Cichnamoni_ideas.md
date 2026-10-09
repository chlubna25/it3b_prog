# Cichnamoni - Návrh Hry

## Třídy
- Program
- Útok
- Cichnamon
- Trenér

## Hlavní Cyklus

Hra pokračuje **dokud** je HP hráče > 0 **a** hráč chce pokračovat.

### Mechaniky Boje

**Poškození:**
- Hráč si může vybrat typ útoku (základní nebo speciální)
- Poškození je náhodné
- Enemy má náhodné poškození: maximálně 1/2 HP hráče na útok

**Lečení:**
- Hráč se může uzdravit na 20% až 50% svého aktuálního HP
- Dostupné jednou za [DOPLNIT] útoků

**Feedback po každém útoku:**
- Zobrazí se, zda je Cichnamon živý
- Zobrazí se aktuální HP

---

## Pravidla

### Výběr Cichnamona
- Hráč si vybere Cichnamona ze 3 možných
- Počítač dostane stejného Cichnamona

### Možnosti Boje

#### Hráč:
| Typ | Efekt |
|-----|-------|
| **Základní útok** | Náhodné poškození do 1/3 HP nepřítele |
| **Speciální útok** | Maximálně 1/3 až 1/2 HP nepřítele |
| **Léčení** | Uzdravení až 1/2 HP Cichnamona |

#### Počítač:
- **Styl útoku:** Náhodný (70% základní, 30% speciální)
- **Základní útok:** 15% HP hráče
- **Speciální útok:** 30% HP hráče

### Konec Hry
Hra končí, když:
- HP hráče = 0, nebo
- Hráč se rozhodne skončit
