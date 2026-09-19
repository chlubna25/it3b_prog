#include <stdio.h>
void trojuhelnik(int vyska){
    for(int i = 1; i < vyska; i++) {
        for(int j = 0; j < i; j++){
            printf("#");
        }
        printf("\n");
    }
}

void stojan(int vyska){
    for(int i = 0; i < vyska; i++){
        printf("#\n");
    }
}

void stromecek(int pocet_pater, int vyska){
    printf("\n");
    for(int i = 0; i < pocet_pater; i++){
        trojuhelnik(vyska);
    }
    stojan(vyska);
    
}

int main(){
    stromecek (3, 5);
    return 0;
}