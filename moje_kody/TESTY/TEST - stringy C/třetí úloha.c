#include <stdio.h>
#include <string.h>

int main() {
    char text[201];

    printf("Zadej text: "); //vstup
    scanf("%200s", text);

    int max_delka = 1;
    int aktualni = 1;
    char max_znak = text[0];

    for (int i = 1; text[i] != '\0'; i++) {
        if (text[i] == text[i - 1]) {
            aktualni++;
        } else {
            aktualni = 1;
        }

        if (aktualni > max_delka) {
            max_delka = aktualni;
            max_znak = text[i];
        }
    }

    printf("Nejdelsi serie: '%c'(%dx)\n", max_znak, max_delka); //vystup

    return 0;
}