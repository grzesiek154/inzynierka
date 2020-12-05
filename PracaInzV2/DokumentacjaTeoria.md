# 1. Analiza Zadania Dyplomowego



## Pojęcia:

- Prakseologia wskazuje, jak dobierać środki do celów, jak precyzyjnie i skutecznie realizować je (stąd powstało pojęcie skuteczności jako stopień zgodności wyniku z celem).
- Cel definiuje się więc jako wyobrażony stan rzeczy, mogący być skutkiem naszego działania w określonym czasie.
- Działanie zmierza do uzyskania lub utrzymania tego stanu rzeczy, a sam cel wyznacza kierunek i strukturę jego działania. Działać celowo może: człowiek, organizacja społeczeństwo i robot.
- Cel
  Prawidłowo postawiony cel powinien być określony przez następujący zestaw pytań:
  –Co? - ma być zrealizowane
  –Gdzie? - należy tego dokonać
  –Kiedy? - w jakim terminie cel ma być osiągnięty. Często należy odpowiedzieć na pytanie: Jakie? - środki będą potrzebne na realizację celu.
- METODYKA
  Metodyka tworzenia systemu to zbiór zasad, reguł, sposobów, wytycznych, wskazówek, przepisów i algorytmów prawidłowego wykonania dzieła użytkowego, którym jest system informatyczny.
  Metodyka tworzenia systemu spełnia następujące zadania:
  •rozstrzyga podstawowe kwestie związane z filozofią" podejścia do problemu tworzenia systemu,
  •wskazuje, w jakich (kolejnych) fazach, etapach i krokach system powinien być budowany,
  •decyduje o organizacji procesów tworzenia systemu,
  •rekomenduje techniki stosowane na poszczególnych etapach budowy systemu,
  •określa sposoby weryfikacji przyjętych rozwiązań cząstkowych oraz weryfikacji całego systemu,
  •narzuca sposób dokumentowania rezultatów prac na kolejnych etapach budowy systemu.

## Fazy tworzenie dokumentacji

### Faza analizy

Ma dać odpowiedź na następujące pytania:
• co robi dany system?
• jakie są wyjścia, wejścia i procedury?
• jakie są silne strony, słabości, wąskie gardła?
• w jaki sposób nowy system spełni wymagania użytkowników?

Metody zbierania danych:
• wyciąganie informacji od użytkowników,
• analiza danych,
• prototypowanie,
• porównanie z systemem wzorcowym.

• istniejące dokumenty,
• obserwacje,
• ankiety,
• wywiady.

• Analiza zajmuje się określeniem co system ma robić, aby zaspokoić potrzeby użytkownika. Natomiast nie zajmuje się tym, w jaki sposób zadania systemu mają być zrealizowane - jest to definiowane na etapie projektowania.

# 2. Identyfikacja dziedziny(wymagań) problemu

–Wprowadzenie

 –cele, zakres i kontekst systemu 

–wyniki fazy strategicznej

–Opis ewolucji systemu –opis przewidywanych zmian wymagań wobec systemu

–Opis wymagańfunkcjonalnych–Opis wymagań pozafunkcjonalnych

–Model systemu (zwykle w formie graficznej)

–Słownik pojęć

–definicje i opis terminów niezrozumiałych dla jednej ze stron (terminy dotyczące dziedziny i informatyczne), a także terminy niejednoznaczne, zależne od kontekstu

-Dobra'lista wymagań generalnie nie mówi jak wymagania są implementowane, pozostawiając to projektantowi systemu

## Projekty są podmiotem trzech rodzajów wymagań:

–Wymagania biznesoweopisują (w terminologii handlowej) co ma być dostarczone lub wykonane w celu uzyskania wartości

–Wymagania produktoweopisują system lub produkt, który na jeden z możliwych sposobów wypełnia wymagania biznesowe

–Wymagania procesoweopisują procesy, które organizacja musi zrealizować i ograniczenia, które muszą być respektowane

• Szczegółowe wymagania funkcjonalne muszą opisywać możliwości systemu w zakresie zachowania oraz dostępnych operacji (czynności wykonywane przez system, odpowiedzi na akcje użytkownika).

• w jaki sposób system realizuje założone cele i wyniki biznesowe w ramach danej dziedziny

• jakie warunki muszą być spełnione, aby system mógł wykonać określone zadania,

• w jaki sposób użytkownik będzie mógł korzystać z systemu w celu realizacji określonych zadań 

​	–jaki moduł aplikacji oferuje określoną funkcjonalność,

​	 –jakie czynności użytkownik musi wykonać w celu uzyskania danego rezultatu

## Klasyfikacja wymagań

### Wymagania funkcjonalne 

opisują funkcje (czynności, operacje, usługi), które system ma realizować, na przykład: zbieranie informacji o klientach firmy lub wprowadzanie/usuwanie/modyfikacja towarów do/z/w koszyka zakupów.

### Wymagania pozafunkcjonalne 

specyfikują kryteria osądzania działania systemu. Są one znane jako wymagania jakościowe

• Wymagania pozafunkcjonalne: nie dotyczą bezpośrednio konkretnych funkcji systemu: ograniczenia usług i funkcji systemu (np. czasowe, dotyczące procesu tworzenia, standardy, itd.).

• Mogą być związane z właściwościami systemu, jak: czas reakcji, niezawodność, zajętość pamięci.

• Mogą definiować ograniczenia systemu (możliwości urządzeń wejścia-wyjścia, reprezentacje danych używane przez interfejsy).

#### Wymagania pozafunkcjonalne wynikają z:

potrzeb użytkownika

ograniczeń budżetowych

strategii firmy

konieczności współpracy z innymi systemami (sprzętu lub oprogramowania)czynników zewnętrznych jak przepisy o bezpieczeństwie, ustawy chroniące prywatność, itd.

#### Klasyfikacja wymagań pozafunkcjonalnych: 

Wymagania produktowe–zachowanie produktu (wymagania efektywnościowe –szybkość działania systemu i potrzeb pamięci, wymagania niezawodności –akceptowalna częstość awarii), wymagania przenośności, wymagania użyteczności.

Wymagania organizacyjne–wynikają ze strategii i procedur w firmie-kliencie i w firmie-wytwórcy (standardy procesu, wymagania implementacyjne: język, metoda programowania, wymagania dostawy –kiedy dostarczyć produkt i jego dokumentacje).

Wymagania zewnętrzne–szeroka kategoria: wszystkie wymagania wynikające z czynników zewnętrznych dla systemu i procesu jego tworzenia (wymagania współpracy: interakcje z systemami innych firm, prawne, etyczne: akceptacja).