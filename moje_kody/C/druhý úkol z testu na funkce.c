#include <stdio.h>

void ramecek(int sirka, int vyska) { //prvni funkce 

    if(sirka < 2 || vyska < 2) { //overeni vstupu 
        printf("CHYBA\n");
        return; //nemusi tady byt 
    }


    for(int i = 0; i < sirka; i++) {
        printf("#");
    }
    printf("\n");


    for(int radek = 0; radek < vyska - 2; radek++) { //vykresleni 
        printf("#");

        for(int mezera = 0; mezera < sirka - 2; mezera++) {
            printf(" ");
        }
        printf("#\n");
    }


    for(int i = 0; i < sirka; i++) { //vykresleni 
        printf("#");
    }
    printf("\n");
}

int main() { //overeni v mainu podle zadani 

    ramecek(5, 4);
    printf("\n");

    ramecek(2, 3);
    printf("\n");

    ramecek(1, 4);
    printf("\n");

    ramecek(6, 1);
    printf("\n");


    return 0;
}