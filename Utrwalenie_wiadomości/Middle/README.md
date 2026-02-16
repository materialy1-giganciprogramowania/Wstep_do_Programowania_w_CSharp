# C# Skill Check - poziom Middle

Poniższy zestaw zawiera 9 zadań o rosnącym poziomie trudności. Każde zadanie rozwija inne umiejętności programistyczne wykorzystywane przy tworzeniu gier.


**Zakres:** 
- zmienne i metody  
- listy, słowniki, stosy i kolejki  
- programowanie obiektowe  
- obsługa plików  
- wektory i struktury  
- przeciążanie operatorów  

**Legenda poziomów i nagradzanie:**
- <span style="color:GreenYellow"><b>🟢 ŁATWE — 1 pkt</b></span>
- <span style="color:DarkOrange"><b>🟠 ŚREDNIE — 2 pkt</b></span>
- <span style="color:OrangeRed"><b>🔴 TRUDNE — 3 pkt</b></span>
- <span style="color:Purple"><b>⭐ Każdy wykonany bonus to +1 pkt.</b></span>

---

## 💻 Zadanie 1 – Statystyki bohatera (max 2 pkt) 🟢

**Cel:** Nauka pracy ze zmiennymi i metodami.  
**Zagadnienia:** zmienne, metody, parametry, zwracanie wartości

**Wymagania:** Utwórz klasę bohatera z nazwą, HP, max HP i atakiem. Wypisz jego statystyki.
**⭐**  Dodaj metodę obliczającą procent życia.  

---

## 💻 Zadanie 2 – Lista ekwipunku (max 1 pkt) 🟢

**Cel:** Nauka pracy z List.  
**Zagadnienia:** List, foreach, Contains, Remove

**Wymagania:** Stwórz List<string> inventory. Obsłuż komendy: add nazwa, remove nazwa, show, exit wykorzystując metody klasy String.

---

## 💻 Zadanie 3 – Sklep (max 1 pkt) 🟢

**Cel:** Nauka pracy ze słownikiem.
**Zagadnienia:** Dictionary, klucz-wartość, iteracja

**Wymagania:** Stwórz sklep z przedmiotami i wagą. Użyj Dictionary<string,int>. Policz wagę ekwipunku.

---

## 💻 Zadanie 4 – Kolejka tur (max 3 pkt) 🟠 

**Cel:** Nauka działania kolejki.  
**Zagadnienia:** Queue, FIFO, metody, losowość

**Wymagania:** Użyj Stack<string> do zapisywania ruchów wykonanych przez gracza grze strategicznej. Dodaj komendę undo.
**⭐**  Dodaj metodę tasowania kolejki.  

---

## 💻 Zadanie 5 – Cofanie ruchów (max 2 pkt) 🟠 

**Cel:** Nauka działania stosu.  
**Zagadnienia:** Stack, LIFO, Push, Pop

**Wymagania:** Stwórz Queue<string> ze spisem jednostek w grze. Symuluj kolejkę tur w trakcie walki.

---

## 💻 Zadanie 6 – Budynki i polimorfizm (max 3 pkt) 🟠 

**Cel:** Nauka programowania obiektowego.  
**Zagadnienia:** OOP, dziedziczenie, abstract, override

**Wymagania:** Stwórz klasy związane z **budynkami do skonstruowania w grze strategicznej** i użyj polimorfizmu.

1) Stwórz klasę abstrakcyjną `Building` z polami: `Name` (string), `BuildCost` (int), `BuildTime` (int, w sekundach).

2) Stwórz co najmniej dwie klasy dziedziczące, np.: `Farm` (Farma) – produkuje mało, ale jest tania i buduje się szybko, `Mine` (Kopalnia) – produkuje dużo, ale jest droga i buduje się długo.

3) W `Main()` utwórz tablicę `Building[]` z różnymi budynkami i wypisz ich parametry oraz produkcję, wywołując metodę polimorficznie.

**⭐**  Utwórz abstrakcyjną metodę GetProductionPerMinute() (int), która zwraca ile zasobów budynek produkuje na minutę.

---

## 💻 Zadanie 7 – Generator lochów (max 3 pkt) 🔴 

**Cel:** Nauka pracy z plikami. 
**Zagadnienia:** File, zapis, odczyt, tablice 2D

**Wymagania:**  Stwórz generator mapy lochu do gry, która zostanie zapisana do pliku tekstowego. Program powinien pozwolić na wczytywanie i wyświetlanie map. Mapa powinna być wykonana ze znaków ASCII.

---

## 💻 Zadanie 8 – Wektory i pozycja (max 4 pkt) 🔴 

**Cel:** Nauka pracy ze strukturą Vector.  
**Zagadnienia:** struct, operatory, współrzędne

**Wymagania:** Poruszaj bohaterem i zapisuj pozycje budynków.  Stwórz `struct Vector2i` i użyj go do poruszania postaci.

1) Program powinien dysponować aktualnym wektorem pozycji bohatera: (x, y) (na starcie 0, 0) i pozwalać na jego poruszanie się wpisując komendy: w, a, s, d (ruch o 1 pole).

2) Po naciśnięciu przez użytkownika klawisza “b”, powinien powstać budynek na aktualnej pozycji bohatera.

3) Program powinien wpisywać aktualną pozycję bohatera, listę wszystkich postawionych budynków (pozycje)

**⭐**  Nie pozwól postawić budynku drugi raz na tej samej pozycji.

---

## 💻 Zadanie 9 – Przeciążanie operatorów (max 3 pkt) 🔴 

**Cel:** Nauka przeciążania operatorów.  
**Zagadnienia:** operator overloading, klasy, ToString

**Wymagania:** Stwórz klasę Kolor i przeciąż operatory + oraz *. 
1) Przygotuj klasę `Kolor()`, która zawierać będzie nazwę koloru (np. zielony, niebieski, czerwony) oraz metodę zamieniającą ostatnią literę z nazwy z “y” na “o” (np. zielony na zielono).

2) Stwórz przeciążenie operatora +, które pozwoli na łączenie kolorów ze sobą w formę z myslnikiem. Ostatnia litera odpowiednich słów powinna zostać zamieniona np. (zielony + niebieski = zielono-niebieski )

3) Stwórz przeciążenie operatora *, które pozwoli na zwielokrotnienie tego samego koloru odpowiednią liczbę razy. Ostatnia litera pierwszego słowa powinna zostać zamieniona ( np. zielony * 3 = zielono zielony zielony )

---