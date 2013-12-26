KendoUiGridDemo
===============

This is a personal experiment in using Kendo Ui's Grid.  The actual project is an ASP.Net MVC4 using VS2012.

The design goal is to implement a grid for displaying and editing comments using the Kendo Ui Editor.  The requirements were:

*  All adds, updates & deletes need to be saved on the client and submitted as a batch back to server.
*  Editing shall be done in a Popup window.  
*  If the comment are "too" long, meaning over 300 characters, then the displayed text is the grid is truncated.  If the displayed text is "clicked", then the full comment is displayed in a popup window.
*   All deletes will have to be confirmed before the deletion is done.
*   Each comment will have a status associated with it so that the server can determine if the row was unchanged, new comment added, deleted or updated.
