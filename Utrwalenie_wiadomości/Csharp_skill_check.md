# C# Skill Check - poziom Junior

Zestaw krótkich projektów mających za zadanie utrwalić zdobytą wiedzę.

**Zakres:** podstawy języka C#, konsola, logika, pętle, tablice, debugowanie, AI jako wsparcie.

**Legenda poziomów i nagradzanie:**
- <span style="color:GreenYellow"><b>🟢 ŁATWE — 1 pkt</b></span>
- <span style="color:DarkOrange"><b>🟠 ŚREDNIE — 2 pkt</b></span>
- <span style="color:OrangeRed"><b>🔴 TRUDNE — 3 pkt</b></span>
- <span style="color:Purple"><b>⭐ Każdy wykonany bonus to +1 pkt.</b></span>

## 1. Hello Console — rozmowa z komputerem <span style="font-size:0.7em; font-weight:100; color:GreenYellow"><b>🟢 max 1 pkt</b></span>
**Zagadnienia:** Console.WriteLine, ReadLine, Main, konkatenacja  
**Opis:** Stwórz program, który zapyta o imię oraz wiek, a następnie wypisze krótkie podsumowanie.  
**⭐** Policz liczbę znaków imienia.

---

## 2. Kalkulator dwóch liczb <span style="font-size:0.7em; font-weight:100; color:GreenYellow"><b>🟢 max 1 pkt</b></span>
**Zagadnienia:** parsowanie, operacje matematyczne, Error List  
**Opis:** Pobierz od użytkownika dwie liczby, a następnie oblicz ich sumę, różnicę, iloczyn i iloraz.  
**⭐** Sprawdź co się stanie przy dzieleniu przez zero i zabezpiecz program przed tym.

---

## 3. Czy to prawda? — Paintball 16+ <span style="font-size:0.7em; font-weight:100; color:GreenYellow"><b>🟢 max 1 pkt</b></span>
**Zagadnienia:** operatory logiczne, bool  
**Opis:** Napisz program, który oceni na podstawie wieku osoby lub przebywania z opiekunem, czy może wejść do klubu Paintball 16+.  
**⭐** Zrób wersję z dwoma warunkami naraz (np. „musi mieć 16+ i zgodę opiekuna” — test &&).

---

## 4. Czujnik temperatury <span style="font-size:0.7em; font-weight:100; color:GreenYellow"><b>🟢 max 1 pkt</b></span>
**Zagadnienia:** if / else if / else  
**Opis:** Napisz program interpretujący temperaturę podaną w stopniach i wyświetlający komunikat pogodowy: jak jest na zewnątrz i jak się ubrać.  
**⭐** Dodaj ostrzeżenie dla ekstremalnych wartości.

---

## 5. Generator hasła <span style="font-size:0.7em; font-weight:100; color:DarkOrange"><b>🟠 max 2 pkt</b></span>
**Zagadnienia:** Random, pętle, string.Length  
**Opis:** Stwórz program, który wygeneruje losowe hasło o zadanej długości.  
**⭐** Hasło musi zawierać cyfrę.

---

## 6. Zgadnij liczbę <span style="font-size:0.7em; font-weight:100; color:DarkOrange"><b>🟠 max 2 pkt</b></span>
**Zagadnienia:** while, Random  
**Opis:** Zaprogramuj mini grę, w której celem gracza jest odgadnięcie liczby wylosowanej przez komputer. Komputer powinien podpowiadać „Za mało” / „Za dużo”.  
**⭐** Wprowadź limit prób.

---

## 7. Detektor słów <span style="font-size:0.7em; font-weight:100; color:GreenYellow"><b>🟢 max 1 pkt</b></span>
**Zagadnienia:** string.Contains, ToLower, string.Length  
**Opis:** Napisz program wyszukujący we wprowadzonym zdaniu wskazane słowa (np. „kot”, „pies”, „AI”), zwracający prawdę lub fałsz.  
**⭐** Sprawdź długość zdania i wypisz informację „krótkie / długie”.

---

## 8. GitHub — SecretMessageChallenge <span style="font-size:0.7em; font-weight:100; color:GreenYellow"><b>🟢 max 1 pkt</b></span>
**Zagadnienia:** praca z repozytorium w przeglądarce (podgląd plików i historii)  
**Opis:** Zajrzyj do folderu SecretMessageChallenge i podążaj za wskazówkami, aby znaleźć ukrytą wiadomość.  
**⭐** Znajdź niekonsekwencję w tworzeniu commitów.

---

## 9. Menu gry <span style="font-size:0.7em; font-weight:100; color:DarkOrange"><b>🟠 max 2 pkt</b></span>
**Zagadnienia:** while, switch, praca na string, interakcja w konsoli  
**Opis:** Stwórz w konsoli symulator menu gry z kilkoma opcjami do wyboru. Po wybraniu opcji program powinien wrócić do menu. Musi istnieć możliwość wyjścia z programu.  
**⭐ 1:** Dodaj licznik, ile razy wybrano „Graj”.  
**⭐ 2:** Zapytaj o nick gracza na starcie programu i wyświetl losowy komunikat zawierający nick przy starcie gry.

---

## 10. Tryby gry <span style="font-size:0.7em; font-weight:100; color:DarkOrange"><b>🟠 max 2 pkt</b></span>
**Zagadnienia:** enum, rzutowanie, zabezpieczenie wejścia  
**Opis:** Stwórz program zawierający zdefiniowane odgórnie poziomy trudności gry, a następnie pozwól użytkownikowi dokonać wyboru z listy dostępnych.  
**⭐** Zabezpiecz program przed wybraniem nieistniejącego poziomu (ustaw domyślny).

---

## 11. Precyzja zmiennych liczbowych <span style="font-size:0.7em; font-weight:100; color:GreenYellow"><b>🟢 max 1 pkt</b></span>
**Zagadnienia:** float, double, decimal  
**Opis:** Zweryfikuj dokładność obliczeń liczb zmiennoprzecinkowych dla operacji dodawania. Porównaj typy: float, double, decimal.  
**⭐** Dodaj Math.Round(...) i porównaj wyniki po zaokrągleniu.

---

## 12. Kalkulator naukowy <span style="font-size:0.7em; font-weight:100; color:DarkOrange"><b>🟠 max 2 pkt</b></span>
**Zagadnienia:** biblioteka Math, warunki ochronne (if)  
**Opis:** Stwórz program, który pobierze dwie liczby zmiennoprzecinkowe od użytkownika, a następnie wykona: potęgowanie w obie strony, pierwiastkowanie obu liczb, zwrócenie wartości większej i mniejszej.  
**⭐** Oblicz pola: kwadratu, prostokąta, trójkąta i koła — podstawiając raz jedną, raz drugą liczbę lub obie w innej konfiguracji.

---

## 13. Elektroniczny dziennik ocen <span style="font-size:0.7em; font-weight:100; color:DarkOrange"><b>🟠 max 2 pkt</b></span>
**Zagadnienia:** tablice, for, proste statystyki  
**Opis:** Pobierz do tablicy oceny użytkownika z danego przedmiotu, a następnie policz ich średnią i wypisz najwyższą ocenę.  
**⭐** Sprawdź czy uczeń kwalifikuje się na stypendium: średnia ≥ 4.5 i przynajmniej jedna ocena 6.

---

## 14. Debugowanie — polowanie na błąd <span style="font-size:0.7em; font-weight:100; color:OrangeRed"><b>🔴 max 3 pkt</b></span>
**Zagadnienia:** breakpointy, Error List, analiza przyczyn błędów  
**Opis:** Przeanalizuj niedziałający kod, zlokalizuj błędy i napraw je.  
**⭐** Sprawdź, co się stanie dla n = 0 i zabezpiecz program przed dzieleniem przez zero.

---
