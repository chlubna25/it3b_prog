#include <stdio.h>
#include <string.h>

int main() {

    char str[100]; 

    printf("Zadejte řetězec: ");
    scanf("%s", str);  

    int delka = strlen(str); 
    int palindrom = 1;  

    for (int i = 0; i < delka / 2; i++) {
        if (str[i] != str[delka - i - 1]) {
            palindrom = 0; 
            break;
        }
    }
    
    if (palindrom) {
        printf("retezec je palindrom!!!!!");
    }
    else{
      printf("retezec neni palindromem!!!!!");  
    }

    return 0;
}
