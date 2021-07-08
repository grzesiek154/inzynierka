Aplikacja jest stworzona w narzędziu IntelliJ IDEA 2020.3 (Ultimate Edition) oraz Microsoft Visual Studio Code v1.57.1. Do napisania warstwy aplikacji odpowiedzialnej za komunikację z bazą danych użyto Spring Boot v2.3.4, natomiast do napisania części wizualnej interfejsu użytkownika użyto Angular CLI v10.2.0
System był implementowany na komputerze Dell Latitude 5591, który ma procesor Intel Core i7-8850H (2.60GHz), 16GB pamięci RAM, posiada dysk SSD 512. Na komputerze zainstalowany jest Windows 10 Enterprise.

Instalacja MySQL Workbench 8.0 Community
•	Na początku należy zainstalować program MySQL Workbench 8.0 Community
•	Oprogramowanie trzeba pobrać ze strony producenta:
	https://dev.mysql.com/downloads/workbench
•	Należy uruchomić poprany w poprzednim kroku instalator który będzie w języku angielskim
•	Po uruchomieniu pliku instalacyjnego? klikamy dwa razy opcje „Next” aż dojdziemy to okienka w którym pojawi się komunikat „Please 	select a setup type”. Jeżeli chcemy aby instalacja odbyła się w domyślnej ścieżce czyli „C:\Program Files\MySQL\MySQL Workbench 8.0 	CE”  wybieramy ponownie przycisk „Next” a następnie „Install”, w przeciwnym razie wybieramy opcje „Custom” dostosowujemy instalację 	pod własne wymagania.
•	Po otworzeniu pobranego oprogramowania tworzymy użytkownika: login: root hasło: admin
•	W sekcji „Schemas” klikamy prawy przyciskiem myszy i wybieramy opcję „create schema” i tworzymy nowy schemat bazy danych o nazwie 	„trainings_notebooks_v2”. 
•	Nie ma potrzeby tworzenia tabel na poziomie bazy danych, tabele, relację pomiędzy nimi oraz dane testowe zostaną utworzone na 	podstawie encji w 	warstwie biznesowej aplikacji.

Instalacja i konfiguracja Intellij
	Instalacja oraz konfiguracja Intellij  Ulitmate edition, warstwy aplikacji odpowiedzialnej za komunikację z bazą danych.
•	Przed rozpoczęciem instalacji należy upewnić się ze Java w wersji co najmniej  11 jest zainstalowana na komputerze
•	Oprogramowanie należy pobrać ze strony: 
	https://www.jetbrains.com/idea/download/#section=windows
•	Aby używać Intellij w wersji Ulitimate należy zarejestrować się na stronie 
	Następnie utworzyć konto w celu darmowego korzystania z aplikacji przez 30 dni
	https://account.jetbrains.com/login
•	W celu importu projektu z górnego menu wybieramy opcję:
•	File > New > Project From Existing Source
•	Następnie z katalogu wybieramy folder „TrainingsNotebookBackend” będąc w tym folderze zaznaczamy katalog „backend” i klikamy OK.
•	Przed uruchomieniem aplikacji należy włączyć procesowanie adnotacji, w tym celu z poniższej ścieżki należy zaznaczyć pole wyboru 	„Enable annotation processing”
	 File | Settings | Build, Execution, Deployment | Compiler | Annotation Processors
•	Przed uruchomieniem aplikacji należy z prawego bocznego panelu wybrać zakładkę „Maven” a następnie opcję „Refresh Maven”
•	W celu uruchomienia aplikacji , upewniamy się że wybrana jest konfiguracja „TrainingsNotebookBackend”  następnie klikamy na zieloną 	ikonę w kształcie trójkąta
•	Aplikacja domyślnie uruchamia się na serwerze lokalnym, na porcie 8080. 
	http://localhost:8080/

Instalacja Node.js
•	Pobieramy Node.js ze strony producenta
	https://nodejs.org/en/download/
•	Instalujemy oprogramowanie za pomocą pobranego pliku.
•	Podczas instalacji upewniamy się że „npm package manager” jest częścią pakietu instalacyjnego


Instalacja Angular CLI
•	Uruchamiamy wiersz poleceń i wpisujemy poniższą komendę, aby upewnić się że poprzednia instalacja zakończyła się sukcesem
	npm -v
•	Teraz wpisujemy komendę:
	npm install -g @angular/cli
•	Robimy sprawdzenie za pomocą komendy 
	ng –version

Instalacja Visual Studio Code
•	Teraz pobieramy oprogramowanie Visual Studio Code z poniższego linku:
	https://code.visualstudio.com/download
	Importujemy projekt wybierając z górnego menu:
	File > Open File 
	Następnie z katalogu z aplikacją wybieramy folder „TrainingsNotebookFrontend”
•	Będąc w Visual Studio Code z górnego menu wybieramy:
	Terminal > New Terminal
	Upewniamy się że ścieżka w terminalu prowadzi do folderu „TrainingsNotebookFrontend”
	Następnie przystąpimy do instalacji niezbędnych bibliotek, w tym celu wpisujemy komendę:
	npm install
	Po zakończeniu instalacji wpisujemy komendę
	ng serve
	Powyższa komenda buduje aplikację
•	Aplikacja będzie uruchomiona na serwerze lokalnym na porcie 4200
 	http://localhost:4200/
