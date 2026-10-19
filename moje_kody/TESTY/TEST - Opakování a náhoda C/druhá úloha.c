#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    srand(time(NULL)); // generátor náhodných čísel

    int teploty[10]; //pole 
    int i, podMrazem = 0; //proměnné
    int soucet = 0;
    int prumer; 

    printf("Naměřené teploty: ");
    for (i = 0; i < 10; i++) { //cyklus 
        teploty[i] = rand() % 21 - 10; // náhodné číslo od -10 do 10
        printf("%d ", teploty[i]); //zde uživatel zadává hodnoty do pole 
        soucet += teploty[i]; //součet hodnot 
        if (teploty[i] < 0) {
            podMrazem++; //ukládá do hodnoty
        }
    }

    prumer = soucet / 10; //výpočet průměrné teploty

    printf("\nPrůměrná teplota: %d °C\n", prumer); //výpis výsledků
    printf("Počet měření pod bodem mrazu: %d\n", podMrazem); //výpis hodnot, které jsou pod nulou

    return 0;
}