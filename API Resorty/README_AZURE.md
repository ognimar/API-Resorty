# Instrukcje dotyczące wdrożenia aplikacji w usłudze Azure
- `Krok 1`: Otwórz przeglądarkę internetową i przejdź do adresu: https://apiresorty.azurewebsites.net/swagger <br>
- `Krok 2`: Po otworzeniu linku będziesz mógł/mogła korzystać z funkcjonalności aplikacji.

## Funkcję dostępne na stronie:

- `Funkcja 1 GET`: Służy do pobierania informacji z bazy danych<br>
- `Funkcja 2 POST`: Służy do wprowadzania informacji do bazy danych<br>
- `Funkcja 3 PUT`: Służy do modyfikowania informacji z bazy danych<br>
- `Funkcja 4 DELETE`: Służy do usuwania informacji z bazy danych

## Jak poprawnie korzystać z dostępnych funkcji:

- `Funkcja GET`: Wybieramy opcję GET, następnie opcję `Try IT Out` i na końcu `Execute`. Poniżej wyświetlają nam się rekordy z bazy danych
- `Funkcja POST`: Wybieramy opcję POST, następnie opcję `Try IT Out`, teraz wpisujemy nasze dane. Podczas wpisywania musimy zwrócić uwagę na odpowiedni typ danych.
  `ID` zostawiamy tak jak jest czyli na 0, `name` powinno być tekstem, tak samo jak `description`. `Price` jest float'em, czyli może zostać tam wprowadzona liczba
  zmienno przecinkowa, natomiast `rating` jest zwykły numerem.
- `Funkcja PUT`: Wybieramy opcję PUT, następnie opcję `Try IT Out`. Teraz możemy przejść do edytowania naszych wartości, W ID wpisujemy `ID rekordu`,
   który chcemy zedytować, a resztę wartości możemy edytować dowolnie według zasada wymienionych w punkcie wyżej.
- `Funkcja DELETE`: Wybieramy opcję DELETE, następnie opcję `Try IT Out`. W polu ID, które nam się wyświetli wpisujemy `ID rekordu`, którego chcemy usunąć.

## Wdrożenie aplikacji z lokalnego repozytorium do Azure: 
- `Krok 1`: Klikamy prawym na nazwę naszego repozytorium, w ekploatorze plików (w visual studio).
- `Krok 2`: Następnie wybieramy opcję opublikuj
- `Krok 3`: Teraz wybieramy odpowiedni app-service i klikamy opublikuj
