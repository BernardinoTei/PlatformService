# Repositories
Repositories related to the project:

- [PlatformService](https://github.com/BernardinoTei/PlatformService)
- [CommandService](#)
- [K8S](#)



## PlatformService
    Simple microservice to function as an "asset register" and  
    "track all platforms /systems" in a fictional company
 
## Stack

- .Net 6

## Development 
    Essentials tools:

- Docker
- Minikube
- kubernetes
- Insomnia

## Dev Enviroment

To run the app in the terminal: 
 ```
 dotnet run
 ```

To run the app on docker: 
 ```
 docker build
 
 docker run -p 8080:80 -d bernei/platformservice
 ```

To run the using Kubernetes/Minikube:
 ``` 
 minikube start --driver=docker

 kubectl apply -f platforms-depl.yaml 

 kubectl apply -f platforms-np-srv.yaml 

 minikube service platformnpservice-srv --url
 ```
 


### Author

(c) 2023 Bernardino Teixeira

