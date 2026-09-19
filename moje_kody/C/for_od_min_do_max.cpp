#include <stdio.h>

int main() {
    printf("Zadej minimum: ");
    int minimum;
    scanf("%d", &minimum);

    printf("Zadej maximum: ");
    int maximum;
    scanf("%d", &maximum);

    if (minimum > maximum) {
        printf("Neplatna hodnota!");
        return 1;
    }

    for (; minimum <= maximum; minimum++) {
        printf("%d\n", minimum);
    }

    return 0;
}