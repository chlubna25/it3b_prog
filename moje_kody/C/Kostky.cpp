#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int pocetKostek, pocetSten;


    srand(time(NULL));

    printf("Zadej poèet kostek: ");
    scanf("%d", &pocetKostek);

    printf("Zadej poèet stìn na jedné kostce: ");
    scanf("%d", &pocetSten);

    if (pocetKostek <= 0 || pocetSten <= 1) {
        printf("Neplatný vstup.\n");
        return 1; //chyba
    }

    int soucet = 0;

    printf("Hody:\n");

    for (int i = 1; i <= pocetKostek; i++) {
        int hod = (rand() % pocetSten) + 1;
        printf("Kostka %d: %d\n", i, hod);
        soucet += hod;
    }

    printf("Souèet všech hodù: %d\n", soucet);

    return 0;
}

