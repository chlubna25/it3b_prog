#include <stdio.h>
#include <string.h>

int main() {
    char str[] = "abeceda";
    
    char podretezec[100];
    printf("Zadej mi podretezec: ");
    scanf("%s", podretezec);
    
    int pocet_vyskytu = 0;
    char *ptr = str;
    while ((ptr = strstr(ptr, podretezec)) != NULL) {
        pocet_vyskytu++;
        ptr += strlen(podretezec); // move past the found substring
    }
    
    if (pocet_vyskytu > 0) {
        printf("Podretezec '%s' JE ve stringu '%s'\n", podretezec, str);
        printf("  Podretezec je ve strinu %d-krat\n", pocet_vyskytu);
    } else {
        printf("Podretezec '%s' NENI ve stringu '%s'\n", podretezec, str);
    }
    
    return 0;
}