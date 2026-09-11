#include <stdio.h>

int faktorial(int n) {
    if (n <= 1) {
        return 1;
    }
    else {
        return n * faktorial(n - 1);
    }
}

int main(){
    
    int cislo;
    
    printf("Zadej cislo pro vypocet faktorialu: ");
    scanf("%d", &cislo);
    
    printf("Faktorial cisla %d je %d.", cislo, faktorial(cislo));
    
    return 0;
}