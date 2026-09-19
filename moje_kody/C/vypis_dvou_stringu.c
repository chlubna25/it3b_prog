#include <stdio.h>


int main() {

    char string1[40], string2[40];

    printf("zadej prvni slovo: ");
    scanf(" %39s", string1);

    printf("zadej druhe slovo: ");
    scanf(" %39s", string2);

    printf("%s\n", string1);
    printf("%s\n", string2);

    return 0;
}