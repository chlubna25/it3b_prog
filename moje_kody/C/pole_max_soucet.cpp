#include <stdio.h>

int main() {
    int pole[10];

    for (int i = 0; i < 10; i++) {
        printf("Zadej cislo %d: ", i + 1);
        scanf("%d", &pole[i]);
    }

    int max_soucet = pole[0] + pole[1];

    for (int i = 1; i < 9; i++) {
        int aktualni = pole[i] + pole[i + 1];
        if (aktualni > max_soucet)
            max_soucet = aktualni;
    }

    printf("Nejvetsi soucet dvou po sobe jdoucich prvku: %d\n", max_soucet);
    return 0;
}