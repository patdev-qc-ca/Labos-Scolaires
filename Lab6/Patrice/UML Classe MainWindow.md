# UML Classe: MainWindow
# Attributs:
+ Generateur gen
# Constructeur:
+ public Generateur(int nombreEtapes, string procedure)
+ public Generateur()
# Methodes:
+ public int GetDesignationType()
+ public int GetNombreEtapes()
+ public string GetProcedure()
+ public string GetDesignationType(int position)
+ public void GenererMessageEtapes()
+ public List<Elements> GenererListeElement()
+ public string[] CompositionID()