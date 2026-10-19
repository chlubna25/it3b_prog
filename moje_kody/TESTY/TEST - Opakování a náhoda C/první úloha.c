#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    srand(time(NULL));

    int kostka1 = 0;
    int kostka2 = 1; //zde jsem nastavil hodnotu 1 kvuli cyklu while, jinak me to házelo chybu
    int pocetHodu = 0;

    printf("Hody:\n\n");

    while (kostka1 != kostka2) {
        kostka1 = rand() % 6 + 1; // Generuje cislo od 1 do 6
        kostka2 = rand() % 6 + 1; // Generuje cislo od 1 do 6
        pocetHodu++;
        printf("%d, %d\n", kostka1, kostka2); //zde vypisuji hodnoty hodu
    }

    printf("\nPadla dvojce: %d, %d\n", kostka1, kostka2); //výpis hodnoty dvojic 
    printf("Pocet hodu do dvojce: %d\n", pocetHodu); //výpis, kolik hodů bylo potřeba 



    return 0;
}