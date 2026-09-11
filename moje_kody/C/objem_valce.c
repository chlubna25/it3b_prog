#include <stdio.h>
#include <math.h>

double objem_valce(int polomer, int vyska) {
    return M_PI * polomer * polomer * vyska;
}

int main() {
    int polomer, vyska;
    printf("Zadej polomer a vysku valce: ");
    scanf("%d %d", &polomer, &vyska);

    double objem = objem_valce(polomer, vyska);
    printf("Objem valce je: %.2f\n", objem);

    return 0;
}
