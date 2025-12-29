Instructions dans le gestionnaire de paquets

PM> add-migration MigrationInitiale
  +  Build started...
  +  Build succeeded.

PM> Update-Database
  +  Build started...
  +  Build succeeded.
  +  Applying migration '20230419045832_MigrationInitiale'.
  +  Done.

PM> add-migration MigrationInitiale_CreerTable
  +  Build started...
+  Build succeeded.

PM> Update-Database
+  Build started...
+  Build succeeded.
+  Applying migration '20230419045832_MigrationInitiale'.
+  Applying migration '20230419051117_MigrationInitiale_CreerTable'.
+  Done.
