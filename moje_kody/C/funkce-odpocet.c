#include <stdio.h>

//funkce
void odpocetSekund(int hodiny, int minuty, int sekundy) {  
    printf("Zbyva %d sekund do pulnoci.\n", //vypis
        86400 - (hodiny * 3600 + minuty * 60 + sekundy));
}

//main
int main() { 
   
    int hodiny, minuty, sekundy;

    printf("Zadej hodiny: ");
    scanf("%d", &hodiny);

    printf("Zadej minuty: ");
    scanf("%d", &minuty);

    printf("Zadej sekundy: ");
    scanf("%d", &sekundy);

    odpocetSekund(hodiny, minuty, sekundy);
    

    return 0;
}
