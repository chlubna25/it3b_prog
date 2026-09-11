#include <stdio.h>

int main() {
    int cislo = 0;
    int hadej = 8;

    while (cislo != hadej) {
        printf("Zadej cislo od 1 do 100: ");
        scanf("%d", &cislo);

        if (cislo < 1 || cislo > 100) {
            printf("Zadal jsi spatnou hodnotu!\n");
            continue;
        }

        if (cislo < hadej)
            printf("Jsi nizko :D\n");
        else if (cislo > hadej)
            printf("Jsi moc vysoko :D\n");
        else
            printf("Mas to spravne! Bylo to cislo: %d\n", cislo);
    }

    return 0;
}