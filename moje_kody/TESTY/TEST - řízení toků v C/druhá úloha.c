#include <stdio.h>
int main() {
 
	int e = 50; //km/den
	int x = 150;  //km/den
	int p = 500; //km/den
	char doprava;
	int pocetdnu;
 
	printf("Napis delku trasy v KM:");
	int delka;
	scanf("%d", &delka);
 
	while (doprava < 0) { //overeni
		printf("Zadal jsi spatnou odpoved!!");
		printf("Napis delku trasy:");
		scanf("%d", &delka);
	}
 
	printf("Napis typ dopravy: (ekonomicka = 'e' , expresni 'x' , prioritni 'p' )");
	scanf(" %c", &doprava);
 
	while (doprava == e && x && p) { //overeni 
		printf("Zadal jsi neznamy typ dopravy!!");
		printf("Napis typ dopravy: (ekonomicka, expresni, prioritni)");
		scanf(" %c", &doprava);
	}
 
	switch (doprava) {
	case 'e':
		pocetdnu = delka % e;
		break;
	case 'x':
		pocetdnu = delka % x;
		break;
	case 'p':
		pocetdnu = delka % p;
		break;
 
	}
 
	for (int i = 0; i < pocetdnu; i++) {
		printf("Balik urazil %d za %d", delka, pocetdnu);
	}
 
	return 0;
}