# Application mediatek86
Application C# écrite sous Visual Studio 2022 Entreprise et exploitant une BDD MySQL.<br><br>

## Présentation de l'application
### Présentation du contexte
Afin de développer votre projet dans un contexte réaliste d’entreprise, nous vous proposons le contexte MediaTek86, un réseau qui gère les médiathèques de la Vienne, et qui a pour rôle de fédérer les prêts de livres, DVD et CD et de développer la médiathèque numérique pour l’ensemble des médiathèques du département.<br>
Vous travaillez en tant que technicien développeur junior pour l’ESN InfoTech Services 86 qui vient de remporter le marché pour différentes interventions au sein du réseau MediaTek86, dont certaines dans le domaine du développement d'application.<br>
Il vous a été confié le développement de l'application de bureau qui va permettre de gérer le personnel de chaque médiathèque, leur affectation à un service et leurs absences.<br>
Cette application est monoposte et sera installée sur un poste du service administratif.<br>
### But de l'application
Le responsable souhaite avoir <strong>un petit utilitaire pour gérer les absences du perosnnel</strong>.<br>
L'application mediatek86 représente cet utilitaire.<br>
L'application doit permettre de :

présenter la liste des personnes (nom, prénom, tel, mail, service) sachant qu'il existe une liste déterminée de services ;</li>
permettre d'ajouter une personne  ;</li>
permettre de modifier ou supprimer une personne ;</li>
permettre de ajouter une période d'absence.</li>
permettre de modifier ou supprimer une période d'absence.</li>

La liste des services est fixe et non modifiable via cette application.<br>

### Structure de la BDD
Voici le schéma conceptuel de données présentant la structure de la BDD qui est au format MySQL :<br>
https://github.com/yasserparis0107-source/mediatek86/blob/master/MediaTek86-mcd.zip



#### Explications sur les couches supplémentaires
L'application contient 2 paquetages supplémentaires par rapport au MVC classique :<br>
. 'bddmanager' : contient la classe qui permet d'accéder à la base de données MySQL et d'exécuter les requêtes (classe indépendante et réutilisable).<br>
. 'dal' (Data Access Layer) : répond aux demandes du paquetage 'controller' et exploite 'bddmanager' en lui demandant d'exécuter des requêtes.<br>
L'avantage de cette architecture est l'isolement de la connexion (bddmanager) par rapport au reste de l'application. Le controleur ne sait pas d'où viennent les données (cela pourrait être un autre SGBDR, voire un autre type de fichier, comme XML). Le paquetage 'dal' fait l'intermédiaire en préparant des requêtes SQL. Donc on sait dans les classes de ce paquetage, qu'il est question d'une base de données relationnelle, mais ne sait pas non plus quel est le SGBDR utilisé.<br>
Changer de SGBDR reviendrait à juste changer la classe BddManager (son contenu), donc ne travailler que sur le paquetage 'bddmanager'.<br>
Changer de type de fichier reviendrait à changer aussi les classes du paquetage 'dal', sans toucher au reste de l'application.
#### Présentation du cheminement
L'application démarre sur une vue : c'est la structure classique des applications C# de bureau, mais il serait aussi possible de démarrer sur un contrôleur principal.<br>
La vue crée une instance du contrôleur qui lui est dédié (chaque vue a son propre contrôleur). Quand elle a besoin d'accéder aux données (affichage ou demande de modifications), elle fait appel à son contrôleur.<br>
Le contrôleur fait appel aux classes de la couche 'dal' pour exécuter les demandes de la vue.<br>
Les classes de la couche 'dal' contiennent les requêtes qui doivent être exécutées et sollicitent la couche 'bddmanager' pour exécuter les requêtes.<br>
Chaque classe de la couche 'dal' est liée à une classe métier contenu dans 'model'. Ces classes correspondent aux tables de la base de données (avec une approche objet, donc pas de clés étrangères mais des références d'objets) et ne contiennent que la structure des données (propriétés, getters, setters).
Excepté 'bddmanager' qui est indépendant de l'application (réutilisable dans n'importe quelle application), toutes les couches exploitent le 'model' (pour le formatage des données).<br>


## Installation
Il est possible de tester l'application étape par étape (commit par commit) ou de tester directement la version finale.<br>
Pour tester une version dans un environnement de développement, il faut d'abord installer les outils suivants :<br>
. SGBDR MySQL (par exemple en installant WAMP ou un logiciel similaire)<br>
. De préférence un IDE pour manipuler le code (cette application a été réalisée sous Visual Studio 2022)<br> 
Il faut ensuite :<br>
. Dans MySQL, exécuter le script contenu dans mediatek86.sql (présent en racine du dépôt) pour créer et remplir la BDD.<br>
. Récupérer le code du commit voulu, l'ouvrir dans l'IDE et l'exécuter.
