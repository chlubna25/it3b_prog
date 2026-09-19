#include <stdio.h>
int main() {
 
	int cislo;
	int pocet = 0;
 
	for (int i = 0; i < 10; i++) {
		printf("Zadej cele cislo:");
		scanf_s("%d", &cislo);
 
		while (cislo < 0) {
			printf("Zadal jsi spatnou hodnotu\n");
			printf("Zadej cele cislo:\n");
			scanf_s("%d", &cislo);
		}
 
		if (cislo % 2 == 0) {
			pocet++;
		}
	}
	printf("Pocet sudych cisel je %d\n", pocet);
 
	return 0;
}