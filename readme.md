By Cat Hamm

<b>APPLICATION SUMMARY</b>

This movie tracker is an MVC application that uses SQL and entity framework to create a database of the user's movies to watch as well as a database of movies they have already watched. The application has a home page, a page for the watch list, and a page for the completed list. The watch list page has a form where the user can enter the title, director, and summary of the movie they want to add. They can then add that movie to their list. The user can also bypass this form to simply view their list. Once they have watched a movie, they can then remove it from that list. The completed page works in a similar way. It has a form where the user can enter the title, director, and summary of the movie they have watched. In this form, however, they can also enter a rating for the movie to refer back to how much they liked it. 

<b>FUNCTIONS / METHODS</b>

<i>CREATE ENTRY</i> This function creates the user's movie entry within either the Watch List SQL database or the Completed database. It will create the entry with the data the user enters including the movie's title, director, summary, and rating (for completed movies only).

<i>DELETE ENTRY</i> This function deletes the users entry. It can be used in either database, but would primarily function for the Watch List. This way, once the user watches the movie, they can remove it from the Watch List and add it to the Completed List if they so choose.

<i>EDIT ENTRY</i> This function allows the user to make any necessary edits to their entries. If they realize they want to add some more detail or change the rating of their entry then they can edit the database entry to reflect their current thoughts.

<b>CLASS / OBJECT</b>

<i>CONTEXT / DBCONTEXT</i> The context class allows the information to save to the SQL database and the dbContext inherits properties from the Context.

<i>HOME CONTROLLER</i> The home controller works within the nav bar for the home page.

<i>MOVIES CONTROLLER</i> The movies controller works within the nav bar for the watch list page.

<i>WATCHED CONTROLLER</i> The watched controller works within the nav bar for the completed movies page.

<i>MOVIES MODEL</i> The movies model sets up the types of data that can be entered by the user into the Watch List database.

<i>WATCHED MODEL</i> The watched model sets up the types of data that can be entered by the user into the Completed Movies database.

<b>FEATURES</b>

<i>VISUALIZING DATA</i> The MVC application visualizes the data from two separate SQL databases. It displays the data from both the Watch List database and the Completed Movies database in easy to navigate rows and columns.

<i>WRITING DATA TO DATABASE</i> This application allows the user to write their own data to either the Watch List or Completed database in order to track their movie viewing.

<i>READ DATA FROM EXTERNAL FILE</i> The application reads data from an external file by reading the database information in order to display it back to the user in a table.

<i>INHERITING CLASSES</i> Several classes inherit properties from other classes including the Context/dbContext and the Controllers.

<i>CRUD OPERATIONS</i> The application can create, read, update, and delete information within the databases to reliably store the user's information.