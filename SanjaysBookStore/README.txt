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


 
