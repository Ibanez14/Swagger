

1)
- - - - - - Configure Swagger - - - - - 
1) Create WebAPI
2) Install package Swashbuckle.AspNetCore
3) Add Swagger generator to services collection (Code snippet  - Step 2)
4) Enable middleware (Code snippet - Step 2)
5) Run => localhost:5001/swagger
6) Alson may try  => localhost:5001/swagger/v1/swagger.json


2)
- - - - - - Configure RoutePrefix - - - - - 
Commented as RoutePrefix


3)
- - - - - - Configure SwaggerDoc - - - - - 
Commented as SwaggerDoc


4)
- - - - - - Generate Documentation - - - - - 
Reference is Swagger/Get Started with Swashbuckle => XML Comment (Section)
 - Edit csproj file adding GenerateDocumentationFile
 - Add services (commented as "Adding Documentation Generation Service")


5)
- - - - - - Remarks section in documentation - - - - - 
See ValuesController/Get


6)
- - - - - - Data Annotations (+ Default Value Attribute) in Swagger - - - - - 
Default Data Annotations + DefaultValueAttribute (Take a look at PersonModel)
ProduceAttribute for Controller (Take a look at Value Controller)


7)
- - - - - - Describe Response types - - - - - 
ProducesResponseType Attribute for describing responses and code (Take a look at ValuesController/Get)

8) 
- - - - - - Customize the UI with static file- - - - - 
Not implemented