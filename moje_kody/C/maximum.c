#include <stdio.h>

int maximum(int a, int b) {
    if (a > b) {
        return a;
    } else {
        return b;
    }
}

int main() {
    int a, b;
    printf("Zadej dve cisla pro ziskani maxima: ");
    scanf("%d %d", &a, &b);

    int max = maximum(a, b);
    printf("Maximem z cisel %d a %d je: %d\n", a, b, max);

    return 0;
}
