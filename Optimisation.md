# Étape 4 - Optimisation : modifications

## Résumé

- **DTO** : l'API ne renvoie plus les objets des modèles mais des DTO (TuileDTO, PersonnageDTO, DeplacementDTO). Moins de données sont transmises et certaines informations sensibles sont cachées au client. Les modèles Tuile et Personnages ont maintenant un méthode ToDTO qui retour leur format DTO.
  
  ```csharp
	public PersonnageDTO ToDTO()
		=> new PersonnageDTO(idPersonnage, nom, niveau, pointsDeVie, pointDeVieMax, force, defense, posX, posY, dateCreation);
		
	public TuileDTO ToDTO()
	    => new TuileDTO(PositionX, PositionY, Type);
  ```

- **Langue** : tout ce qui touche le client (DTO, JS) est en anglais, le reste de l'API reste en français. Le JS a été renommé pour correspondre aux DTO (voir la partie traductions)
- **Codes HTTP plus précis :** AvoirPersonnage renvoie NoContent() ou Unauthorized() au lieu de BadRequest(). CreatePersonnage ne renvoie 1 qu'en cas de succès, sinon Unauthorized().
- **Nettoyage** : code commenté et Console.WriteLine de débogage retirés, using inutiles retirés, paramètres de DeplacementPossible clarifiés (pX → prevX), liste des personnages triée par date de création.
- **Context** : mise à jour du context : le HasKey est mis avant le HasData. Ça permet qu'Entity Framework ne crache pas s'il ne trouve pas le json du HasData.

## Fichiers modifiés

### API (C#)

| Fichier                              | Modification                                                                                                                                                        |
| ------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Models/DTO.cs                        | TuileDTO, DeplacementDTO, PersonnageDTO<br>avec ListToDTO pour TuileDTO et PersonnageDTO                                                                            |
| Models/DeplacementResult.cs          | Renommé en DeplacementDTO et déplacé dans DTO.cs                                                                                                                    |
| Models/Tuile.cs                      | Ajout de ToDTO()                                                                                                                                                    |
| Models/Personnage.cs                 | Ajout de ToDTO()                                                                                                                                                    |
| Models/TuileJS.cs                    | EstTraversable → CanGoThrough<br>Nom → Name<br>using retirés                                                                                                        |
| Controllers/DeplacementController.cs | AutourJoueur retourne un DeplacementDTO avec tuiles converties en DTO<br>DeplacementPossible : paramètres renommés                                                  |
| Controllers/TuileController.cs       | Les actions retournent des TuileDTO<br>la route api/Tuile devient api/Tuile/map, elle n'est pas encore utilisée mais ne pose aucun problème de sécurité.            |
| Controllers/PersonnagesController.cs | ListePersonnages et AvoirPersonnage retournent des PersonnageDTO<br>NoContent() ou Unauthorized()<br>tri par DateCreation<br>return 1 déplacé dans CreatePersonnage |

### Client (JS)

| Fichier                | Modification                                                                     |
| ---------------------- | -------------------------------------------------------------------------------- |
| js/api.js              | Variables locales renommées en anglais                                           |
| js/game.js             | Propriétés renommées selon les DTO<br>case non découverte devienne avec === null |
| js/init.js             | Propriétés renommées selon les DTO<br>mapJS initialisé à null                    |
| js/select-character.js | idPersonnage, nom, niveau deviennent id, name, level                             |

## Traduction des propriétés

| Objet                        | Français              | Anglais      |
| ---------------------------- | --------------------- | ------------ |
| Tuile (TuileDTO)             | PositionX             | X            |
| Tuile (TuileDTO)             | PositionY             | Y            |
| Type de tuile (TuileJS)      | Nom                   | Name         |
| Type de tuile (TuileJS)      | EstTraversable        | CanGoThrough |
| Personnage (PersonnageDTO)   | IdPersonnage          | Id           |
| Personnage                   | Nom                   | Name         |
| Personnage                   | Niveau                | Level        |
| Personnage                   | PointsDeVie           | Hp           |
| Personnage                   | PointDeVieMax         | MaxHp        |
| Personnage                   | Force                 | Strength     |
| Personnage                   | PositionX / PositionY | PosX / PosY  |
| Personnage                   | DateCreation          | CreationDate |
| Déplacement (DeplacementDTO) | EstValide             | IsCorrect    |
| Déplacement                  | Tuiles                | Tiles        |

Côté JS, certaines variables de retour du fichier api.js ont été traduites :

| Français   | Anglais                                                                                                                |
| ---------- | ---------------------------------------------------------------------------------------------------------------------- |
| tuiles   | tiles                                                                                                                |
| tuile    | tile                                                                                                                 |
| reussite | goodConnect (connect), registered (register), created (createCharacter), disconnecteds (disconnectApi) |
## Détail des DTO

```csharp
public class TuileDTO
{
	public int X { get; set; }
	public int Y { get; set; }
	public int Type { get; set; }
	public bool CanGoThrough { get; set; }
	
	public static List<TuileDTO> ListToDTO(List<Tuile> tuiles);
}
```

```csharp
public class PersonnageDTO
{
	public int Id { get; set; }
	public string Name { get; set; } = "";
	public int Level { get; set; }
	public int Hp { get; set; }
	public int MaxHp { get; set; }
	public int Strength { get; set; }
	public int Defense { get; set; }
	public int PosX { get; set; }
	public int PosY { get; set; }
	public DateTime CreationDate { get; set; }
	
	public static List<PersonnageDTO> ListToDTO(List<Personnage> persos);
}
```

```csharp
public class DeplacementDTO
{
	public bool IsCorrect { get; set; }
	public int FinalX { get; set; }
	public int FinalY { get; set; }
	public List<TuileDTO>? Tiles { get; set; } = null;
}
```