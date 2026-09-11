#include <stdio.h>

int main() {
    printf("Zadej svuj vek:");
    int vek;
    scanf("%d", &vek);

    if (vek < 18) {
        printf("Nejste jeste dospely");
    } else {
        printf("Gratuluji, jste dospely");
    }

    return 0;
}