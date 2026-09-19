#include <stdio.h>

int main() {

printf("Zadej prvni znak:");
char znak1;
scanf_s(" %c", &znak1);

printf("Zadej druhy znak:");
char znak2;
scanf_s(" %c", &znak2);

printf("\n    %c  ", znak2);
printf("\n    %c  ", znak2);
printf("\n%c %c %c %c %c", znak2, znak2, znak1, znak2, znak2);
printf("\n    %c  ", znak2);
printf("\n    %c  ", znak2);

return 0;

}