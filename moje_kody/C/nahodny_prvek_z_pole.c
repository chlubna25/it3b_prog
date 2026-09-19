#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    srand(time(NULL));
    char znak[5]; 

    for (int i = 0; i < 5; i++) {
        printf("Zadej libovolný znak/číslo: ");
        scanf(" %c", &znak[i]);
    }

    int index = rand() % 5;
    printf("Náhodně vybraný znak z tvých možností je: '%c'\n", znak[index]);

    return 0;
}
