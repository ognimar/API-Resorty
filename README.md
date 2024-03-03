# API Resorty

## GitHub Actions Workflow

Ten projekt zawiera skonfigurowany workflow dla GitHub Actions, który automatyzuje proces CI/CD.

### Krok 1: Ustawienie zmiennych środowiskowych

Upewnij się, że masz ustawione odpowiednie zmienne środowiskowe w ustawieniach repozytorium na GitHub:
- `publish-profile`: Plik XML zawierający konfigurację procesu publikacji aplikacji internetowej. Pobieramy z app services.
- `package`: Jest to aktualna ścieżka naszego repozytorium. 
- `app-name`: Nazwa naszej aplikacji

### Krok 2: Konfiguracja workflow

W pliku `.github/workflows/master_apiresorty.yml` znajdziesz konfigurację workflow dla GitHub Actions. Plik ten zawiera etapy budowania aplikacji oraz automatycznego wdrożenia do środowiska.

### Krok 3: Dostosowanie konfiguracji

Przed uruchomieniem workflow, upewnij się, że odpowiednio dostosowałeś sekcję `deploy` w pliku konfiguracyjnym do Twoich potrzeb. Możesz zmienić ścieżkę docelową oraz inne parametry wdrożenia.

### Krok 4: Uruchomienie procesu CI/CD

Po wprowadzeniu zmian i przesłaniu ich na gałąź główną, workflow automatycznie się uruchomi, budując aplikację i wdrażając ją do wybranego środowiska.
