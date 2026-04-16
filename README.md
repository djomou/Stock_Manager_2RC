# Stock_Manager_2RC
Logiciel de gestion de stock developper en C#, .Net Framework, SQL Server Express :

    	Le langage de programmation : Ici nous avons eu à utiliser C#.

    	Le WinForms : cela intervient dans la conception graphique de notre logiciel. C’est bien lui le responsable de nos différents interface.

    	Le .Net Framework : Permet la mise en place de l’environnement d’exécution pour le C#.

    	SQL Server Express : Permet la gestion de la base de données relationnelle gratuite offerte par Microsoft et le stockage des données.

    	Le langage SQL : Langage de requête permettant de communiquer avec la base de données créé par SQL Server Express. 

    	Le Entity Framework : Est l’une des technologies les plus importante de notre projet car grâce au ORM (Object-Relationnelle Mapping) c’est lui qui créé le lien entre la base de données et le code écrit en C#. 

I. Installation : 

Pour l’installation suivre les étapes suivantes :

    • Tout d’abord, extrayez l’archive "Stock Manager 2RC".

    • Ensuite vous aurez un dossier nommé "Stock Manager 2RC".

    • Dans ce dossier est situer le logiciel "SqlLocalDB" c’est ce logiciel qui installer, vous permettra d’accéder à la base de donnée lier à l’application. Sans l’installation de celui-ci,               l’application ne pourra donc correctement fonctionner et une erreur sera générer lorsque vous tenterez d’accéder à l’application.

    • L’installation de "SqlLocalDB" est simple, juste suivre les indications de l’installateur et puis cliquez sur suivant et terminer l’installation. Il vous sera demander d’accepter les termes du       contrat de licence, cliquer sur accepter puis sur suivant et installer.

    •  Par la suite l’application "2RC Stock Manager" peut déjà être lancé sans souci, et aucune erreur ne sera signaler si vous avez belle et bien respecter les différentes étapes précédentes. Si         malgré tout, une erreur est survenu lorsque vous tenter de lancer l’application recommencer la procédure comme indiquez dans ce manuel.

    • L’application est situer dans le chemin d’accès suivant partant du dossier "Stock Manager 2RC" : "…\Stock Manager 2RC\Stock Manager 2RC\bin\Debug". Les 03 points correspondent au chemin d’accès     ou vous avez extrait l’archive. 

    • Lancez l’application "Stock Manager 2RC.exe" et vous pourrez l’utiliser convenablement.

II. Utilisation :

Par la suite, nous allons vous listez un ensemble d’étapes claires et concis, pour pouvoir utiliser l’application de façon convenable commençons par :

  • Le lancement de l’application : comme nous l’avons susmentionné l’application est situer dans un emplacement que vous aurez choisi lors de l’extraction de l’archive contenant le dossier lier au     projet. Dans tous les cas il s’agira surement d’un chemin se terminant par "…\Stock Manager 2RC\Stock Manager 2RC\bin\Debug".

  • La Connexion : A ce niveau, vous avez déjà lancé l’application et il s’agira tout simplement d’entrer les informations adéquates, pour pouvoir accéder à l’interface d’accueil du logiciel, enfin     de pouvoir avoir accès aux fonctionnalités du logiciel. 02 champs vous est proposer, le champ User_Name qui est déjà préalablement rempli par nos soins et donc vous ne pouvez en aucun cas             modifier la valeur, ce champs contient la valeur  "ADMINISTRATEUR". Et un autre champ Password que vous pourrez insérer. A cet effet, les mots de passe déjà inséré et qui permettent d’accéder à       l’interface d’accueil sont :
  
          • Password1234
          • Mot de passe  1234
          • Admin001
          • Dance1234
          • admin1234

  Néanmoins, il est possible vous-même d’ajouter vos propre mots de passe selon vos convenances mais en passant par le Super-Administrateur. Mais ce ci, fera l’objet du prochain paragraphe.
  
"Partie Réservé par le Super-Administrateur Début ! "
  
    • La Connexion au Super-Administrateur : Etant donné que l’utilisateur, c’est-à-dire vous qui lisez ce manuel d’utilisation, n’êtes pas habiliter à générer vous-même les mots de passe utilisateur     pour question de sécurité cette partie est essentiellement réserver au Super-Administrateur. Par ailleurs, si l’utilisateur à savoir l’administrateur à un mot de passe personnel qu’il voudrait        qu’on ajoute dans la base de donnée, des mots de passe permettant d’accéder à l’interface d’accueil de l’application, il devra passer par le Super-Administrateur et ainsi communiquer son mot de       passe au Super-Administrateur. Par la suite, le Super-Administrateur lui va aller cliquer sur l’élément "Avez-vous un mot de passe ?" présent sur l’interface de connexion. Ensuite, l’interface de     connexion du Super-Administrateur apparaitra, le Super-Administrateur devra à ce niveau insérer un mot de passe unique et personnel au Super-Administrateur il s’agit de "Super_Admin-001@". Pour       des questions de sécurité ce mot de passe ne doit être connu que du Super-Administrateur seul. Car seul lui est autorisé à ajouter des mots de passe pour des questions de sécurité.

    • Ajout des Mot de Passe par le Super-Administrateur : Cette partie aussi n’est réserver qu’au Super-Administrateur, car après avoir insérer le mot de passe unique connue Exclusivement par le         Super-Administrateur "Super_Admin-001@", une interface d’ajout de mot de passe sera afficher et ainsi, 02 champs sera afficher alors le Super-Administrateur devra juste ajouter le mot de passe        que l’administrateur lui a communiquer puis confirmer le mot de passe en question et le travail du Super-Administrateur s’arrête à ce niveau.

"Partie Réservé par le Super-Administrateur Fin ! "

  • L’interface d’accueil : A ce niveau, l’administrateur a pu se connecter à l’interface d’accueil via son mot de passe qui a été ajouter par le Super-Administrateur. Cette interface est assez intuitive et simple. Chaque fonctionnalité est assez visible et claire nous avons ici :
  
  • L’ajout d’article : interface très simple et intuitive. Il vous suffit juste de remplir les champs présenter à votre égard à savoir (Nom, Catégorie, Quantité, Seuil, Date D’ajout) puis cliquer sur Ajouter et rassurez-vous de les avoir totalement bien remplit si non une erreur vous sera notifier.

  • La Modification et La suppression : Les 02 vont un peu ensembles parce que l’on procède à peu près de la même façon pour modifier et supprimer. Il suffit, de sélectionner l’article que vous avez à modifier ou à supprimer ainsi donc les champs se remplirons automatiquement avec les données de l’article sélectionné, vous devez alors modifier juste la date de modification ou de suppression au jour correspondant puis s’il faut modifier, éditer la ou les champs à modifier puis cliqué sur modifier, ou alors s’il faut supprimer cliqué juste sur supprimer.

  • L’Historique : Cette interface vous permet juste de consulter vos différentes actions effectuées et quand vous l’avez fait.

  • Le Téléchargement : Cette fonctionnalité vous permet simplement de télécharger sous forme de fichier PDF, l’ensemble des articles enregistré et présent dans le tableau tel que vous le voyez dans l’application.
