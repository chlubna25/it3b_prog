#include <stdio.h>

int main() {

printf("Napis tepovou frekvenci:(tepy/min):");
int tep;
scanf_s("%d",&tep);

printf("Napis objem krve vypuzeny s kazdym tepem: (v ml.)");
int objem;
scanf_s("%d", &objem);

float srdecnivydej = (float(tep * objem)) / 1000;
printf("Tvuj srdecni vydej je: %.2f", srdecnivydej);



return 0;