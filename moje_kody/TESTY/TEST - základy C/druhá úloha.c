#include <stdio.h>
int main() {

printf("Napis prvni znamku:");
int znamka1;
scanf_s("%d", &znamka1);

if (znamka1 <= 0) {
printf("Chybny udaj!!!");
return 1; //chyba
}
if (znamka1 > 5) {
printf("Chybny udaj!!!");
return 1; //chyba
}

printf("Napis druhou znamku:");
int znamka2;
scanf_s("%d", &znamka2);

if (znamka2 <= 0) {
printf("Chybny udaj!!!");
return 1; //chyba
}
if (znamka2 > 5) {
printf("Chybny udaj!!!");
return 1; //chyba
}

printf("Napis treti znamku:");
int znamka3;
scanf_s("%d", &znamka3);

if (znamka3 <= 0) {
printf("Chybny udaj!!!");
return 1; //chyba
}
if (znamka3 > 5) {
printf("Chybny udaj!!!");
return 1; //chyba
}

int soucet = znamka1 + znamka2 + znamka3;
float prumer = (float)soucet / 3;

if (prumer > 4.2) {
printf("Neprosel!\n");
printf("Vas prumer: %.2f", prumer);
}
else if (prumer >= 2.5) {
printf("Prosel!\n");
printf("Vas prumer: %.2f", prumer);
}
else {
printf("Prosel vyborne!\n");
printf("Vas prumer: %.2f", prumer);
}

return 0;
}