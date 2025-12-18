# UML Classe: Elements 
# Attributs:
+ int id 
+ int Quantite
+ string name 
+ string description 
# Constructeur:
+ public Elements(int id, int quantite, string name, string description)
# Methodes:
+ public int GetId()
+ public int GetQuantite()
+ public string GetName() 
+ public string GetDescription()
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
