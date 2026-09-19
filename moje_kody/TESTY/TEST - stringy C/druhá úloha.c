#include <stdio.h>
#include <string.h>

int main() {
    char slovo[201];

    printf("Zadej slovo: "); //vstup
    scanf("%200s", slovo);

    for (int i = 0; slovo[i] != '\0'; i++) {
        if (slovo[i] >= 'A' && slovo[i] <= 'Z') {
            slovo[i] = slovo[i] + ('a' - 'A'); 
        }
    }

    printf("Vystup: %s\n", slovo); //vystup

    return 0;
}