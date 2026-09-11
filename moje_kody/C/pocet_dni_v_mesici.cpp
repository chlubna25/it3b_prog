#include <stdio.h>

int main() {
    int mesic;
    printf("Zadej cislo mesice (1-12): ");
    scanf("%d", &mesic);

    if (mesic < 1 || mesic > 12) {
        printf("Neplatny mesic.");
        return 1;
    }

    int dny;
    if (mesic == 2)
        dny = 28;
    else if (mesic == 4 || mesic == 6 || mesic == 9 || mesic == 11)
        dny = 30;
    else
        dny = 31;

    printf("Pocet dni v mesici %d je %d.\n", mesic, dny);
    return 0;
}