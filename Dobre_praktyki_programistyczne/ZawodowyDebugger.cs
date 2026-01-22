int liczba1, liczba2;
string operacja;
int wynik;
// Pobieranie pierwszej liczby
Console.WriteLine("Podaj pierwszą liczbę:");
liczba1 = int.Parse(Console.ReadLine());
// Pobieranie operacji
Console.WriteLine("Podaj operację (+, -, *, /):");
operacja = int.Parse(Console.ReadLine()).ToString();
// Pobieranie drugiej liczby
Console.WriteLine("Podaj drugą liczbę:");
liczba2 = int.Parse(Console.ReadLine());
// Wykonywanie operacji
switch (operacja)
{
	case "+":
		wynik = liczba1 + liczba2;
		break;
	case "-":
		wynik = liczba1 - liczba2;
		break;
	case "*":
		wynik = liczba1 * liczba2;
		break;
	case ":":
		wynik = liczba1 / liczba2;
		break;
	default:
		Console.WriteLine("Nieprawidłowa operacja");
		return;
}
// Wyświetlanie wyniku
Console.WriteLine("Wynik: " + wynik);