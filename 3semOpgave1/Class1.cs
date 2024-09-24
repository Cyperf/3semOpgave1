namespace _3semOpgave1
{
    public class Class1
    {
        /*
         * Opgave 1 Class Library og Unit test
Lav et projekt af typen “Class Library”.


Lav en klasse Trophy med properties (bemærk de forskellige constraints):

Id, et tal
Competition, tekst-streng, min 3 tegn langt, må ikke være null
Year, tal, 1970 <= year  <= 2024
samt en ToString() metode

Der skal være validerings-metoder til de relevante properties.
Valideringsmetoderne skal kaste passende exceptions


Tilføj en unit test til dit projekt.

Din unit test skal have et godt “Code Coverage”

Opgave 2 Repository-klasse
Fortsæt i projektet fra forrige opgave.

Lav en klasse TrophiesRepository.

Klassen skal indeholde en liste af Trophy objekter. Indsæt mindst 5 objekter i listen.

Klassen skal have flg metoder:

Get()
Returnerer en kopi af listen af alle Trophy objekter: Brug en copy constructor.
Get() skal give mulighed for at filtrere på Year.
Get() skal give mulighed for at sortere på Competition eller Year .
GetById(int id)
Returnerer Trophy objektet med det angivne id - eller null.
Add(Trophy  trophy)
Tilføj id til trophy objektet. Tilføjer trophy til listen. Returnerer Trophy objektet
Remove(int id)
Sletter Trophy objektet med det angivne id. Returnerer Trophy objektet - eller null.
Update(int id, Trophy values)
Trophy objektet med det angivne id opdateres med values.
Returnerer det opdaterede Trophy objekt - eller null.

Din repository-klasse skal unit testes: Du kan nøjes med at teste tre metoder.

Din testede metoder skal have et godt “Code Coverage”


Besvarelsen på opgave 1 + 2 skal lægges i et GitHub repository.
        */
    }
}
