#include <stdio.h>
#include <string.h>

int main() {

    char str[] = "Skibidi Toilet";  // Předdefinovaný řetězec
    char c; 
  
    printf("Zadejte znak pro hledání: ");
    scanf(" %c", &c);  

    if (strchr(str, c)) {
        printf("Znak '%c' se nachází v řetězci.\n", c);
    }
    else {
        printf("Znak '%c' se nenachází v řetězci.\n", c);
    }

    return 0;
}
