*************************************************************************************
*                      Assignment-2                                                 *
*                      WEB 452                                                      *
*                     Sanjay Anand                                                  *
*                      0770698                                                      *
*************************************************************************************


*************************************************************************************
*                                                                                   *
*                             Part 1                                                *
*                                                                                   *
*************************************************************************************

2022-03-08
1116
Started the MVC application 
ASP.NET  core web app with individual account authentication
- Build it
- Created the README
- Test it

1119- Confirmed that the application works
1120- Changed the content of home page
1121- Created the Github Repo
1123- Confirmed the Repo

2022-03-09
0114- started again next day.  let's test it
0136- Added bootstrap theme from bootswatch.com
0139- Added the dopdown button menu
0140- tested the app, it's running great and the theme is awesome

march break started


20222-03-22

0940- Added those css files provided in the assignment 2 folder on blackboard
0950- tested the application
1130- class just got finished and here i am start working on the the assignment 2
1140- Added three new projects (class Library) in the application
      -SanjaysBooks.DataAccess
      -SanjaysBooks.Models
      -SanjaysBooks.Utility

1145- installed the Microsoft.EntityFramework Core.Relational and Core.SqlServer packages
1147- deleted the migration folder as told in the assignment 2 ppt
1148- it's time to install nuget package 
      - Identity.EntityFramework Core

1151- Modified the namespaces in the projects that i created within the main project.
      let's build it and run it.
      the build is successful in the second time because in the first time it says that you didn't install
      one of the nuget package.

     updated the github repo




  2314- Modified every project and build the solution and it's time to run it
        it's working just fine
2316- Updated the github repo


*************************************************************************************
*                                                                                   *
*                             Part 2                                                *
*                                                                                   *
*************************************************************************************


2022-03-29


0649- just started doing part 2 for assignment 2
0649- added the migration file in dataaccess project 20220329104813_AddDefaultIdentityMigration
0655- updated the database and it's time to run the application 
      it's good for next part.

 2022-03-30
     
 1408-   after building the project it showed this error- CS0311	The type 'SanjaysBooks.DataAccess.Repository.UnitOfWork' cannot be used as type parameter 'TImplementation' in the generic type or method 'ServiceCollectionServiceExtensions.AddScoped<TService, TImplementation>(IServiceCollection)'. There is no implicit reference conversion from 'SanjaysBooks.DataAccess.Repository.UnitOfWork' to 'IUnitOfWork'.	SanjaysBookStore	C:\Users\W0770698\Source\Repos\sanjayAnand0770698\SanjaysBookStore\SanjaysBookStore\Startup.cs	39	Active
 1411- Commented out services.AddScoped<IUnitOfWork, UnitOfWork>(); And now it works

 2022-04-01

 1552- Started the category CRUD part
 1611- Addded the category controller in adrea/admin/Controllers folder 
       there is some error showing even after using the "using" statement
	   Error- CS0122	'IUnitOfWork' is inaccessible due to its protection level	


2022-04-05

1108- Added a new index view in to the category folder  and copied the indexview.txt file content into it.
1110- it's time to run the application and it didn't run when i click on the category button.
1130- i reesolved the issue- the issue was that i created that index view file in views folder instead i had to make it in areas/admin folder
      so i tranferred the file and it is good and it's running just fine.

1140- Added the category button in the dropdown button

1143- The application is running and now i see my category button in the dropdown button.

1147- Made commits to the github and pushed them.

1153- Made some changes in index file of the category, added the font from font awesome and checked them in the browser and then deleted the code and made the
      javascript file for category and the copied the code provided by sir in the assignment 2 folder for js.

1210- added the section call for the javascript in category index and tested the application and yeah it's good.

1240- took a long break and back to coding.




2022-04-06

1010- Added covertype crud  
      addded covertype controller

1025- added covertype repo and irepo
1030- addded covertype to unitofwork and iwunitofwork and covertype to darabasee
1246- created migration 20220406164556 and updated the database
1305- commited on github

2022-04-09
0232-started doing product part
      added product class to model project, added the code provided by sir.

0233-added reference in the ApplicationDbContext file added the migration addproducttodb
     the timestamp is 20220409062931.

2022-04-10

2100- had some problem while updating the database so, deleted the migration  and added it back again and
     this time changed the Add a to lower and just updated the database and it's working.
     the new migration timestamp is 20220411005915.


     had some error in adding product



    2022-04-20
    

1209- added migration again and deleted the old ones the new added product to db timestamp is 20220420154409.
1236- added validationtoproduct and timestamp is 20220420160536. 

    1330- Added the upsert view tested the application. it's running but after
          adding the product it doesn't get added.



 
