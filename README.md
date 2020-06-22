# DAN_XXXVI_MilosPeric
Daily task 36

Tekst zadatka

Kreirati konzolnu aplikaciju za generisanje matrica koristeći thread-ove. Prvi
thread je zadužen za inicijalizovanje prazne matrice veličine 100x100.
Taj thread čeka drugi thread koji je zadužen za generisanje 10000 nasumičnih
brojeva vrednosti između 10 i 99. Nakon generisanja brojeva, drugi thread daje
znak prvom thread-u da je izvršio svoj zadatak i da matrica može da se popuni,
nakon čega prvi thread popunjava matricu izgenerisanim brojevima.

Nakon što je matrica popunjena, startuju se dva thread-a. Jedan od njih treba
da uzme sve neparne brojeve matrice i smesti ih u jednodimenzionalni niz, a
zatim taj niz u tekstualni fajl, a drugi čeka da prvi upiše podatke u fajl, a
zatim iščitava te podatke i ispisuje ih u konzoli.
