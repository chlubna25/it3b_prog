#include <stdio.h>

int soucetDelitelu(int cislo) {  // prvni funkce
    int soucet = 0;

    for(int delitel = 1; delitel <= cislo; delitel++) {
        if (cislo % delitel == 0) {
            soucet = soucet + delitel;
        }
    }

    return soucet;
}

int dokonale(int cislo) { // druha funkce

    int soucet = soucetDelitelu(cislo);

    if(soucet == 2 * cislo) {
        return 1;
    } else {
        return 0;
    }
}

int main() { //overeni v mainu podle ukazky

    printf("%d\n", soucetDelitelu(12));
    printf("%d", dokonale(28));
    
    return 0;
}