#include <stdio.h>

int umocni_na_3(int x) {
    return x * x * x;
}

int main() {
    int cislo;
    printf("Zadej cislo pro vypocet treti mocniny: ");
    scanf("%d", &cislo);

    int vysledek = umocni_na_3(cislo);
    printf("Treti mocnina cisla %d je: %d\n", cislo, vysledek);

    return 0;
}
