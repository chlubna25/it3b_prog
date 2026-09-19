#include <stdio.h>

int main() {
    float vzdalenost, cas;
    printf("Zadej vzdalenost (m): ");
    scanf("%f", &vzdalenost);
    printf("Zadej cas (s): ");
    scanf("%f", &cas);

    if (vzdalenost <= 0 || cas <= 0) {
        printf("Chybny udaj!");
        return 1;
    }

    float rychlost = vzdalenost / cas;
    printf("Tvoje rychlost je: %.2f m/s\n", rychlost);

    if (rychlost >= 30)
        printf("Jsi rychlejsi nez gepard!\n");
    else if (rychlost >= 15)
        printf("Jsi rychly jako kun!\n");
    else if (rychlost >= 5)
        printf("Jsi rychlejsi nez slon.\n");
    else
        printf("Jsi pomalejsi nez zelva :D\n");

    return 0;
}