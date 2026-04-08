# 🏨 Hotel Reservation Management System

**Aplicație WinForms (.NET Framework 4.8) + MySQL** pentru gestionarea rezervărilor de hotel.

---

## 📋 Cuprins

1. [Cerințe de sistem](#cerinte-de-sistem)
2. [Instalare baza de date](#instalare-baza-de-date)
3. [Configurare conexiune](#configurare-conexiune)
4. [Compilare si rulare](#compilare-si-rulare)
5. [Structura proiectului](#structura-proiectului)
6. [Functionalitati](#functionalitati)
7. [Validari](#validari)
8. [Documentatie](#documentatie)

---

## Cerinte de sistem

| Componenta | Versiune minima |
|---|---|
| Windows | 10 / 11 |
| .NET Framework | 4.8 |
| Visual Studio | 2019 / 2022 (workload "Desktop development with C#") |
| MySQL Server | 5.7+ sau 8.0+ |
| NuGet package | MySql.Data 8.3.0 |

---

## Instalare baza de date

### 1. Instalati MySQL Server

Descarcati de la: https://dev.mysql.com/downloads/mysql/

### 2. Rulati scripturile SQL in ordine

**MySQL Command Line:**
```bash
mysql -u root -p < scripts/01_schema.sql
mysql -u root -p < scripts/02_seed.sql
```

**MySQL Workbench:**
- File -> Open SQL Script -> selectati 01_schema.sql -> Execute
- File -> Open SQL Script -> selectati 02_seed.sql -> Execute

**Scriptul `01_schema.sql`** creeaza:
- Baza de date `hotel_reservation`
- Tabelele: `camere`, `clienti`, `rezervari`
- Constrângerile de integritate referențială (FK)
- Indecsi de performanta

**Scriptul `02_seed.sql`** insereaza:
- 14 camere (etajele 1-3, tipuri: Single/Double/Suite)
- 8 clienti demo
- 5 rezervari demo

---

## Configurare conexiune

Editati fisierul `HotelReservation/App.config`:

```xml
<connectionStrings>
  <add name="HotelDB"
       connectionString="Server=127.0.0.1;Port=3306;Database=hotel_reservation;Uid=root;Pwd=PAROLA_TA;SslMode=none;CharSet=utf8mb4;"
       providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```

Pentru ecranul de autentificare, setati si:

```xml
<appSettings>
  <add key="LoginUsername" value="utilizatorul_tau" />
  <add key="LoginPassword" value="parola_ta" />
</appSettings>
```

Alternativ, puteti folosi variabile de mediu:
- `HOTEL_APP_USERNAME`
- `HOTEL_APP_PASSWORD`

Inlocuiti `PAROLA_TA` cu parola root MySQL sau creati un user dedicat:

```sql
CREATE USER 'hotel_user'@'localhost' IDENTIFIED BY 'hotel_pass';
GRANT ALL PRIVILEGES ON hotel_reservation.* TO 'hotel_user'@'localhost';
FLUSH PRIVILEGES;
```

---

## Compilare si rulare

### Visual Studio (recomandat)

```
1. Deschideti HotelReservation.sln in Visual Studio 2019/2022
2. Click dreapta pe proiect -> "Manage NuGet Packages"
3. Instalati: MySql.Data (versiunea 8.3.0)
4. Apasati F5 (Build + Run) sau Ctrl+F5 (Run without debugging)
```

### Linie de comanda (MSBuild)

```bash
# Restaurare pachete NuGet
nuget restore HotelReservation.sln

# Build
msbuild HotelReservation.sln /p:Configuration=Release

# Executabil generat in:
# HotelReservation/bin/Release/HotelReservation.exe
```

---

## Structura proiectului

```
hotel-reservation/
├── HotelReservation.sln                    # Fisier solutie Visual Studio
├── HotelReservation/
│   ├── HotelReservation.csproj             # Fisier proiect (.NET 4.8, WinExe)
│   ├── App.config                          # Configurare (connection string MySQL)
│   ├── packages.config                     # Pachete NuGet
│   ├── Program.cs                          # Entry point (STAThread)
│   ├── Models/
│   │   ├── Camera.cs                       # Model entitate Camera
│   │   ├── Client.cs                       # Model entitate Client
│   │   └── Rezervare.cs                    # Model entitate Rezervare
│   ├── Data/
│   │   ├── DatabaseHelper.cs               # Helper conexiune MySQL (App.config)
│   │   ├── CamereRepository.cs             # CRUD camere + harta disponibilitate
│   │   ├── ClientiRepository.cs            # CRUD clienti
│   │   └── RezervariRepository.cs          # CRUD rezervari + verificare suprapunere
│   ├── Forms/
│   │   ├── MainForm.cs                     # Shell principal + injectare dependențe în tab-uri
│   │   ├── MainForm.Designer.cs            # Structura tab-urilor (editabilă vizual)
│   │   ├── CamereUserControl.cs            # Logică tab Camere
│   │   ├── CamereUserControl.Designer.cs   # UI tab Camere (editabil vizual)
│   │   ├── ClientiUserControl.cs           # Logică tab Clienți
│   │   ├── ClientiUserControl.Designer.cs  # UI tab Clienți (editabil vizual)
│   │   ├── RezervariUserControl.cs         # Logică tab Rezervări
│   │   ├── RezervariUserControl.Designer.cs# UI tab Rezervări (editabil vizual)
│   │   ├── HartaUserControl.cs             # Logică tab Hartă
│   │   ├── HartaUserControl.Designer.cs    # UI tab Hartă (editabil vizual)
│   │   ├── RapoarteUserControl.cs          # Logică tab Rapoarte
│   │   └── RapoarteUserControl.Designer.cs # UI tab Rapoarte (editabil vizual)
│   └── Properties/
│       ├── AssemblyInfo.cs
│       └── Resources.resx
├── scripts/
│   ├── 01_schema.sql                       # Schema BD (CREATE TABLE + FK + indecsi)
│   └── 02_seed.sql                         # Date initiale (camere + clienti + rezervari)
└── README.md
```

---

## Functionalitati

### Tab: Camere
- CRUD complet: Adauga, Modifica, Sterge camere
- Campuri: Nr. Camera, Tip (Single/Double/Suite), Pret/Noapte, Etaj, Activa
- Validari: pret >= 0, campuri obligatorii nenule
- Click pe rand -> populare automata campuri de editare

### Tab: Clienti
- CRUD complet: Adauga, Modifica, Sterge clienti
- Campuri: Nume, Prenume, Telefon, Email (optional), Document identitate
- Validari: campuri obligatorii nenule

### Tab: Rezervari
- CRUD complet: Adauga, Modifica, Sterge rezervari
- Campuri: Client (dropdown), Camera (dropdown), Check-in, Check-out, Status, Pret Total
- Calcul automat pret total (nopti x pret/noapte)
- Validari:
  - Check-out > Check-in (obligatoriu)
  - Pret >= 0
  - Prevenire suprapunere: nu permite rezervare Confirmata daca camera e deja rezervata

### Tab: Harta Camere
- Vizualizare grafica a disponibilitatii camerelor pe interval ales
- Placi colorate per camera:
  - Verde = Libera
  - Rosu = Ocupata (rezervare Confirmata activa)
  - Galben = Rezervata viitor
- Click pe placa -> detalii camera (tip, etaj, pret, status)

### Tab: Rapoarte si Export
- Filtrare rezervari pe perioada
- Statistici: total rezervari, venit total, breakdown pe status
- Export CSV: fisier .csv cu separator ";", UTF-8
- Export TXT: raport formatat tabelar

---

## Validari

| Regula | Implementare |
|---|---|
| Pret >= 0 | Validare la adaugare/modificare camera si rezervare |
| Campuri obligatorii | Verificare inainte de orice INSERT/UPDATE |
| Check-out > Check-in | Validare la adaugare/modificare rezervare |
| Fara suprapunere | Query SQL verifica rezervarile Confirmate existente |
| FK integritate | Constrângeri BD (nu poți șterge client cu rezervări) |

---

## Documentatie

Structura recomandata pentru documentatia finala (minimum 15 pagini):

1. Coperta
2. Cuprins
3. Tema si obiectivele
4. Tehnologii folosite (.NET 4.8, WinForms, MySQL, MySql.Data)
5. Analiza cerintelor
6. Proiectarea bazei de date (ERD, tabele, constrângeri)
7. Arhitectura aplicatiei (Models / Data / Forms)
8. Interfata grafica (descriere form-uri, capturi de ecran)
9. CRUD Camere
10. CRUD Clienti
11. CRUD Rezervari + prevenire suprapunere
12. Functia speciala: Harta Camere vizuala
13. Validari si tratarea erorilor
14. Rapoarte si export (CSV, TXT)
15. Testare (scenarii, rezultate)
16. Concluzii
17. Bibliografie
18. Anexe (capturi de ecran obligatorii)

---

*Proiect realizat cu C# WinForms (.NET Framework 4.8) + MySQL*
