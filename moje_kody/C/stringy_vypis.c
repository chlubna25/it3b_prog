#include <stdio.h>

int main() {

    printf("Zadej slovo: ");
    char slovo[10];
    scanf("%s", &slovo);

    printf("Kolikrat chces string opakovat? ");
    int opakovani;
    scanf("%d", &opakovani);

    if (opakovani <= 0) {
        printf("Zadal jsi spatnou hodnotu!!!");
        return 1; //chyba 
    }

    for (int i = 0; i < opakovani; i++) {
        printf("Zadany string: %s\n", slovo);
    }

    return 0;
}