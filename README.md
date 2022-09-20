### SovTechTaskRepo
# Readme file for my SovTech Task/Assessement


## Introduction: 

This is an OpenAPI Project with Swagger configured.
This Api abstract two(2) other APIs Chuck Norris API and Star Wars Api.
The API has three(3) Controllers(root paths) including Chuck,Swapi and Search 

## /Chuck

In the Chuck Controller there is an endpoint (/chuck/Categories) that returns all jokes categories
 ![chuck](https://user-images.githubusercontent.com/60079853/191253867-8dc15322-f7af-424c-97a2-0dc8edd4af3c.png)



# Response
 
 ![Resonses](https://user-images.githubusercontent.com/60079853/191254163-864445a1-3a47-4608-9590-5c278e6dc10e.png)

## /Swapi
In the Swapi Controller there is an endpoint (/Swapi/people) that returns all People(Star wars People.

![Swapi](https://user-images.githubusercontent.com/60079853/191254322-9ce5b903-7d2d-44ab-a0b0-f1dd545f83f4.png)

 # Response
 
 ![SwapiResponses](https://user-images.githubusercontent.com/60079853/191254305-6b81c6c3-7bb4-4acf-a459-50f01bf80a51.png)

 
## /Search
In the Search Controller there is an endpoint (/Search)  Searches Both the ChuckNorris and the Star Wars API with response contaiing a meta data indicating a particular API the results belongs to.

![Search](https://user-images.githubusercontent.com/60079853/191252439-c8e15242-db79-4930-a5a1-769a3361c1ce.png)

# Response

![SearchResponse](https://user-images.githubusercontent.com/60079853/191253073-69e34011-4e87-44fa-97e3-ef5f62d3984c.png)

 


 ## /Chuck/random
In the Chuck Controller there is an endpoint (/chuck/random) that returns random result based on category selected .

![chuckRandom](https://user-images.githubusercontent.com/60079853/191256765-cb675b8a-4ce2-4673-adba-333d0b66c182.png)

# Response

![randomResponse](https://user-images.githubusercontent.com/60079853/191256801-60e90638-b1eb-4cf2-acfc-3981f69e2563.png)


## /Swapi/people/{id}
In the Swapi Controller there is an endpoint (/Swapi/people{id}) that uses the people id to query and select a  returns a particular person. 

![swapipeople](https://user-images.githubusercontent.com/60079853/191257583-4661de77-4b01-4e72-8423-79858f72077c.png)


# Response

![swapipeopleresponse](https://user-images.githubusercontent.com/60079853/191257647-abda01d5-18fc-40d5-bc20-5df120df242b.png)



##  Technologies used
     .NET framwwork
     ASP.NET Web Api for my REST Api
     Swagger for Documentation 
     Angular js for my SPA
     GitHub for my Version Control
     Visual Studio as my Work Bench(IDE)
     SmarterAP.NET for hosting of my solution
     
##    Get Started: To use this App do the following

      i. Download an Install Visual studion
      2.Go to your CMD,Gitbash or your command prompt
      3. enter the following git command to clone the project
      git clone https://github.com/ushie-cpu/SovTechTaskRepo.git
      or download the project and unzip
      4. open project on your Visual studio and then run to test
      
##   Data sources:

        chunk URL : http://johnuj-001-site1.ftempurl.com/Chuck/categories
        
        Swapi URL : http://johnuj-001-site1.ftempurl.com/Swapi/people?page=1
        
        
##   Endpoints Description:

       | Endpoints                      | Methods     | Description note    |
       | ------------------------------ | ------------|---------------------|
       | /chuck/category                | Get         | Gets all categories |
       | /chuck/random                  | Get         | Gets random categories |
       | /Swapi/people                  | Get         | Gets all Star Wars People|
       | /Swapi/people{id}              | Get         | Gets people with id |
       | /Search/                       | Get         | Gets all  searches |



