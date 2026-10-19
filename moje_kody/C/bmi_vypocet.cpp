#include <stdio.h>

int main() {
    printf("Napis svoji hmotnost (kg): ");
    float hmotnost;
    scanf("%f", &hmotnost);

    printf("Napis svoji vysku (m): ");
    float vyska;
    scanf("%f", &vyska);

    float bmi = hmotnost / (vyska * vyska);

    if (bmi > 40)
        printf("Obezita 3. stupne, BMI: %.2f", bmi);
    else if (bmi > 35)
        printf("Obezita 2. stupne, BMI: %.2f", bmi);
    else if (bmi > 30)
        printf("Obezita 1. stupne, BMI: %.2f", bmi);
    else if (bmi > 25)
        printf("Nadvaha, BMI: %.2f", bmi);
    else if (bmi > 18.5)
        printf("Normalni vaha, BMI: %.2f", bmi);
    else
        printf("Podvaha, BMI: %.2f", bmi);

    return 0;
}