# UML Classe: Generateur
# Attributs:
+ int nombreEtapes
+ string procedure
+ string[] designationType
+ string[][] etapes
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