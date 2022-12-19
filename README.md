# AkvelonTrainee
Implemented:
1. Pattern Repository
2. UoW
3. Specification pattern
4. 3-Layer architecture
5. Validation
6. Dockerfile build and run works (cd to folder with dockerfile, docker build -t akvelonapi ., docker run --name akvelonapi -p 80:80 akvelonapi:latest)
7. Docker-compose build and up works (cd to folder with docker-compose, docker-compose build, docker-compose up)
8. Xml comments (where needed)

Not-Implemented:
1.Unit tests

To start the application you should clone this project, open vs, start the application with AkvelonProfile 
![image](https://user-images.githubusercontent.com/55590417/208481030-98d29b52-1c7a-4220-84a1-ca2194f83a68.png)
Also you should have postgresql on your computer

Notes:
1. In filtering-sorting method you should pass "SortByField" property with the same name as a "ProjectCriteriaRequest" properties (i.e. in class string Name{get;set;} - you should pass "Name") . 


