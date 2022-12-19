# AkvelonTrainee

## Implemented:
  1. Pattern Repository
  2. UoW
  3. Specification pattern
  4. 3-Layer architecture
  5. Validation
  6. Dockerfile build and run works (cd to folder with dockerfile, docker build -t akvelonapi ., docker run --name akvelonapi -p 80:80 akvelonapi:latest)
  7. Docker-compose build and up works (cd to folder with docker-compose, docker-compose build, docker-compose up)
  8. Xml comments (where needed)

## Not-Implemented: <br>
  1. Unit tests

## Notes:
  1. To start the application you should clone this project, open vs, start the application with AkvelonProfile ![image](https://user-images.githubusercontent.com/55590417/208490380-c986e9f7-2988-487d-ae92-16cde54785a6.png) <br>
Also you should have postgresql on your computer
  2. In filtering-sorting method you should pass "SortByField" property with the same name as a "ProjectCriteriaRequest" properties (i.e. if in class - string Name{get;set;} - you should pass "Name"). 


