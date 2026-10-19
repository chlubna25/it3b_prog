#include <stdio.h> 
int main() {
    float pole[8];
    for (int i = 0; i < 8; i++) {
        printf("Zadej cislo %d: ", i + 1);
        scanf("%f", &pole[i]);
 
        if (pole[i] < 0) {
            printf("Zadal jsi spatnou hodnou! ");
            return 1;
        }
    }
    float maximum = pole[0];
    float nejmensi = pole[0];
 
    for (int i = 1; i < 8; i++) {
        if (pole[i] > maximum) {
            maximum = pole[i];
        }
    }
 
    for (int i = 1; i < 8; i++) {
        if (pole[i] < nejmensi) {
            nejmensi = pole[i];
        }
    }
    float rozdil = maximum - nejmensi;
 
    printf("Nejvetsi cislo je: %.2f", rozdil);
 
    return 0;
}