# SovTechTaskRepo
Repository for my SovTech Tech


1 - Introduction: This is an OpenAPI Project with Swagger configured.
This Api abstract two(2) other APIs Chuck Norris API and Star Wars Api.
The API has three(3) Controllers(root paths) including Chuck,Swapi and Search 
i /Chuck
In the Chuck Controller there is an endpoint (/chuck/Categories) that returns all jokes categories
 
 
ii. /Swapi
In the Swapi Controller there is an endpoint (/Swapi/people) that returns all People(Star wars People.
 
 
iii. /Search
In the Search Controller there is an endpoint (/Search)  Searches Both the ChuckNorris and the Star Wars API with response contaiing a meta data indicating a particular API the results belongs to.
 


iv. /Chuck/random
In the Chuck Controller there is an endpoint (/chuck/random) thta returns random result based on category selected .
v.ii. /Swapi/people/{id}
In the Swapi Controller there is an endpoint (/Swapi/people{id}) that uses the people id to query and select a  returns a particular person. 



2  Technologies used
     .NET framwwork
     ASP.NET Web Api for my REST Api
     Swagger for Documentation 
     Angualr js for my SPA
     GitHub for my Version Control
     Visual Studio as my Work Bench(IDE)
     
3 - Get Started: To use this App do the following

      i. Download an Install Visual studion
      2.Go to your CMD,Gitbash or your command prompt
      3. enter the following git command to clone the project
      git clone https://github.com/ushie-cpu/SovTechTaskRepo.git
      or download the project and unzip
      4. open project on your Visual studio and then run to test
      

4 - Data sources:
        chunk URL : http://johnuj-001-site1.ftempurl.com/Chuck/categories
        Swapi URL : http://johnuj-001-site1.ftempurl.com/Swapi/people?page=1
        
5 - Endpoints Description:

| Endpoints                      | Methods     | Description note    |
| ------------------------------ | ------------|---------------------|
| /chuck/category                | Get         | Gets all categories |
| /chuck/random                  | Get         | Gets random categories |
| /Swapi/people                  | Get         | Gets all Star Wars People|
| /Swapi/people{id}              | Get         | Gets people with id |
| /Search/                       | Get         | Gets all  searches |



