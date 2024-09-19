#include <iostream>
using namespace std;


/*
    Nazwa klasy:            car
    Zmienne klasy:          int id - id samochodu
                            int pojemnosc - pojemnosc samochodu
                            string nazwa - nazwa samochodu
    Metody:                 brak
    Informacje:             Klasa car opisuje podstawowe informacje
                            o samochodach: ich ID, pojemnosc oraz nazwę
    Autor:                  10520310201
*/

class car {
    public int id;
    public int pojemnosc;
    public string nazwa;
}


/*
    Nazwa funkcji:          pojemnoscZNazwy
    Parametry wejściowe:    string nazwa - nazwa samochodu
    Zwracana wartość:       int pojemnosc - pojemnosc samochodu
    Informacje:             Funkcja pojemnoscZNazwy zwraca pojemnosc samochodu
                            zaleznie od podanej nazwy
    Autor:                  10520310201
*/

int pojemnoscZNazwy(string nazwa) {
    int pojemnosc;

    switch (nazwa) {
    case audi:
        pojemnosc = 3000;
        break;
    case skoda:
        pojemnosc = 3500;
        break;
    default:
        pojemnosc = 0;
    }

    return pojemnosc;
}

int main()
{
    cout << "Hello World!\n";
}