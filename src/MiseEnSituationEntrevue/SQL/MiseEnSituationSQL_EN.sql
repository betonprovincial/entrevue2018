USE AdventureWorks2012;

/**
 * Notes concerning this SQL test
 * - Duration of 20 minutes
 * - Based on the AdventureWorks2012 database (example DB provided by Microsoft, based on 
 *   Microsoft's standards.
 * - You don't need to be familiar with the data to answer the questions (there's no trick question based on the data).
 * - You can use Internet at any time if you need to.
 * - At the end of every question all the tables you will need for the query are listed.
 * - Once you complete a question, you can comment your answer and go on with the next one.
 */

/**
 * Question #1
 * Retrieve the list of all persons whose first name is David and whose information was 
 * changed during the year 2013 (return all columns in the result - You can use SELECT *).
 * Tables : AdventureWorks2012.Person.Person
 */
 -- Write your SQL statement here.
 -- Answers are in the reponses.sql file


/**
 * Question #2
 * The question 2 has to be answered with a single request (one SELECT statement). If you are stuck on
 * a part, don't hesitate to skip it (be careful not to lose too much time searching). We want to retrieve
 * some information about the most popular first names. Each of the following instructions will indicate
 * what you need to add to your SELECT statement.
 * A) Retrieve a unique list of all the first names (each first name has to be listed 1X).
 * B) Indicate by how many people each name is used.
 * C) Sort the list from the highest number of occurences to the lowest.
 * D) Keep only the first names that appear 95X or more.
 * E) Add the number of different surnames that are used for each given given name.
 * Tables : AdventureWorks2012.Person.Person
 */
 -- Write your SQL statement here.
 -- Answers are in the reponses.sql file

/**
 * Question #3
 * We want statistics on the number of photos for products that have reviews. The final list must contain only 
 * 2 columns: the product name and the number of photos.
 * Tables : AdventureWorks2012.Production.Product, AdventureWorks2012.Production.ProductProductPhoto
 * et AdventureWorks2012.Production.ProductReview
 */
 -- Write your SQL statement here.
 -- Answers are in the reponses.sql file

/**
 * Question #4
 * Begin this question only if you've reviewed all your previous answers.
 * We want the list of the 100 best selling products in 2014, with the amount of sales for each in 
 * thousands of $ (in 2014) and an indicator (yes / no) to show if each product was among the top 100 
 * sellers in 2011.
 * Tables : AdventureWorks2012.Production.Product, AdventureWorks2012.Sales.SalesOrderDetail
 * AdventureWorks2012.Sales.SalesOrderHeader
 */
 -- Write your SQL statement here.
 -- Answers are in the reponses.sql file