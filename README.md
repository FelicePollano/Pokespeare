# Pokespeare
Retrieve Pokemon description with the Shakespeare style
## How to use
The preferred way is by using docker. Just clone the repository and use the following command to build the image:
```
 docker build -t pokespeare .
```
After the process completes, you can run the image by issuing
```
  docker run -it -p 5000:80 pokespeare
```
you can use postman or, maybe just a browser to see some pokemon description in Shakespeare style

http://localhost:5000/pokemon/charizard
http://localhost:5000/pokemon/snorlax
http://localhost:5000/pokemon/ditto

##Building from source
In order to build the NETCore sdk 2.2 + is needed. You can download from here https://dotnet.microsoft.com/download/dotnet-core/2.2
After installing clone the repository and run the command:
```
  dotnet build
```
