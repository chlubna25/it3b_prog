#include <stdio.h>


int main() {
   
    char pozdrav[] = "Ahoj";
    
    printf("Kolikrat chces string opakovat? ");
    int opakovani;
    scanf("%d", &opakovani);
    
    if (opakovani <= 0) {
        printf("Zadal jsi spatnou hodnotu!!!");
        return 1; //chyba 
    }
    
    for (int i = 0; i < opakovani; i++){
    printf("Zadaný string: %s\n", pozdrav);
    }
    
    return 0;
}