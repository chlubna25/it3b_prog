#include <stdio.h>
#include <string.h>

int main() {
    char text[201];

    printf("Zadej text: "); //vstup
    scanf("%200s", text);  

    int pocet = 0;
    int soucet = 0;

    for (int i = 0; text[i] != '\0'; i++) {
        if (text[i] >= '0' && text[i] <= '9') {
            pocet++;


            soucet = soucet + (text[i] - '0');
        }
    }

    printf("Pocet cisel: %d\n", pocet); //vystupy
    printf("Soucet: %d\n", soucet);

    return 0;
}