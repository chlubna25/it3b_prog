#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {

	srand(time(NULL));
	int vysledek = rand() % 6 + 1;
	printf("Tvoje hodnota je: %d", vysledek);

	return 0;
}