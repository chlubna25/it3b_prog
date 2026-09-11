#include <stdio.h> 
int main() {

    int pole[5];
    int sude = 0;
    int liche = 0;

    for (int i = 0; i < 5; i++) {
        printf("Zadej cislo %d: ", i + 1);
        scanf("%d", &pole[i]);
    }

    for (int i = 0; i < 5; i++) {
        if (pole[i] % 2 == 0) {
            sude++;
        }
        else {
            liche++;
        }
    }

    if (sude > liche) {
        printf("Sudych cisel je vice nez lichych (%d)", sude);
    }
    else {
        printf("Lichych cisel je vice nez sudych (%d)", liche);
    }


    return 0;
}