# Donde esta la biblioteca

## Sujet 

Vous allez réaliser une petite application qui vous permettra de gérer une liste de bibliothèque ayant des livres à louer.
Une petite BDD sera jointe au projet qu'on va essayer d'enrichir au maximum.
L'idée est d'être en autonomie par Groupe de 2.

Le but du projet est de voir un maximum de choses que .NET peut vous apporter donc n'hésitez pas à demander au prof.

### Critère de qualité

- Commit régulier, au moins à chaque étape
- Indentation
- En Anglais ou en Français mais garder la même logique tout du long
- Nommage :
  - "Singulier" pour un objet simple et "Pluriel" pour une liste 
  - PascalCase : Pour les noms de classe et interface...
  - camelCase : Pour les variables
  - _camelCase : Pour les variables déclaré au niveau de la classe
  - Nom d'interface commençant par un I
  - Nom de classe abstraite par un A

## TODO

### Etape 1 : Créer sa solution .NET

Créer une application console nommé LibraryManager. N'oubliez pas d'ajouter le nuget : Microsoft.Extensions.Hosting
Et mettre en place son architecture de projets (ClassLibrary) :
- `BusinessLayer` : Couche métier; on va y mettre toute la logique métier
- `Services` : Couche services intermédiaire; va permettre d'orchestrer les besoins et de relier d'autres couches entre elles
- `BusinessObjects` : Couche contenant vos objets métier (objets de bdd, de travail)
- `DataAccessLayer` : Couche permettant l'accès aux données; on y retrouvera notamment les repository

PS : Votre projet créer avec la solution fait office de couche d'entrée à l'application et configuration

~Ce qui est écrit n'est pas gravé dans le marbre ~

Créer une méthode Main dans le `Program.cs` grâce aux recommandations VS.

### Etape 2 : Préparer son architecture

1. Dans votre projet `BusinessObject`, créez un dossier `Entity`, puis dans ce dossier créez les objets correspondants aux tables du fichier `LibraryInit.sql`
2. Dans votre projet `Services`, créez un dossier `Services`, puis dans ce dossier une classe `CatalogService`
3. Dans votre projet `DataAccessLayer`, créez un dossier `Repository`, puis dans ce dossier une classe `BookRepository`
4. WIP

### Etape 3 : LINQ

Pour plus d'informations : [LINQ - Microsoft](https://learn.microsoft.com/fr-fr/dotnet/csharp/linq/)

### Etape 4 : Injection de dépendance

Pour réaliser de l'injection de dépendance, créez une réplique de toutes vos classes concrètes ayant de la logique et instanciés ailleurs dans votre code.

Pour plus d'informations : [Injection de dépendance - Microsoft](https://learn.microsoft.com/fr-fr/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-8.0)

### Etape 5 : EntityFramework



### Etape 6 :


### Ressources

- StackOverflow
- Doc Microsoft

### Raccourcis utiles 

- Recommandation VS : `Alt + Entrée`
- Renommer un élément et ses références : `(Hold) CTRL + R + R`
- Créer une propriété : `(Write) prop + Tab`
- Créer un constructeur: `(Write) ctor + Tab`
- Redirection sur la classe concernée : `F12`
- Redirection sur la classe concrète concernée : `Ctrl + F12`
- Afficher le contenu de l'élément dans un encart : `Alt + F12`
- Lancer en Debug : `F5`
- Faire continuer le programme : `F5`
- Instruction suivante : `F10`
- Instruction suivante dans la méthode : `F11`
