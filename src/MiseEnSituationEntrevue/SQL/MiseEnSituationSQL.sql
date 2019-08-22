USE AdventureWorks2012;

/**
 * Notes concernant le test SQL
 * - Durée 20 minutes
 * - Basé entièrement sur la base de données AdventureWorks2012 (BD exemple de Microsoft bâtie
 *   selon les standards encouragés par Microsoft).
 * - Vous n'avez pas besoin d'être familier avec les données pour répondre aux questions (il n'y a pas de pièges en lien avec les données).
 * - En tout temps vous pouvez accéder à Internet.
 * - À la fin de chaque question les tables nécessaires sont indiquées.
 * - Une fois la question complétée, vous pouvez mettre votre réponse en commentaire et passer à la prochaine question.
 */

/**
 * Question #1
 * Récupérer la liste de toutes les personnes dont le prénom est David et dont l'information a été
 * modifiée durant l'année 2013 (retourner toutes les colonnes dans le résultat - Vous pouvez utiliser SELECT *).
 * Tables nécessaires : AdventureWorks2012.Person.Person
 */
 -- Écrire l'instruction SQL ici.
 -- Voir le fichier reponses.sql pour les réponses


/**
 * Question #2
 * La question 2 se répond grâce à une seule requête (une seule instruction SELECT). Si vous êtes bloqué sur un
 * des points, n'hésitez pas à passer au prochain (faites attention de ne pas perdre de temps de temps à chercher).
 * On veut récupérer certaines informations sur les prénoms les plus populaires. Chacun des points ci-dessous indique
 * les éléments qu'il faut ajouter à votre instruction SELECT.
 * A) Produire une liste unique de tous les prénoms (chaque prénom doit apparaître 1X).
 * B) Indiquer par combien de personnes chaque prénom est utilisé.
 * C) Trier la liste du plus grand nombre d'occurrences au plus petit.
 * D) Ne conserver que les prénoms qui apparaîssent 95X ou plus dans la BD.
 * E) Ajouter le nombre de noms de famille différents qui sont utilisés pour chaque prénom listé.
 * Tables impliquées : AdventureWorks2012.Person.Person
 */
 -- Écrire l'instruction SQL ici.
 -- Voir le fichier reponses.sql pour les réponses

/**
 * Question #3
 * On veut des statistiques sur le nombre de photos des produits qui ont au moins 1 "review".
 * La liste finale doit contenir uniquement 2 colonnes : le nom du produit et le nombre
 * de photos.
 * Tables impliquées : AdventureWorks2012.Production.Product, AdventureWorks2012.Production.ProductProductPhoto
 * et AdventureWorks2012.Production.ProductReview
 */
 -- Écrire l'instruction SQL ici.
 -- Voir le fichier reponses.sql pour les réponses

/**
 * Question #4
 * Complétez cette question uniquement si vous avez révisé toutes vos réponses précédentes.
 * On veut la liste des 100 produits les meilleurs vendeurs en 2014, avec le montant de vente pour chacun en 
 * milliers de $ (en 2014) et un indicateur (oui/non) pour savoir si chaque produit faisait parti des 100 
 * meilleurs vendeurs en 2011.
 * Tables impliquées : AdventureWorks2012.Production.Product, AdventureWorks2012.Sales.SalesOrderDetail
 * AdventureWorks2012.Sales.SalesOrderHeader
 */
 -- Écrire l'instruction SQL ici.
 -- Voir le fichier reponses.sql pour les réponses