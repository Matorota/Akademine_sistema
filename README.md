# Akademine_sistema

# Academic Management System 🎓

WinForms app (C# + SQL Server) for managing students, teachers, and courses with role-based access.

## Features
- **Roles**: Admin (full access), Teacher (grade management), Student (view grades)
- **Database**: SQL Server (LocalDB) with secure data storage
- **Simple UI**: Windows Forms interface

## Setup
1. Clone repo
2. Open `Akademine_sistema.sln` in Visual Studio
3. Ensure `AkademineDB.mdf` is in project root
4. Update connection string in `App.config` if needed
5. Build & run

   ## Lithuanian
### Aprasymas
Sistema ir jos struktūra: Sukurta akademinė sistema atitinka pagrindinius reikalavimus ir užtikrina skirtingų naudotojų tipų, tokių kaip administratorius, dėstytojas ir studentas, valdymą ir funkcionalumą. Kiekvienas naudotojas turi pritaikytą prieigą ir galimybes, kurios yra būtinos efektyviam akademiniam valdymui.
### Funkcionalumas:
o	Administratorius turi platų funkcionalumą, įskaitant studentų, dėstytojų, pamokų ir grupių valdymą. Jis gali atlikti CRUD operacijas su visais pagrindiniais duomenimis ir užtikrinti sistemos priežiūrą.
o	Dėstytojas gali įrašyti ir redaguoti studentų pažymius, taip pat matyti savo pamokas ir grupes, kas leidžia efektyviai stebėti studentų pažangą.
o	Studentas turi galimybę peržiūrėti tik savo pažymius ir informaciją apie pamokas, užtikrinant, kad jo privatumą ir duomenų apsaugą būtų laikomasi.
3.	Techninė įgyvendinimo dalis:
o	Naudota C# ir Windows Forms (WinForms) technologija, leidžianti sukurti vartotojo sąsają, kurioje galima atlikti įvairius veiksmus pagal naudotojo teises.
o	Duomenų bazė (AkademineDB) užtikrina duomenų saugojimą ir valdymą, kur administratoriui suteikiama galimybė atlikti visus valdymo veiksmus, dėstytojui — tik redaguoti savo įrašus, o studentui — tik peržiūrėti savo duomenis.

Jei atsitinka error su database reiškia teks pakeisti path connection. Duonbazė randasi pagrindiniame aplanke 'AkademineDB.mdf'.
