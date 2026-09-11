#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    srand(time(NULL)); //generátor náhodných čísel

    int spravne = 0; //zakládám zde proměnnou 

    for (int i = 0; i < 3; i++) { //generuje 3 náhodná čísla 
        int spravnaOdmocnina = rand() % 100 + 1; //od 1 po 100    
        int cislo = spravnaOdmocnina * spravnaOdmocnina;                 

        int odpoved; //proměnná 
        printf("sqrt(%d) =  ", cislo); 
        scanf("%d", &odpoved);

        if (odpoved == spravnaOdmocnina) { //ověření 
            spravne++; 
        }
    }

    printf("Spravne: %d/3\n", spravne); //výpis počtu správných odpovědí 

    return 0;
}   