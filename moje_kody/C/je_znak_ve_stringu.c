#include <stdio.h>
int main() {

	char str[] = "Ahoj";

	char znak;
	printf("Zadej mi znak:\n ");
	scanf(" %c", &znak);

	int i = 0;
	while (str[i] != '\0') {
		if (str[i] == znak) {
			printf("Znak %c JE ve stringu %s\n", znak, str);
		}
		else {
			printf("Znak %c NENI ve stringu %s\n", znak, str);
		}
		i++;
	}


	return 0;
}