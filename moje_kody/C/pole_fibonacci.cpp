#include <stdio.h>

int main() {
    int pole[23];
    pole[0] = 1;
    pole[1] = 1;

    for (int i = 2; i < 23; i++) {
        pole[i] = pole[i - 1] + pole[i - 2];
        printf("%d\n", pole[i]);
    }

    return 0;
}