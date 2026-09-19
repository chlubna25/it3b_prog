#include <stdio.h>
#include <math.h>

double pythagoras(int a, int b) {
    return sqrt(a * a + b * b);
}

int main() {
    int a, b;
    printf("Zadej dve strany pravouheho trojuhelnika (a, b): ");
    scanf("%d %d", &a, &b);

    double c = pythagoras(a, b);
    printf("Prepona c je: %.2f\n", c);

    return 0;
}
