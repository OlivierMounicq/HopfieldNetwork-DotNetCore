### Hopfield Network

[![Build status](https://ci.appveyor.com/api/projects/status/aalmr0yn7mpy2vhf?svg=true)](https://ci.appveyor.com/project/OlivierMounicq/HopfieldNetwork-DotNetCore)

1/  Create a new folder by using the explorer  
2/  Launch Visual Studio Code  
3/  Open the folder HopfieldNetwork-DotnetCore  
4/  dotnet new sln (by using the terminal)  
5/  mkdir HopfieldNetwork  
6/  cd HopfieldNetwork  
7/  dotnet new classlib  
8/  cd ..  
9/  mkdir HopfieldNetworkTesting  
10/ cd HopfieldNetworkTesting  
11/ dotnet new mstest  
12/ dotnet add reference ../HopfieldNetwork/HopfieldNetwork.csproj  
13/	dotnet sln add ./HopfieldNetwork/HopfieldNetwork.csproj  
14/ dotnet sln add ./HopfieldNetworkTesting/HopfieldNetworkTesting.csproj	  
13/ dotnet build  
14/ dotnet test    
15/ git init  
16/ git commit -a -m "1st commit"  
17/ go github and create a new repository without readme   
18/ git remote add origin https://github.com/OlivierMounicq/HopfieldNetwork-DotNetCore.git  
19/ update the sln file by adding a project  		
20/ git commit -a -m "Add the testing project to the solution file"  
21/ git push origin master  
