#include <stdio.h>
int main() {
 
	int bakterie = 1;
 
	printf("Napis nasobici faktor X: ");
	float faktor;
	scanf_s("%f", &faktor);
 
	while (faktor < 0) {
		printf("Zadal jsi spatnou hodnotu!\n");
		printf("Napis nasobici faktor X:\n");
		scanf_s("%f", &faktor);
	}
 
	printf("Napis pocet noci:");
	int noc;
	scanf_s("%d", &noc);
 
	while (noc < 0) {
		printf("Zadal jsi spatnou hodnotu!\n");
		printf("Napis pocet noci:");
		scanf("%d", &noc);
	}
	int vypocet;
	for (int i = faktor; i == noc; i++) {
		vypocet = ((int)faktor * faktor);
	}
	printf("Pocet bakterii po %d je: %d", noc, vypocet);
 
 
	return 0;
}