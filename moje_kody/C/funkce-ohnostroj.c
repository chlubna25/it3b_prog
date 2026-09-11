#include <stdio.h>

// Funkce pro zobrazení ohňostroje
void ohnostroj(char vybuch, char jiskra) { 
    printf("           %c           \n", jiskra); // Horní část ohňostroje
    printf("         %c   %c         \n", jiskra, jiskra); // Další vrstvy
    printf("       %c       %c       \n", jiskra, jiskra); 
    printf("     %c           %c     \n", jiskra, jiskra);
    printf("   %c   %c       %c   %c   \n", jiskra, jiskra, jiskra, jiskra); // Více jisker v širší formaci
    printf(" %c %c %c %c %c %c %c %c %c \n", jiskra, jiskra, jiskra, vybuch, jiskra, jiskra, jiskra, jiskra, jiskra); // Středový výbuch
    printf("     %c   %c       \n", jiskra, jiskra); // Spodní část
    printf("       %c   %c     \n", jiskra, jiskra); 
    printf("         %c         \n", jiskra); // Spodní část ohňostroje

    printf("\n"); // Prázdný řádek pro lepší čitelnost mezi výbuchy
}

// Hlavní funkce
int main() {
    char stred, jiskra;

    // Získání znaků pro střed a jiskry od uživatele
    printf("Zadej znak pro stred (např. @ nebo +):  ");
    scanf(" %c", &stred); // Používáme správný formát pro scanf

    printf("Zadej znak pro jiskry (např. * nebo o):  ");
    scanf(" %c", &jiskra);

    // Zobrazení ohňostroje
    ohnostroj(stred, jiskra);

    return 0;
}
