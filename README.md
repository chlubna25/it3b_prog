💡 Tento repozitář slouží hlavně pro **školní projekty a trénink v jazyce C**.
=======

## 0. Před začátkem – založení účtu
1. Otevři [https://github.com](https://github.com).
2. Založ vlastní účet pomocí školního emailu.
   (pokud už účet máš, klidně pracuj ve svém)
   
## 1. Vytvoření vlastního repozitáře (fork)
Tento repozitář je nastavený jako *read-only*. Pro možnost úprav si budete muset vytvořit vlastní verzi repozitáře - tzv. *fork*.
1. Na stránce tohoto repozitáře klikni vpravo nahoře na tlačítko **Fork**.
2. Vytvoří se **kopie repozitáře** pod tvým účtem:
   https://github.com/*tvoje-jmeno*/it2b_prog

## 2. Klonování forku do VS Code (první použití)
1. Otevři **VS Code** a stáhní rozšíření **GitHub Pull Requests**.
2. Přihlas se svým účtem GitHubu.
3. Otevři paletu příkazů (**Ctrl+Shift+P**).
4. Zadej **Git: Clone**.
5. Vlož **URL svého forku** (ne originálu).
6. Vyber složku na disku.
7. Otevři naklonovaný repozitář ve VS Code.

## 3. Nastavení jména a e-mailu v Gitu (první použití)
Otevři terminál ve VS Code (**Ctrl+;**) a zadej:
```bash
git config --global user.name "Tvé jméno"
git config --global user.email "tvuj@email.cz"
```
Jméno odpovídá názvu tvého účtu.

## 4. Pullnutí z gitu
Pomocí pullnutí stáhneš změny v repozitáři z gitu do počítače.
1. Otevři repozitář ve VS Code.
2. Otevři terminál (Ctrl+;).
3. Stáhni nové změny:
```bash
git pull origin main
```

### 5. Nastavení učitelského repa jako *upstream*
Tímto nastavení můžeš stahovat změny z učitelského repozitáře do svého repozitáře
1. Zadej příkaz:
```bash
  git remote add upstream https://github.com/chlubna25/it2b_prog
```
2. Změny z učitelského repa lze stáhnout pomocí:
```bash
  git fetch upstream
  git pull --rebase upstream main
```

### 6. Nahrání změn na git
1. Po každé větší změně je vhodné vytvořit *commit*:
```bash
  git add .
  git commit -m "Krátký název změny (např. Přidal funkci na výpočet průměru)"
```
2. Na konci hodiny nahraj změny na git pomoccí *push*:
```bash
  git push origin main
```
3. Stav repozitáře lze zkontrolovat pomocí:
```bash
  git status
```

## Shrnutí „rituál každé hodiny“
1. **Na začátku**
   - `git pull origin main` (pro změny z tvého forku, např. z jiného PC)
   -  Případně stažení změn učitelského repa:
   -   `git fetch upstream` + `git pull --rebase upstream main`
2. **Během práce**
   - `git add .`  
   - `git commit -m "Krátký popis změny"`  

3. **Na konci**
   - `git push origin main` (ujisti se, že je vše na GitHubu)  
   - `git status` (zkontroluj stav repozitáře)
  
 
---

 ## Verze pro Visual Studio 2019
 Tento návod funguje, jen pokud v rámci repa vytvoříte VS 2019 projekt.
1. **Přihlášení**
   - v aplikaci Visual Studio přejdi na *Soubor* a *Nastavení účtů...*
   - přihlaš se na GitHub
2. **Na začátku hodiny**
   - najeď na stránku svého repozitáře (např. https://github.com/*jmeno*/it2b_prog/)
      - pokud se zobrazuje tlačítko *Sync fork*, načti změny od učitelského repozitáře
   - ve VS přejdi na *git* -> *klonovat úložiště* a vyber svůj repozitář
      - případně pullni změny 
   - v rámci *zobrazení* vyber *Team explorer*
3. **Během práce**
   - v *Team explorer* přidávej změny v souborech
   - pomocí *Potvrdit připravené* commitni novou verzi
   - pomocí šipky nahoru (*push*) nahraj změny do repozitáře na cloudu

---
>>>>>>> 0890156a7d6d336930ad350a6b65183aaac211c1
