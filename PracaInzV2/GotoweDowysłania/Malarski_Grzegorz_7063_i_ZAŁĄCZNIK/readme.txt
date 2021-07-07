1. Instalujemy MySQL Workbench 8.0 Community
Oprogramowanie trzeba pobrać ze strony producenta: https://dev.mysql.com/downloads/workbench
Tworzymy urzytkownika login: root hasło: admin
Tworzymy schemat bazy danych "trainings_notebooks_v2"

2. Instalujemy i konfigurujemy Intellij Ulitmate edition
Oprogramowanie trzeba pobrać ze strony producenta: https://www.jetbrains.com/idea/download/#section=windows
Importujemy projekt z załącznika TrainingsNotebookBackend -> Backend
Aplikacja będzie uruchomiona na serwerze lokalnym na porcie 8080
http://localhost:8080/

3. Instalacja Node.js
Oprogramowanie trzeba pobrać ze strony producenta: https://nodejs.org/en/download/

4. Instalacja Angular CLI v10.2.0 
Dzieki temu że w poprzednim kroku zaintalowalismy node.js, możemy używać "Node Package Manager"(npm).
Będąc terminalu wpisujemy poniższą komendę:
npm install -g @angular/cli

5. Instalujemy Visual studio code
Oprogramowanie trzeba pobrać ze strony producenta: https://code.visualstudio.com/download
Importujemy projekt z załącznika TrainingsNotebookFrontend
W celu instalacji niezbędnych bibliotek otwieramy w terminalu katalogu z folderem "TrainingsNotebookFrontend", następnie wpisujemy komendę:
npm install
Aby zbudować i uruchomić aplikację w terminalu katalogu z folderem "TrainingsNotebookFrontend" wpisujemy poniższą komendę:
ng serve
Aplikacja będzie uruchomiona na serwerze lokalnym na porcie 4200
http://localhost:4200/


