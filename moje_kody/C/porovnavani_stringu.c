#include <stdio.h>
#include <string.h>

int main() {

    char string1[40], string2[40];

    printf("zadej prvni slovo: ");
    scanf(" %39s", string1);

    printf("zadej druhe slovo: ");
    scanf(" %39s", string2);

   
    if (strlen(string1) != strlen(string2)) {
        printf("Slova nejsou stejna\n");
        return 0;  
    } 
    
   
    for (int i = 0; i < strlen(string1); i++) {
        if (string1[i] != string2[i]) {
            printf("Slova nejsou stejna!!!\n");
            return 0;  
        }
    }

  
    printf("Slova jsou stejna!!!!\n");

    return 0;
}
