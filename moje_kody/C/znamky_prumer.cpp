#include <stdio.h>

int main() {
    int znamka1, znamka2, znamka3;

    printf("Zadej prvni znamku: ");
    scanf("%d", &znamka1);

    printf("Zadej druhou znamku: ");
    scanf("%d", &znamka2);

    printf("Zadej treti znamku: ");
    scanf("%d", &znamka3);

    float prumer = (znamka1 + znamka2 + znamka3) / 3.0;

    printf("Prumer je: %.2f\n", prumer);

    if (prumer > 4.2)
        printf("Neprosel.\n");
    else if (prumer >= 2.5)
        printf("Prosel.\n");
    else
        printf("Prosel vyborne.\n");

    return 0;
}