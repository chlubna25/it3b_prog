#include <stdio.h>

int main() {
    printf("Zadej pocet opakovani: ");
    int opakovani;
    scanf("%d", &opakovani);


    while (opakovani <= 0) {
        printf("Zadal jsi spatnou hodnotu !!!\n");
        printf("Zadej pocet opakovani: ");
        scanf("%d", &opakovani);
    }

   
    printf("Zadej hodnotu 1): ");
    int hodnota1;
    scanf("%d", &hodnota1);

    printf("Zadej hodnotu 2): ");
    int hodnota2;
    scanf("%d", &hodnota2);

  
    printf("Zadej operaci (+, -, *, /): ");
    char operace;
    scanf(" %c", &operace);  

   
    for (int i = 0; i < opakovani; i++) {
        int vypocet;
        switch (operace) {
        case '+':
            vypocet = hodnota1 + hodnota2;
            break;
        case '-':
            vypocet = hodnota1 - hodnota2;
            break;
        case '*':
            vypocet = hodnota1 * hodnota2;
            break;
        case '/':
            if (hodnota2 != 0) {
                vypocet = hodnota1 / hodnota2;
            }
            else {
                printf("Chyba: d?len� nulou!\n");
                return 1;  
            }
            break;
        default:
            printf("Neplatn� operace!\n");
            return 1;  
        }
        printf("Vysledek %d. opakovani: %d\n", i + 1, vypocet);
    }

    return 0;
}


