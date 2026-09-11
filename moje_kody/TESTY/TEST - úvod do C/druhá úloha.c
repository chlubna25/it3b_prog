#include <stdio.h>

int main() {

printf("Napis hmotnost nadrze (kg)");
int hmotnost;
scanf_s("%d", &hmotnost);

printf("Napis objem vnitrku nadrze (m3)");
int objem;
scanf_s("%d", &objem);

printf("Napis objem vody uvnitr");
int objemvoda;
scanf_s("%d", &objemvoda);

int pvoda = 1000;
float pvzduch = 1.225;

int hmotnostvody = objemvoda * pvoda;
float hmotnostvzduchu = (float)pvzduch *(objem - objemvoda);
float celkovam = (float)hmotnost + hmotnostvody + hmotnostvzduchu;

printf("Hmotnost vody v nadrzi je: %d", hmotnostvody);
printf("Hmotnost vzduchu uvnitr nadrze je: %f", hmotnostvzduchu);
printf("Celkova hmotnost je: %.2f", celkovam);


return 0;

}