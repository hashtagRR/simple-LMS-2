# simple-LMS-2 (SarasaviLibrary)

A desktop Library Management System for a fictional "Sarasavi" library,
built with C# Windows Forms (using the [MetroFramework](https://github.com/animatedbatman/mono-metroframework)
UI toolkit) and a local Microsoft Access database.

This is a coursework/learning project, not production software.

## What it does

Librarians log in (checked against a `librarian` table in the Access
database) and land on a tile-based home screen (`pages/Home.cs`) with
access to:

- **Book/Copy Management** (`Register_book.cs`) — add books/copies to the
  catalogue.
- **Librarian Management** (`Librarian_management.cs`) — manage librarian
  accounts.
- **Member Management** (`Member_management.cs`) — manage library member
  records.
- **Visitor Management** (`Visitor_management.cs`) — track visitors.
- **Search Book / Check Copy** (`Make_inquiry.cs`) — look up books and copy
  availability.
- **Reserve Book** (`Reservations.cs`) — place reservations for members.
- **Loan** (`Loan.cs`) — check out books to members.
- **Return** (`Return.cs`) — process book returns.

## Project layout

- `SarasaviLibrary.sln` — Visual Studio solution.
- `pages/` — the actual C# project (despite the folder name, this holds
  the whole `SarasaviLibrary.csproj`, all forms, and the Access database):
  - `Form1.cs` — the login form (queries the `librarian` table via
    `OleDbConnection`/OleDb over `Sarasavi_DB.accdb`).
  - `Sarasavi_DB.accdb` — the Access database file the app reads/writes
    directly (via the ADO.NET typed DataSets `Sarasavi_DBDataSet` /
    `Sarasavi_DBDataSet1`).
  - The various `*.cs`/`*.Designer.cs`/`*.resx` triples are the feature
    forms listed above.
- `Login.txt` — a leftover plain-text note with a sample username/password
  (`qwer` / `1234`); it is **not** read by the application at runtime — the
  app authenticates against the `librarian` table in the Access database,
  not this file.

### Checked-in build artifacts

This repository has build output committed alongside the source:

- `bin/` and `obj/` — Visual Studio build output (compiled `.exe`, `.pdb`,
  resource caches, and a copy of the Access database as it existed at
  build time).
- `vs.zip` — a zipped `.vs/` Visual Studio user-settings folder (editor
  state, not source).

These are left as-is (this pass is documentation-only); a real cleanup
would add a `.gitignore` and remove `bin/`, `obj/`, and `vs.zip` from
version control.

## Running it

1. Requires Windows with the Microsoft Access Database Engine (ACE OLEDB
   12.0 provider) installed, since the app connects via
   `Provider=Microsoft.ACE.OLEDB.12.0` to the bundled `.accdb` file.
2. Open `SarasaviLibrary.sln` in Visual Studio (targets .NET Framework
   4.5.2).
3. Build and run (F5). The login form will use `pages/Sarasavi_DB.accdb`
   as its data source (via the `|DataDirectory|` placeholder, which
   resolves to the output directory next to the built `.exe`).
4. Log in with credentials that exist in the `librarian` table of that
   Access database (inspect/edit the `.accdb` directly with Access or a
   compatible tool if you need to add one).
