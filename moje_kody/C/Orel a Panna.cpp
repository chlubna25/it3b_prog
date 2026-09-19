#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
  
    srand(time(NULL));
    int hod = rand() % 2;

    if (hod == 0) {
        printf("Panna\n");
    }
    else {
        printf("Orel\n");
    }

    return 0;
}

