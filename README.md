# SymulatorProgramisty
Program Symulator Programisty jest prostą grą wykonaną w API Windows Forms.
Gra składa się z trzech okienek
* FormMain - menu główne z przyciskami pozwalającymi na nawigowanie po grze
* FormManual - zestaw instrukcji wyjaśniających mechanikę gry
* FormGame - okno odpowiedzialne za rozgrywkę

## Rozgrywka:
Rozgrywka polega na przetrwaniu jak najdłużej i zdobyciu jak największej ilości punktów oraz poziomu. Trzon rozgrywki opiera się o zdobywanie zasobów takich jak energia, połączenia telefoniczne oraz jedzenie. "Surowce" możemy zdobywać dzięki rozwiązywaniu prostych zadań matematycznych wyświetlonych na monitorze albo poprzez szybkie zareagowanie na pojawiające się zdarzenia takie jak:
* Dzwoniący telefon (należy nacisnąć pomarańczowy przycisk na telefonie)
* Hamburger (należy nacisnąć na ikonę hamburgera pojawiającego się z prawej strony ekranu)
* Kawa (należy kliknąć w żółty piorun pojawiający się na kubku kawy)
Wszystkie zdarzenia trwają tylko przez określoną ilość czasu. 
Gra kończy się w momencie gdy skończy się któryś z zasobów lub gdy skończy się czas wyświetlany na monitorze (za prawidłowe rozwiązanie działania uzyskuje się dodatkowe 5 sek., a za złe rozwiązanie traci się 5 sek.). Dodatkowym elementem rozgrywki jest zwiększający się poziom trudności wraz z rozwiązywaniem kolejnych działań. Wyższy poziom zapewnia pewne ułatwienie polegające na wydłużającym się czasie na rozwiązanie działań matematycznych.

## Punktacja:
* Poprawne rozwiązanie działania mat.: 5pkt do wyniku, 2pkt do każdego z zasobów
* Reakcja na eventy: 1pkt do wyniku, 10pkt do poszczególnych surowców

## Screeny z rozgrywki
![alt text](https://i.imgur.com/feYMWKZ.png "Main Menu")
![alt text](https://i.imgur.com/MjQ4sKz.png "Manual")
![alt text](https://i.imgur.com/8yEws1B.png "Gameplay")
