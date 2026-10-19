#include <stdio.h>

int main() {
    float metry;
    printf("Zadej pocet metru: ");
    scanf("%f", &metry);

    if (metry <= 0) {
        printf("Chybny udaj");
        return 1;
    }

    char jednotka;
    printf("Zvol jednotku (c - cm, d - dm, k - km): ");
    scanf(" %c", &jednotka);

    if (jednotka == 'c')
        printf("%.2f m = %.2f cm\n", metry, metry * 100);
    else if (jednotka == 'd')
        printf("%.2f m = %.2f dm\n", metry, metry * 10);
    else if (jednotka == 'k')
        printf("%.2f m = %.4f km\n", metry, metry / 1000);
    else
        printf("Neznama jednotka!");

    return 0;
}