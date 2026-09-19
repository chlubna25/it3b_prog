#include <stdio.h>

int main() {
    int opakovani;
    printf("Zadej pocet opakovani: ");
    scanf("%d", &opakovani);

    while (opakovani <= 0) {
        printf("Zadal jsi spatnou hodnotu!\n");
        printf("Zadej pocet opakovani znovu: ");
        scanf("%d", &opakovani);
    }

    int hodnota1, hodnota2;
    printf("Zadej hodnotu 1: ");
    scanf("%d", &hodnota1);
    printf("Zadej hodnotu 2: ");
    scanf("%d", &hodnota2);

    char operace;
    printf("Zadej operaci (+, -, *, /): ");
    scanf(" %c", &operace);

    for (int i = 0; i < opakovani; i++) {
        int vysledek;
        switch (operace) {
            case '+': vysledek = hodnota1 + hodnota2; break;
            case '-': vysledek = hodnota1 - hodnota2; break;
            case '*': vysledek = hodnota1 * hodnota2; break;
            case '/':
                if (hodnota2 == 0) {
                    printf("Chyba: deleni nulou!\n");
                    return 1;
                }
                vysledek = hodnota1 / hodnota2;
                break;
            default:
                printf("Neplatna operace!\n");
                return 1;
        }
        printf("Vysledek %d. opakovani: %d\n", i + 1, vysledek);
    }

    return 0;
}