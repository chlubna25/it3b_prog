#include <stdio.h>
int main() {

printf("Napis hmotnost telesa (kg):");
int hmotnost;
scanf_s("%d", &hmotnost);

if (hmotnost <= 0) {
printf("Nema smysl to pocitat :)");
return 1; //chyba
}

printf("Napis operaci kterou chces vykonat (g)gramy, (d)dekagramy, (t)tuny: ");
char znak;
scanf_s(" %c", &znak);

float gram = (float)hmotnost * 1000;
float dekagram = (float)hmotnost * 100;
float tuna = (float)hmotnost / 1000;

if (znak == 'g') {
printf("Hmotnost: %.2fg", gram);
}
else if (znak == 'd') {
printf("Hmotnost: %.2fdg", dekagram);
}
else if (znak == 't') {
printf("Hmotnost: %.2ft", tuna);
}
else {
printf("Chybne pismenko!!!");
return 1; //chyba
}


return 0;
}