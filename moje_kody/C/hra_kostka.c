#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int ucet = 1000;
    char pokracovat = 'a';
    int padlo, tip;
    int sazka;

    srand(time(NULL));  // Inicializace náhodného generátoru

    while (ucet > 0 && pokracovat == 'a') {
        printf("Aktualni zůstatek: %d\n", ucet);  // Zobrazí aktuální účet
        printf("Kolik chces vsadit? ");
        scanf("%d", &sazka);

        // Kontrola, zda sázka není větší než zůstatek
        if (sazka > ucet) {
            printf("Sazka je vetsi jak hodnota uctu!!!\n");
            return 1;  // Pokud ano, hra končí s chybou
        }

        printf("Jaky je tvuj tip? Panna [0], Orel [1]: ");
        scanf("%d", &tip);

        // Generování náhodného čísla pro padlo (0 = Panna, 1 = Orel)
        padlo = rand() % 2;

        // Porovnání tipu s padlem
        if (tip == padlo) {
            printf("Vyhral jsi! Padlo: %s\n", (padlo == 0) ? "Panna" : "Orel");
            ucet += sazka;  // Zvýšení účtu o sázku
        }
        else {
            printf("Prohral jsi! Padlo: %s\n", (padlo == 0) ? "Panna" : "Orel");
            ucet -= sazka;  // Snížení účtu o sázku
        }

        // Výzva pro pokračování nebo ukončení hry
        printf("Chces hru pokracovat? [a/n]: ");
        scanf(" %c", &pokracovat);  // Mezera před %c kvůli odchytávání zbytku po předchozím scanf
    }

    // Konec hry
    if (ucet <= 0) {
        printf("Tvuj ucet je prazdny! Konec hry.\n");
    }
    else if (pokracovat != 'a') {
        printf("Hra byla ukoncena.\n");
    }

    return 0;
}
