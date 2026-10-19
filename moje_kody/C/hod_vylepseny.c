#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {

	printf("Zadej pocet kostek: ");
	int pocet;
	scanf("%d", &pocet);

	if (pocet <= 0) {
		printf("Zadal jsi spatnou hodnotu!!! ");
		return 1; 
	}

	int vysledek;

	for (int i = 0; i < pocet; i++) {
		srand(time(NULL));
		vysledek = rand() % 6 + 1;
		scanf("%d", &vysledek);
	}
	
	printf("%d", vysledek);
	

	return 0;
}