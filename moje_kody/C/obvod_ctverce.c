#include <stdio.h>

int obvod_ctverce(int strana) {
    return 4 * strana;
}

int main() {
    int strana;
    printf("Zadej delku strany ctverce: ");
    scanf("%d", &strana);

    int obvod = obvod_ctverce(strana);
    printf("Obvod ctverce se stranou %d je: %d\n", strana, obvod);

    return 0;
}
