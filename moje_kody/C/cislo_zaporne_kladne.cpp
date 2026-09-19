#include <stdio.h>

int main() {
    printf("Zadej cislo:");
    int cislo;
    scanf("%d", &cislo);

    if (cislo < 0) {
        printf("Cislo %d je zaporne", cislo);
    } else {
        printf("Cislo %d je kladne", cislo);
    }

    return 0;
}