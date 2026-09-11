#include <stdio.h>
int main() {

printf("Napis soucasny rok:");
int rok;
scanf_s("%d", &rok);

printf("Zadej rok svatby:");
int svatba;
scanf_s("%d", &svatba);

if (rok < svatba) {
printf("Chybne udaje!!");
return 1;
}

int spolrok = rok - svatba;

if (spolrok >= 50) {
printf("Zlate\n");
printf("Jste spolu: %d\n", spolrok);
}
else if (spolrok >= 40) {
printf("Rubinove\n");
printf("Jste spolu: %d\n", spolrok);
}
else if (spolrok >= 25) {
printf("Stribrne\n");
printf("Jste spolu: %d\n", spolrok);
}
else if (spolrok >= 10) {
printf("Cinove\n");
printf("Jste spolu: %d\n", spolrok);
}
else if (spolrok >= 5) {
printf("Drevene\n");
printf("Jste spolu: %d\n", spolrok);
}
else {
printf("Nemate spolu vyroci :(\n");
}
return 0;
}