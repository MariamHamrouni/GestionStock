*GestionStock
GestionStock est une application Windows Forms développée en C# destinée à la gestion de stock.
Elle utilise Entity Framework Core avec une base de données SQLite pour assurer la persistance des données.

*Architecture du projet
Le projet est structuré en deux parties principales :

1. Application Windows Forms - GestionStock
  CategorieForms : Gestion des catégories de produits (création, modification, suppression).

  ProduitForms : Gestion des produits (ajout, modification, suppression).

  Mouvement : Gestion des mouvements de stock (entrées et sorties).

  DashboardForm.cs : Formulaire principal affichant les statistiques et indicateurs clés.

  Main.cs & Program.cs : Points d’entrée de l’application.

  ServiceCollectionExtensions.cs : Extensions pour la configuration et l’injection des services.

2. Couche d’accès aux données - GestionStock.Data
  Context : StockDbContext gérant la configuration de la base SQLite et le mapping des entités.

  Entities : Définitions des entités métier : Categorie, Produit, MouvementStock.

  Enum : Énumération MouvementType (type de mouvement : entrée, sortie).

  Repositories : Implémentations des repositories pour accéder aux données (ex. CategorieRepository).

  Migrations : Fichiers de migrations EF Core.

*Fonctionnalités principales
  Gestion complète des catégories et produits.

  Suivi des mouvements de stock (entrées et sorties).

  Tableau de bord interactif avec indicateurs et statistiques.

  Persistante fiable des données grâce à SQLite et Entity Framework Core.

*Prérequis
  -NET 8.0 

  -Visual Studio 2022 (ou version compatible)

  -SQLite (inclus via package NuGet)



## Installation et exécution

1. Cloner le dépôt :
   ```bash
   git clone <url-du-projet>
  Ouvrir la solution GestionStock.sln avec Visual Studio.

  Restaurer les packages NuGet.

  Construire la solution.

  Lancer l’application via le projet GestionStock.

*Structure des dossiers

GestionStock/
├── CategorieForms/
├── Mouvement/
│   ├── MouvementDetailForm.cs
│   └── MouvementListFormcs.cs
├── ProduitForms/
│   ├── DetailProduitForms.cs
│   └── produitListForm.cs
├── DashboardForm.cs
├── Main.cs
├── Program.cs
└── ServiceCollectionExtensions.cs

GestionStock.Data/
├── Context/
│   └── StockDbContext.cs
├── Entities/
│   ├── Categories.cs
│   ├── MouvementStock.cs
│   └── Produit.cs
├── Enum/
│   └── MouvementType.cs
├── Migrations/
├── Repositories/
│   ├── CategorieRepository.cs
│   ├── MouvementsStockRepository.cs
│   └── ProduitRepository.cs
└── ServiceCollectionExtensions.cs


*Auteur
Hamrouni Mariam

*Licence
Ce projet est sous licence MIT. Voir le fichier LICENSE pour plus de détails.







