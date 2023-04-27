Skriv ett program som kan skapa ordrar med orderrader och artiklar.
Skapa sedan sökfunktion där användaren väljer en artikel och får ut en 
lista på alla orderrader där artikeln ingår.

*En order innehåller ett kundnamn och minst en orderrad.

*En orderrad innehåller ett radnummer, ett antal(av artikel/lar) och 
pekar på en artikel. Den tillhör alltid en order.

*En artikel innehåller ett artikelnummer, ett artikelnamn och ett styckpris.
En artikel kan finnas på flera orderrader, men måste inte finnas på någon. 
En orderrad har alltid en artikel, och kan inte ha fler än en.

Skapandet av ordrar, orderrader och artiklar kan göras med UI där användaren matar in data.

Sökfunktionen ska ha ett användargränssnitt där
användaren på något sätt anger en artikel.
Resultatet ska visa en lista på de orderrader som artikeln finns i och bör där visa:
* Ordernummer
* Kundnamn
* Orderrad
* styckpris
* Antal
* Summa

* Antal rader hittade
* Summan av ordervärdet för dessa orderrader.